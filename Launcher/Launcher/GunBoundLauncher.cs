using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Diagnostics;
using System.Security.Cryptography;
using System.IO;

namespace Launcher
{
    class GunBoundLauncher
    {
        public static string hiveLocation = @"Software\Softnyx\GunBound";

        private static byte[] AesEncryptBlock(byte[] plainText, byte[] Key)
        {
            byte[] output_buffer = new byte[plainText.Length];

            using (AesManaged aesAlg = new AesManaged())
            {
                aesAlg.Mode = CipherMode.ECB;

                aesAlg.BlockSize = 128;
                aesAlg.KeySize = 128;
                aesAlg.Padding = PaddingMode.None;
                aesAlg.Key = Key;

                // Create a encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                encryptor.TransformBlock(plainText, 0, plainText.Length, output_buffer, 0);
            }

            return output_buffer;
        }

        // not used, but nice to have around
        private static byte[] AesDecryptBlock(byte[] cipherText, byte[] Key)
        {
            byte[] output_buffer = new byte[cipherText.Length];

            using (AesManaged aesAlg = new AesManaged())
            {
                aesAlg.Mode = CipherMode.ECB;

                aesAlg.BlockSize = 128;
                aesAlg.KeySize = 128;
                aesAlg.Padding = PaddingMode.None;
                aesAlg.Key = Key;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                decryptor.TransformBlock(cipherText, 0, cipherText.Length, output_buffer, 0);
            }
            return output_buffer;
        }

        static string GunBoundLoginParameters(string username, string password)
        {
            // final block (unknown) looks like 4 DWORDs, first one being always zero, second always nonzero, third and fourth are occasionally zero
            List<byte> result = new List<byte>();
            byte[] key = { 0xFA, 0xEE, 0x85, 0xF2, 0x40, 0x73, 0xD9, 0x16, 0x13, 0x90, 0x19, 0x7F, 0x6E, 0x56, 0x2A, 0x67 };
            byte[] finalBlock = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            result.AddRange(AesEncryptBlock(StringToBytes(username, 16), key));
            result.AddRange(AesEncryptBlock(StringToBytes(password, 16), key));
            result.AddRange(AesEncryptBlock(finalBlock, key));
            return BitConverter.ToString(result.ToArray()).Replace("-", "").ToUpper();
        }

        static byte[] StringToBytes(string inputString, int desiredLength)
        {
            List<byte> inputBytes = new List<byte>(Encoding.ASCII.GetBytes(inputString));
            int paddingBytesNeeded = desiredLength - inputBytes.Count;
            for (int i = 0; i < paddingBytesNeeded; i++)
            {
                inputBytes.Add(0);
            }
            return inputBytes.ToArray();
        }

        // Legacy stuff from CLI version
        static Dictionary<string, string> ReadConfig(string appBasePath)
        {
            Dictionary<string, string> config = new Dictionary<string, string>();
            string configPath = appBasePath + "Launcher.ini";
            if (File.Exists(configPath))
            {
                Console.WriteLine("Config: Loading from Launcher.ini:");
                string[] configRows = File.ReadAllText(configPath).Trim().Replace("\r\n", "\n").Split('\n');
                foreach (string configRow in configRows)
                {
                    string[] configKeyValue = configRow.Split('=');
                    if (configKeyValue.Length < 2)
                    {
                        continue;
                    }
                    string configKey = configKeyValue[0].Trim().ToUpper();
                    string configValue = configKeyValue[1];
                    config.Add(configKey, configValue);
                    Console.WriteLine(string.Format("Config: Loading key '{0}' with value '{1}'", configKey, configValue));
                }
            }
            return config;
        }

        static void LaunchGunbound(string binaryPath, string credentialsEncrypted, bool createSuspended, string dllToInject = "")
        {
            int pid = NativeAPI.CreateProcessWrapper(binaryPath, credentialsEncrypted, createSuspended);
            if (dllToInject.Length != 0)
            {
                NativeAPI.InjectDLL(pid, dllToInject);
                Console.WriteLine("Injected DLL: " + dllToInject);
            }
        }

