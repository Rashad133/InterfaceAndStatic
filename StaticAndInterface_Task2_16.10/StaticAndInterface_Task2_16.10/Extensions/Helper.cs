using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndInterface_Task2_16._10.Extensions
{
    public static class Helper
    {
        public static bool IsOdd(this int number)
        {
            return number % 2 == 0;
        }    

        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        public static bool HasDigit(this string input)
        {
            for(int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckPassword(this string password)
        {
            if (password.Length < 8)
            {
                return false;
            }

            if (!password.Any(char.IsUpper))
            {
                return false;
            }

            if (!password.Any(char.IsLower))
            {
                return false;
            }

            if (!password.Any(char.IsDigit))
            {
                return false;
            }
            
            return true;
        }

        //public static string Capitalize(this string input)
        //{
        //    StringBuilder stringBuilder = new StringBuilder();
        //    
        //}
    }
}
