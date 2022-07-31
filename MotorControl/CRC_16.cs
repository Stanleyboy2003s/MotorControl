using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorControl
{
    public enum Cmd 
    {
        LoadMode = 0,
        LoadStep,
        LoadVelocity,
        LoadAcceleration,
        LoadDeceleration,
        ReadNowPosition,
        ReadStatus,
        Home,
        ResetAlarm,
        RVS,
        Stop,
        FWD,
        Move,
        Emergency
    }
    public class CRC_16
    {    
        public static byte[] crc16(byte[] data)
        {
            if (data == null)
            {
                throw new Exception("Error!! Due to input data are null");
            }else if (data.Length == 0)
            {
                throw new Exception("Error!! Due to input data are empty");
            }
            byte[] temdata = new byte[data.Length + 2];
            int xda, xdapoly;
            byte i, j, xdabit;
            xda = 0xFFFF;
            xdapoly = 0xA001;
            for (i = 0; i < data.Length; i++)
            {
                xda ^= data[i];
                for (j = 0; j < 8; j++)
                {
                    xdabit = (byte)(xda & 0x01);
                    xda >>= 1;
                    if (xdabit == 1)
                        xda ^= xdapoly;
                }
                temdata[i] = data[i];
            }
            temdata[data.Length] = (byte)(xda & 0xFF);
            temdata[data.Length + 1] = (byte)(xda >> 8);
            return temdata;
        }
        public static byte[] ConvertHexStringToByteArray(string hexString)
        {
            if (hexString.Length % 2 != 0)
            {
                throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, "The binary key cannot have an odd number of digits: {0}", hexString));
            }
            byte[] data = new byte[hexString.Length / 2];
            for (int index = 0; index < data.Length; index++)
            {
                string byteValue = hexString.Substring(index * 2, 2);
                data[index] = byte.Parse(byteValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            }
            return data;
        }
        public static string NegativeToHexString(int Number)
        {
            Number *= -1;
            short iComplement = (short)(~Number + 1);
            string strResult = Convert.ToString(iComplement, 16).ToUpper();
            if (Number > 0)
                return strResult.PadLeft(8, 'F');
            else
                return strResult.PadLeft(8, '0');
        }

    }
}
