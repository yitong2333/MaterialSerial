using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


/// <summary>
/// whble 
/// 2019年8月11日
/// </summary>

namespace UartAssistPro
{
    /// <summary>
    /// Transform data to different type. it's useful.
    /// </summary>
    public static class Transform
    {
        #region Common 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static byte[] ConcatArrays(byte[] first, byte[] second)
        {
            byte[] ret = new byte[first.Length + second.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
            return ret;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <returns></returns>
        public static byte[] ConcatArrays(byte[] first, byte[] second, byte[] third)
        {
            byte[] ret = new byte[first.Length + second.Length + third.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
            Buffer.BlockCopy(third, 0, ret, first.Length + second.Length,
                             third.Length);
            return ret;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arrays"></param>
        /// <returns></returns>
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arrays"></param>
        /// <returns></returns>
        public static byte[] ConcatBytes(params byte[] arrays)
        {
            byte[] ret = new byte[arrays.Length];
            for (int i = 0; i < ret.Length; i++)
            {
                ret[i] = arrays[i];
            }
            return ret;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="haystack"></param>
        /// <param name="needle"></param>
        /// <returns></returns>
        public static int Search(byte[] haystack, byte[] needle)
        {
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (Match(haystack, needle, i))
                {
                    return i;
                }
            }
            return -1;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="haystack"></param>
        /// <param name="needle"></param>
        /// <param name="start"></param>
        /// <returns></returns>
        public static bool Match(byte[] haystack, byte[] needle, int start)
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        public static bool IsHexString(string hexString)
        {
            if (Regex.IsMatch(hexString.Trim(), "^[0-9A-Fa-f]+$"))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hexByte"></param>
        /// <returns></returns>
        private static byte HexToByte(string hexByte)
        {
            if (hexByte.Length > 2 || hexByte.Length <= 0)
                throw new ArgumentException("hex must be 1 or 2 characters in length");
            byte newByte = byte.Parse(hexByte, System.Globalization.NumberStyles.HexNumber);
           
            return newByte;
        }
        #endregion

        #region Get Bool or Bools from buffer
        /// <summary>
        /// 获取byte数组中0x00 为false ，0x01 为true
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static bool ToBool(byte[] buffer, int index)
        {
            return ((buffer[index] & 0x01) == 0x01);
        }

        /// <summary>
        /// 获取byte字节中指定索引的bool值，1为true 0为false
        /// </summary>
        /// <param name="buffer">输入数据</param>
        /// <param name="index">从低位开始的索引（1-8）</param>
        /// <returns></returns>
        public static bool ToBool(byte buffer,int index)
        {
            return (buffer & (0x01 << (index-1))) == (0x01 << (index - 1)) ? true : false;
        }

        /// <summary>
        /// 获取byte字节bool值1为true 0为false
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static bool[] ToBools(byte buffer)
        {
            bool[] boolArray = new bool[8];
            for(int i=0;i<8;i++)
            {
                boolArray[i] = (buffer & (0x01 << i)) == (0x01 << i) ? true : false;
            }
            return boolArray;
        }

        /// <summary>
        /// 将字节数组中指定索引和指定字节长度数据转换成Bool[]
        /// </summary>
        /// <param name="buffer">输入数据</param>
        /// <param name="index">索引</param>
        /// <param name="length">长度</param>
        /// <returns></returns>
        public static bool[] ToBools(byte[] buffer, int index, int length)
        {
            byte[] tmp = new byte[length];
            Array.Copy(buffer, index, tmp, 0, length);
            return ToBools(tmp, length * 8);
        }

        /// <summary>
        /// 将字节数组转成bool数组
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static bool[] ToBools(byte[] buffer)
        {
            if (buffer == null) return null;

            return ToBools(buffer, buffer.Length * 8);
        }

        /// <summary>
        /// 将字节数组转成bool数组
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="length">要获取的位数</param>
        /// <returns></returns>
        public static bool[] ToBools(byte[] buffer, int length)
        {
            if (buffer == null) return null;

            if (length > buffer.Length * 8) length = buffer.Length * 8;
            bool[] blist = new bool[length];

            for (int i = 0; i < length; i++)
            {
                int index = i / 8;
                int offect = i % 8;

                byte temp = 0;
                switch (offect)
                {
                    case 0: temp = 0x01; break;
                    case 1: temp = 0x02; break;
                    case 2: temp = 0x04; break;
                    case 3: temp = 0x08; break;
                    case 4: temp = 0x10; break;
                    case 5: temp = 0x20; break;
                    case 6: temp = 0x40; break;
                    case 7: temp = 0x80; break;
                    default: break;
                }

                if ((buffer[index] & temp) == temp)
                {
                    blist[i] = true;
                }
            }
            return blist;
        }

        #endregion

        #region Get Byte or Bytes from buffer
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static byte ToByte(byte[] buffer, int index)
        {
            return buffer[index];
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static byte[] ToBytes(bool buffer)
        {
            return ToBytes(new bool[] { buffer });
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static byte[] ToBytes(bool[] buffer)
        {
            if (buffer == null) return null;

            int length = buffer.Length % 8 == 0 ? buffer.Length / 8 : buffer.Length / 8 + 1;
            byte[] bytelist = new byte[length];

            for (int i = 0; i < buffer.Length; i++)
            {
                int index = i / 8;
                int offect = i % 8;

                byte temp = 0;
                switch (offect)
                {
                    case 0: temp = 0x01; break;
                    case 1: temp = 0x02; break;
                    case 2: temp = 0x04; break;
                    case 3: temp = 0x08; break;
                    case 4: temp = 0x10; break;
                    case 5: temp = 0x20; break;
                    case 6: temp = 0x40; break;
                    case 7: temp = 0x80; break;
                    default: break;
                }
                if (buffer[i]) bytelist[index] += temp;
            }
            return bytelist;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static byte[] ToBytes(byte buffer)
        {
            return new byte[] { buffer };
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="index"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static byte[] ToBytes(byte[] buffer, int index, int length)
        {
            byte[] tmp = new byte[length];
            Array.Copy(buffer, index, tmp, 0, length);
            return tmp;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static byte[] ToBytes(short buffer)
        {
            return ToBytes(new short[] { buffer });
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static byte[] ToBytes(short[] buffer)
        {
            if (buffer == null) return null;
            byte[] blist = new byte[buffer.Length * 2];
            for (int i = 0; i < buffer.Length; i++)
            {
                BitConverter.GetBytes(buffer[i]).CopyTo(blist, 2 * i);
            }
            return blist;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static byte[] ToBytes(ushort buffer)
        {
            return ToBytes(new ushort[] { buffer });
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static byte[] ToBytes(ushort[] buffer)
        {
            if (buffer == null) return null;

            byte[] blist = new byte[buffer.Length * 2];
            for (int i = 0; i < buffer.Length; i++)
            {
                BitConverter.GetBytes(buffer[i]).CopyTo(blist, 2 * i);
            }

            return blist;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static byte[] ToBytes(int buffer)
        {
            return ToBytes(new int[] { buffer });
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static byte[] ToBytes(int[] buffer)
        {
            if (buffer == null) return null;
            byte[] blist = new byte[buffer.Length * 4];
            for (int i = 0; i < buffer.Length; i++)
            {
                BitConverter.GetBytes(buffer[i]).CopyTo(blist, 4 * i);
            }
            return blist;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static byte[] ToBytes(uint buffer)
        {
            return ToBytes(new uint[] { buffer });
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static byte[] ToBytes(uint[] buffer)
        {
            if (buffer == null) return null;
            byte[] blist = new byte[buffer.Length * 4];
            for (int i = 0; i < buffer.Length; i++)
            {
                BitConverter.GetBytes(buffer[i]).CopyTo(blist, 4 * i);
            }
            return blist;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static byte[] ToBytes(float buffer)
        {
            return ToBytes(new float[] { buffer });
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static byte[] ToBytes(float[] buffer)
        {
            if (buffer == null) return null;
            byte[] blist = new byte[buffer.Length * 4];
            for (int i = 0; i < buffer.Length; i++)
            {
                BitConverter.GetBytes(buffer[i]).CopyTo(blist, 4 * i);
            }
            return blist;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static byte[] ToBytes(long buffer)
        {
            return ToBytes(new long[] { buffer });
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static byte[] ToBytes(long[] buffer)
        {
            if (buffer == null) return null;
            byte[] blist = new byte[buffer.Length * 8];
            for (int i = 0; i < buffer.Length; i++)
            {
                BitConverter.GetBytes(buffer[i]).CopyTo(blist, 8 * i);
            }
            return blist;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static byte[] ToBytes(ulong buffer)
        {
            return ToBytes(new ulong[] { buffer });
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static byte[] ToBytes(ulong[] buffer)
        {
            if (buffer == null) return null;
            byte[] blist = new byte[buffer.Length * 8];
            for (int i = 0; i < buffer.Length; i++)
            {
                BitConverter.GetBytes(buffer[i]).CopyTo(blist, 8 * i);
            }
            return blist;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static byte[] ToBytes(double buffer)
        {
            return ToBytes(new double[] { buffer });
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static byte[] ToBytes(double[] buffer)
        {
            if (buffer == null) return null;
            byte[] blist = new byte[buffer.Length * 8];
            for (int i = 0; i < buffer.Length; i++)
            {
                BitConverter.GetBytes(buffer[i]).CopyTo(blist, 8 * i);
            }
            return blist;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        public static byte[] ToBytes(string hexString)
        {
            if (hexString == null)
                throw new ArgumentNullException("hex");

            if (hexString.Length % 2 != 0)
                throw new FormatException("Hex string must have even number of characters.");

            byte[] bytes = new byte[hexString.Trim().Length / 2];

            for (int i = 0; i < bytes.Length; i++)
                bytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);

            return bytes;
        }


        #endregion

        #region Get Short,UShort,Shorts,UShort from buffer
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static short ToInt16(byte[] buffer, int index)
        {
            return BitConverter.ToInt16(buffer, index);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="index"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static short[] ToInt16s(byte[] buffer, int index, int length)
        {
            short[] tmp = new short[length];
            for (int i = 0; i < length; i++)
            {
                tmp[i] = ToInt16(buffer, index + 2 * i);
            }
            return tmp;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static ushort ToUInt16(byte[] buffer, int index)
        {
            return BitConverter.ToUInt16(buffer, index);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="index"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static ushort[] ToUInt16s(byte[] buffer, int index, int length)
        {
            ushort[] tmp = new ushort[length];
            for (int i = 0; i < length; i++)
            {
                tmp[i] = ToUInt16(buffer, index + 2 * i);
            }
            return tmp;
        }

        #endregion

        #region Get Int,UInt,Ints,UInts from buffer
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static int ToInt32(byte[] buffer, int index)
        {
            return BitConverter.ToInt32(buffer, index);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="index"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static int[] ToInt32s(byte[] buffer, int index, int length)
        {
            int[] tmp = new int[length];
            for (int i = 0; i < length; i++)
            {
                tmp[i] = ToInt32(buffer, index + 2 * i);
            }
            return tmp;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static uint ToUInt32(byte[] buffer, int index)
        {
            return BitConverter.ToUInt32(buffer, index);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="index"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static uint[] ToUInt32s(byte[] buffer, int index, int length)
        {
            uint[] tmp = new uint[length];
            for (int i = 0; i < length; i++)
            {
                tmp[i] = ToUInt32(buffer, index + 2 * i);
            }
            return tmp;
        }
        #endregion

        #region Get HexString from buffer
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static string ToHexString(byte[] buffer)
        {
            return ToHexString( buffer,  0, "");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="split"></param>
        /// <returns></returns>
        public static string ToHexString(byte[] buffer,string split)
        {
            return ToHexString(buffer, 0, split);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="index"></param>
        /// <param name="split"></param>
        /// <returns></returns>
        public static string ToHexString(byte[] buffer, int index, string split)
        {
            var str = new StringBuilder();
            int start = Environment.TickCount;
            Console.WriteLine("wait...");
            for (int i = 0; i < buffer.Length; i++)
            {
                str.Append(String.Format("{0:X2}", buffer[i]));
                str.Append(split);
            }
            string s = str.ToString();

            Console.WriteLine(Math.Abs(Environment.TickCount - start));
            return s;


            //Console.WriteLine("wait...");
            //if (buffer == null) return null;
            //string hexString = "";
            //for (int i = 0; i < buffer.Length; i++)
            //{
            //    hexString += buffer[i].ToString("X2") + split;
            //}
            //Console.WriteLine(Math.Abs(Environment.TickCount - start));
            //return hexString;

        }
        #endregion

        #region Get Single,Singles from buffer

        /// <summary>
        /// Default change little-endian to single
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static float ToSingle(byte[] buffer)
        {
            if(buffer.Length<sizeof(float))
                throw new FormatException(string.Format("buffer does not contain enough bytes. Minimum lenth={0}", sizeof(float)));

            return ToSingle(buffer, 0);
        }

        /// <summary>
        /// Change little-endian or big-endian to single 
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="bol"></param>
        /// <returns></returns>
        public static float ToSingle(byte[] buffer,BigOrLittle bol)
        {
            if (buffer.Length < sizeof(float))
                throw new FormatException(string.Format("buffer does not contain enough bytes. Minimum lenth={0}", sizeof(float)));

            if (bol == BigOrLittle.BigEndian) ReverseBytes(buffer);
            return ToSingle( buffer,  0);
        }

        /// <summary>
        /// Default change little-endian to single
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="index">startindex</param>
        /// <returns></returns>
        public static float ToSingle(byte[] buffer,int index)
        {
            if (buffer.Length < sizeof(float))
                throw new FormatException(string.Format("buffer does not contain enough bytes. Minimum lenth={0}", sizeof(float)));

            return BitConverter.ToSingle(buffer, index);
        }


        #endregion

        #region Get Double,Doubles from buffer

        /// <summary>
        /// Default change little-endian to single
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static double ToDouble(byte[] buffer)
        {
            if (buffer.Length < sizeof(double))
                throw new FormatException(string.Format("buffer does not contain enough bytes. Minimum lenth={0}", sizeof(double)));

            return ToDouble(buffer, 0);
        }

        /// <summary>
        /// Change little-endian or big-endian to single 
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="bol"></param>
        /// <returns></returns>
        public static double ToDouble(byte[] buffer, BigOrLittle bol)
        {
            if (buffer.Length < sizeof(double))
                throw new FormatException(string.Format("buffer does not contain enough bytes. Minimum lenth={0}", sizeof(double)));

            if (bol == BigOrLittle.BigEndian) ReverseBytes(buffer);
            return ToDouble(buffer, 0);
        }

        /// <summary>
        /// Default change little-endian to single
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="index">startindex</param>
        /// <returns></returns>
        public static double ToDouble(byte[] buffer, int index)
        {
            if (buffer.Length < sizeof(double))
                throw new FormatException(string.Format("buffer does not contain enough bytes. Minimum lenth={0}", sizeof(double)));

            return BitConverter.ToDouble(buffer, index);
        }


        #endregion

        #region Reverse Bytes

        /// <summary>
        /// Reverse bytes array
        /// </summary>
        /// <param name="bytes"></param>
        public static void ReverseBytes(byte[] bytes)
        {
            byte tmp;
            int len = bytes.Length;

            for (int i = 0; i < len / 2; i++)
            {
                tmp = bytes[len - 1 - i];
                bytes[len - 1 - i] = bytes[i];
                bytes[i] = tmp;
            }
        }

        /// <summary>
        /// Reverse bytes array
        /// </summary>
        /// <param name="bytes">buffer</param>
        /// <param name="start">startindex</param>
        /// <param name="len">lenth</param>
        public static void ReverseBytes(byte[] bytes, int start, int len)
        {
            int end = start + len - 1;
            byte tmp;
            int i = 0;
            for (int index = start; index < start + len / 2; index++, i++)
            {
                tmp = bytes[end - i];
                bytes[end - i] = bytes[index];
                bytes[index] = tmp;
            }
        }

        /// <summary>
        /// Reverse UInt16
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static UInt16 ReverseBytes(UInt16 value)
        {
            return (UInt16)((value & 0xFFU) << 8 | (value & 0xFF00U) >> 8);
        }

        /// <summary>
        /// Reverse UInt32
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static UInt32 ReverseBytes(UInt32 value)
        {
            return (value & 0x000000FFU) << 24 | (value & 0x0000FF00U) << 8 |
                   (value & 0x00FF0000U) >> 8 | (value & 0xFF000000U) >> 24;
        }

        /// <summary>
        /// Reverse UInt64
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static UInt64 ReverseBytes(UInt64 value)
        {
            return (value & 0x00000000000000FFUL) << 56 | (value & 0x000000000000FF00UL) << 40 |
                   (value & 0x0000000000FF0000UL) << 24 | (value & 0x00000000FF000000UL) << 8 |
                   (value & 0x000000FF00000000UL) >> 8 | (value & 0x0000FF0000000000UL) >> 24 |
                   (value & 0x00FF000000000000UL) >> 40 | (value & 0xFF00000000000000UL) >> 56;
        }

        #endregion


        public static bool[] ToBools(string buffer, char split)
        {
            List<bool> b = new List<bool>();
            foreach (string item in buffer.Split(split))
            {
                if (item != "true" && item != "false")
                    return null;
                b.Add(Convert.ToBoolean(item));
            }
            return b.ToArray();
        }


        public static ushort[] ToUInt16s(string buffer, char split)
        {
            List<ushort> b = new List<ushort>();
            foreach (string item in buffer.Split(split))
            {
                if (Convert.ToUInt16(item) < 0 || Convert.ToUInt16(item) > 65535)
                    return null;
                b.Add(Convert.ToUInt16(item));
            }
            return b.ToArray();
        }
    }
}
