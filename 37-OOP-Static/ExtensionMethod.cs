using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_OOP_Static
{
    public static class ExtensionMethod
    {
        public static int WordCount(this string str)
        { 
            if(string.IsNullOrEmpty(str)) 
                return 0;

            string[] words = str.Split(' ');
            return words.Length;
        }

        public static int CalculateAge(this DateTime birthDate)
        {
            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now.Year < birthDate.Year)
                throw new Exception("Günümüz yılından büyük olamaz.");

            return age;
        }
    }
}
