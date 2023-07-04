using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gammis
{
    public class RefCodeGenerator
    {
        private static readonly Random random = new Random();
        private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        public string GenerateRefCode(int length)
        {
            StringBuilder refCodeBuilder = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                refCodeBuilder.Append(chars[random.Next(chars.Length)]);
            }

            return refCodeBuilder.ToString();
        }
    }

    public class Program
    {
        public static void Main()
        {
            int refCodeLength = 10; // Length of the ref_code

            RefCodeGenerator refCodeGenerator = new RefCodeGenerator();
            string refCode = refCodeGenerator.GenerateRefCode(refCodeLength);

            Console.WriteLine("Generated ref_code: " + refCode);
        }
    }
}

