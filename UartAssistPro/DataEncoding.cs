using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace UartAssistPro
{
    /// <summary>
    /// This file is the class to deal with the hexString
    /// Contants kinds of functions
    /// </summary>
    public class DataEncoding
    {
        public DataEncoding()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        /// <summary>
        /// Detection the string is hexstring
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        public static bool IsHexString(string hexString)
        {
            //十六进制发送时，发送框数据进行十六进制数据正则校验
            if (Regex.IsMatch(hexString, "^[0-9A-Fa-f]+$") && hexString.Length % 2 == 0)
            {
                //校验成功
                return true;
            }
            //校验失败
            return false;
         }

        /// <summary>
        /// 将ascii字符串转换成Hex显示
        /// </summary>
        /// <param name="asciiString"></param>
        /// <returns></returns>
        public static string ConvertStringToHexString(string asciiString)
        {
            string hexString = "";
            asciiString = asciiString.Replace("\n", "\r\n");                //解决richTextBox获取不到"\r\n"换行符
            byte[] arrByte = System.Text.Encoding.GetEncoding("GB2312").GetBytes(asciiString);
            foreach (char c in arrByte)
            {
                int tmp = c;
                hexString += String.Format("{0:x2}", (uint)System.Convert.ToUInt32(tmp.ToString())).ToUpper() + " ";
            }
            return hexString;
        }

        /// <summary>
        /// 将Hex转换成ascii字符串显示
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        public static string ConvertHexStringToString(string hexString)
        {
            string result = string.Empty;
            hexString = hexString.Replace(" ", "");
            //解决十六进制出现单数据问题，以补0
            if (hexString.Length % 2 == 1)
            {
                hexString = hexString.Insert(hexString.Length - 1, "0");
            }
            byte[] arrByte = new byte[hexString.Length / 2];
            int index = 0;
            for (int i = 0; i < hexString.Length; i += 2)
            {
                //Convert.ToByte(string,16)把十六进制string转化成byte 
                arrByte[index++] = Convert.ToByte(hexString.Substring(i, 2), 16);
            }
            result = System.Text.Encoding.GetEncoding("gb2312").GetString(arrByte);
             return result.Replace("\0","\\0");
        }

        /// <summary>
        /// 获取hexString中Byte数量
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        public static int GetByteCount(string hexString)
        {
            if (IsHexString(hexString) && (hexString.Length % 2== 0))
            {
                // 2 characters per byte
                return hexString.Length / 2; 
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        private static byte HexToByte(string hex)
        {
            if (hex.Length > 2 || hex.Length <= 0)
                throw new ArgumentException("hex must be 1 or 2 characters in length");
            byte newByte = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);
            return newByte;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        public static byte[] HexStringToBytes(string hexString)
        {
            //string newString = "";

            if(IsHexString(hexString)==false)
            { return null; }
            
            int byteLength = hexString.Length / 2;
            byte[] bytes = new byte[byteLength];
            string hex;
            int j = 0;
            for (int i = 0; i < bytes.Length; i++)
            {
                hex = new String(new Char[] { hexString[j], hexString[j + 1] });
                bytes[i] = HexToByte(hex);
                j = j + 2;
            }
            return bytes;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string BytesToHexString(byte[] bytes)
        {
            string hexString = "";
            for (int i = 0; i < bytes.Length; i++)
            {
                hexString += bytes[i].ToString("X2");
            }
            return hexString;
        }

        public static byte[] ConcatArrays(byte[] first, byte[] second)
        {
            byte[] ret = new byte[first.Length + second.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
            return ret;
        }

        public static byte[] ConcatArrays(byte[] first, byte[] second, byte[] third)
        {
            byte[] ret = new byte[first.Length + second.Length + third.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
            Buffer.BlockCopy(third, 0, ret, first.Length + second.Length,
                             third.Length);
            return ret;
        }

        public static byte[] ConcatArrays(params byte[][] arrays)
        {
            byte[] ret = new byte[arrays.Sum(x => x.Length)];
            int offset = 0;
            foreach (byte[] data in arrays)
            {
                Buffer.BlockCopy(data, 0, ret, offset, data.Length);
                offset += data.Length;
            }
            return ret;
        }

        public static int search(byte[] haystack, byte[] needle)
        {
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (match(haystack, needle, i))
                {
                    return i;
                }
            }
            return -1;
        }

        public static bool match(byte[] haystack, byte[] needle, int start)
        {
            if (needle.Length + start > haystack.Length)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < needle.Length; i++)
                {
                    if (needle[i] != haystack[i + start])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