        static RegistryKey RestoreBaseRegistry()
        {
            RegistryKey gbKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
            gbKey.CreateSubKey(hiveLocation);
            // writing to the RegistryKey from CreateSubKey fails, so the key is reopened below with write access
            gbKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
            gbKey = gbKey.OpenSubKey(hiveLocation, true);

            gbKey.SetValue("AppID1", 1, RegistryValueKind.DWord);
            gbKey.SetValue("AppID2", 2, RegistryValueKind.DWord);
            gbKey.SetValue("AppID3", 3, RegistryValueKind.DWord);
            gbKey.SetValue("AutoRefresh", 1, RegistryValueKind.DWord);
            gbKey.SetValue("Background", new byte[] { 0x01 }, RegistryValueKind.Binary);
            gbKey.SetValue("BuddyIP", "127.0.0.1", RegistryValueKind.String);
            gbKey.SetValue("ChannelName", new byte[] { 0x00 }, RegistryValueKind.Binary);
            gbKey.SetValue("Effect3D", new byte[] { 0x02 }, RegistryValueKind.Binary);
            gbKey.SetValue("EffectVolume", 95, RegistryValueKind.DWord);
            gbKey.SetValue("GameName", new byte[] { 0x00 }, RegistryValueKind.Binary);
            gbKey.SetValue("IP", "127.0.0.1", RegistryValueKind.String);
            gbKey.SetValue("Language", 0, RegistryValueKind.DWord);
            gbKey.SetValue("LastID", new byte[] { 0x00 }, RegistryValueKind.Binary);
            gbKey.SetValue("LastServer", -1, RegistryValueKind.DWord);
            gbKey.SetValue("Location", @"C:\Program Files (x86)\softnyx\GunBound\", RegistryValueKind.String);
            gbKey.SetValue("MidiMode", new byte[] { 0x01 }, RegistryValueKind.Binary);
            gbKey.SetValue("MouseSpeed", 50, RegistryValueKind.DWord);
            gbKey.SetValue("MusicVolume", 95, RegistryValueKind.DWord);
            gbKey.SetValue("port", 8372, RegistryValueKind.DWord);
            gbKey.SetValue("Screen", @"C:\Program Files (x86)\softnyx\GunBound\Screen\", RegistryValueKind.String); // GKS
            gbKey.SetValue("ShootingMode", new byte[] { 0x00 }, RegistryValueKind.Binary);
            gbKey.SetValue("Url_Fetch", "http://fetch.gunbound.co.kr/fetch/fetch.dll", RegistryValueKind.String);
            gbKey.SetValue("Url_ForgotPwd", "http://fetch.gunbound.co.kr/fetch/pwdlost/", RegistryValueKind.String);
            gbKey.SetValue("Url_Notice", "http://www.gunbound.co.kr/fetch_note/note.htm", RegistryValueKind.String);
            gbKey.SetValue("Url_Signup", "http://fetch.gunbound.co.kr/fetch/signup/", RegistryValueKind.String);
            gbKey.SetValue("Version", 313, RegistryValueKind.DWord);

            return gbKey;
        }

        public static void LaunchGame(string credentialsUsername, string credentialsPassword)
        {
            string credentialsEncrypted = GunBoundLoginParameters(credentialsUsername, credentialsPassword);
            string appBasePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\";

            RegistryKey gbKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
            gbKey = gbKey.OpenSubKey(@"Software\Softnyx\GunBound", true);
            if (gbKey == null)
            {
                Console.WriteLine("Registry: Base registry not created, restoring..");
                gbKey = RestoreBaseRegistry();
            }

            // set GunBound's base path to our directory
            Console.WriteLine("Registry: Writing Location and Screen");
            gbKey.SetValue("Location", appBasePath, RegistryValueKind.String);
            gbKey.SetValue("Screen", appBasePath + "Screen\\", RegistryValueKind.String);

            /*
            // potentially useful legacy bits
            gbKey.SetValue("Version", int.Parse(config["VERSION"]), RegistryValueKind.DWord);
            gbKey.SetValue("IP", config["SERVER"], RegistryValueKind.String);
            gbKey.SetValue("BuddyIP", config["SERVER"], RegistryValueKind.String);
            */

            Console.WriteLine("Attempting to start GunBound.gme with credentials: " + credentialsEncrypted);
            string binaryPath = appBasePath + "GunBound.gme";
            if (File.Exists(binaryPath))
            {
                string dllToInject = "";
                /*
                // more legacy bits
                if (config.ContainsKey("INJECT_DLL"))
                {
                    dllToInject = appBasePath + config["INJECT_DLL"];
                    if (!File.Exists(dllToInject))
                    {
                        dllToInject = "";
                        Console.WriteLine("INJECT_DLL was requested, but the requested file does not exist");
                    }
                }
                */
                LaunchGunbound(binaryPath, credentialsEncrypted, false, dllToInject);
            }
            else
            {
                Console.WriteLine("Could not find the client executable. Please run me in the same folder as the GunBound.gme file");
            }

            Environment.Exit(0);
        }


    }
}
