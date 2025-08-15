using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientTest
{
    public static class Utils
    {
        private static readonly char[] Base64EncodingTable =
            "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/".ToCharArray();
        public static string EncodeBase64(string input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            byte[] src = System.Text.Encoding.UTF8.GetBytes(input);
            int len = src.Length;

            int olen = 4 * ((len + 2) / 3);
            char[] outChars = new char[olen];
            int inIndex = 0, outIndex = 0;

            while (len - inIndex >= 3)
            {
                byte b0 = src[inIndex];
                byte b1 = src[inIndex + 1];
                byte b2 = src[inIndex + 2];

                outChars[outIndex++] = Base64EncodingTable[b0 >> 2];
                outChars[outIndex++] = Base64EncodingTable[((b0 & 0x03) << 4) | (b1 >> 4)];
                outChars[outIndex++] = Base64EncodingTable[((b1 & 0x0F) << 2) | (b2 >> 6)];
                outChars[outIndex++] = Base64EncodingTable[b2 & 0x3F];

                inIndex += 3;
            }

            if (len - inIndex == 1)
            {
                byte b0 = src[inIndex];

                outChars[outIndex++] = Base64EncodingTable[b0 >> 2];
                outChars[outIndex++] = Base64EncodingTable[(b0 & 0x03) << 4];
                outChars[outIndex++] = '=';
                outChars[outIndex++] = '=';
            }
            else if (len - inIndex == 2)
            {
                byte b0 = src[inIndex];
                byte b1 = src[inIndex + 1];

                outChars[outIndex++] = Base64EncodingTable[b0 >> 2];
                outChars[outIndex++] = Base64EncodingTable[((b0 & 0x03) << 4) | (b1 >> 4)];
                outChars[outIndex++] = Base64EncodingTable[(b1 & 0x0F) << 2];
                outChars[outIndex++] = '=';
            }

            return new string(outChars);
        }

        public static string FormatMountpointRequest(string _authorization, string? _mountpointName = null)
        {
            string authorization = EncodeBase64(_authorization);
            if (_mountpointName == "source" || _mountpointName == null)
            {
                return "GET / HTTP/1.0\r\n"
                + "User-Agent: NTRIP Client/1.0\r\n"
                + "Accept: */*\r\n"
                + "Connection: close\r\n"
                + "Authorization: Basic " + authorization + "\r\n"
                + "Ntrip-Version: Ntrip/2.0\r\n"
                + "\r\n";
            }
            else
            {
                return "GET /" + _mountpointName + " HTTP/1.0\r\n"
                + "User-Agent: NTRIP Client/1.0\r\n"
                + "Accept: */*\r\n"
                + "Connection: close\r\n"
                + "Authorization: Basic " + authorization + "\r\n"
                + "Ntrip-Version: Ntrip/2.0\r\n"
                + "\r\n";
            }
        }
    }
}
