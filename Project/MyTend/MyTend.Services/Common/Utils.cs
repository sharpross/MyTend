using System;

namespace MyTend.Services.Common
{
    public static class Utils
    {
        public static string GenerateString(int count)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[count];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            return finalString;
        }

        public static string GenerateNumber(int count)
        {
            var chars = "0123456789";
            var stringChars = new char[count];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            return finalString;
        }

        public static int GenerateInt()
        {
            Random r = new Random();

            return r.Next(1, int.MaxValue - 1);
        }
    }
}
