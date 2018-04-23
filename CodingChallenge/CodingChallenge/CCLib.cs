using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CodingChallenge
{
    class CCLib
    {
        bool test=true;
        int size;
        string classString,copyString;
        char part;
        public bool Check(string sent)
        {
            if(string.IsNullOrWhiteSpace(sent))
            {
                return true;
            }
            classString = sent.Replace(" ", String.Empty);
            classString = classString.ToLower();
            copyString = CleanInput(classString);

            //for (int i = 0; i < classString.Length; i++)
            //{
            //    part = classString[i];
            //    if(!char.IsLetterOrDigit(part))
            //    {
            //        //copyString[i]
            //        r
            //    }
            //}
            
            size = copyString.Length;
            Console.WriteLine(size/2);
            for (int k = 0; k <= (size / 2); k++)
            {
                if (copyString[k] != copyString[size - k])
                    return false;
            }
            return true;
        }
        static string CleanInput(string strIn)
        {
            try
            {
                return Regex.Replace(strIn, @"[^\w]", "",
                    RegexOptions.None, TimeSpan.FromSeconds(1.5));
            }
            catch (RegexMatchTimeoutException)
            {
                return String.Empty;
            }
        }
    }
}
