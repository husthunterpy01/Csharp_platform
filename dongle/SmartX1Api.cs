using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace SmartX1Demo
{
    public class SmartX1_X86
    {


        // Find
        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1App.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1Find(string appID, int[] keyHandles, int[] keyNumber);

        //open
        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1App.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1Open(int keyHandle, int uPin1, int uPin2, int uPin3, int uPin4);
        //close

        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1App.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1Close(int keyHandle);

        //checkExist

        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1App.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1CheckExist(int keyHandle);

        //getUid
        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1App.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1GetUid(int keyHandle, StringBuilder uid);

        //ReadStorage
        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1App.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1ReadStorage(int keyHandle, int startAddr, int length, byte[] pBuffer);

        //WriteStorage
        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1App.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1WriteStorage(int keyHandle, int startAddr, int length, byte[] pBuffer);

        //PageLogin
        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1App.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1PageLogin(int keyHandle, int pageNo, byte[] password, int length);

        //PageLogout
        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1App.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1PageLogout(int keyHandle, int pageNo);

        //ReadPage
        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1App.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1ReadPage(int keyHandle, int pageNo, int startAddr, ref int length, byte[] pBuffer);

        //WritePage
        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1App.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1WritePage(int keyHandle, int pageNo, int startAddr, int length, byte[] pBuffer);

        //ReadMem
        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1App.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1ReadMem(int keyHandle, int start, int length, byte[] pBuffer);

        //WriteMem
        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1App.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1WriteMem(int keyHandle, int start, int length, byte[] pBuffer);

        //encrypt
        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1App.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1TriDesEncrypt(int keyHandle, int buffSize, byte[] pBuffer);

        //desDecrypt
        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1App.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1TriDesDecrypt(int keyHandle, int buffSize, byte[] pBuffer);

        //led
        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1App.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1Led(int keyHandle, int state);


        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1App.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1PageGetProperty(int keyHandle, int pageNo, int propId, int[] propValue);

        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1App.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1GetSoftVersion(int keyHandle, int[] version);

        public static string TridesEncrypt(string data, string key, Encoding encoding)
        {
            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            des.Key = Encoding.Default.GetBytes(key);
            des.Mode = CipherMode.ECB;

            des.Padding = PaddingMode.PKCS7;

            ICryptoTransform DesEncrypt = des.CreateEncryptor();
            byte[] dataBytes = encoding.GetBytes(data);
            byte[] outPut = DesEncrypt.TransformFinalBlock(dataBytes, 0, dataBytes.Length);
            return Convert.ToBase64String(outPut);

        }

        public static string TridesDecEncrypt(byte[] data, string key, Encoding encoding)
        {
            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            des.Key = Encoding.Default.GetBytes(key);
            des.Padding = PaddingMode.PKCS7;
            des.Mode = CipherMode.ECB;
            ICryptoTransform DesDecEncrypt = des.CreateDecryptor();
            byte[] outValue = DesDecEncrypt.TransformFinalBlock(data, 0, data.Length);
            return encoding.GetString(outValue);
        }
    }


    class SmartX1_X64
    {
        // Find
        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1AppX64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1Find(string appID, int[] keyHandles, int[] keyNumber);

        //open
        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1AppX64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1Open(int keyHandle, int uPin1, int uPin2, int uPin3, int uPin4);
        //close

        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1AppX64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1Close(int keyHandle);

        //checkExist

        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1AppX64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1CheckExist(int keyHandle);

        //getUid
        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1AppX64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1GetUid(int keyHandle, StringBuilder uid);

        //ReadStorage
        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1AppX64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1ReadStorage(int keyHandle, int startAddr, int length, byte[] pBuffer);

        //WriteStorage
        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1AppX64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1WriteStorage(int keyHandle, int startAddr, int length, byte[] pBuffer);

        //PageLogin
        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1AppX64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1PageLogin(int keyHandle, int pageNo, byte[] password, int length);

        //PageLogout
        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1AppX64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1PageLogout(int keyHandle, int pageNo);

        //ReadPage
        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1AppX64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1ReadPage(int keyHandle, int pageNo, int startAddr, ref int length, byte[] pBuffer);

        //WritePage
        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1AppX64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1WritePage(int keyHandle, int pageNo, int startAddr, int length, byte[] pBuffer);

        //ReadMem
        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1AppX64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1ReadMem(int keyHandle, int start, int length, byte[] pBuffer);

        //WriteMem
        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1AppX64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1WriteMem(int keyHandle, int start, int length, byte[] pBuffer);

        //encrypt
        [DllImport( @"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1AppX64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1TriDesEncrypt(int keyHandle, int buffSize, byte[] pBuffer);

        //desDecrypt
        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1AppX64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1TriDesDecrypt(int keyHandle, int buffSize, byte[] pBuffer);

        //led
        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1AppX64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1Led(int keyHandle, int state);


        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1AppX64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1PageGetProperty(int keyHandle, int pageNo, int propId, int[] propValue);

        [DllImport(@"C:\\Users\\DELL\\source\\repos\\dongle_Checking\\dongle_Checking\\bin\\Debug\\SmartX1AppX64.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int SmartX1GetSoftVersion(int keyHandle, int[] version);

        public static string TridesEncrypt(string data, string key, Encoding encoding)
        {
            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            des.Key = Encoding.Default.GetBytes(key);
            des.Mode = CipherMode.ECB;

            des.Padding = PaddingMode.PKCS7;

            ICryptoTransform DesEncrypt = des.CreateEncryptor();
            byte[] dataBytes = encoding.GetBytes(data);
            byte[] outPut = DesEncrypt.TransformFinalBlock(dataBytes, 0, dataBytes.Length);
            return Convert.ToBase64String(outPut);

        }

        public static string TridesDecEncrypt(byte[] data, string key, Encoding encoding)
        {
            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            des.Key = Encoding.Default.GetBytes(key);
            des.Padding = PaddingMode.PKCS7;
            des.Mode = CipherMode.ECB;
            ICryptoTransform DesDecEncrypt = des.CreateDecryptor();
            byte[] outValue = DesDecEncrypt.TransformFinalBlock(data, 0, data.Length);
            return encoding.GetString(outValue);
        }
    }
}
