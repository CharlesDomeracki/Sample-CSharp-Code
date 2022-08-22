using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C_SharpSampleLib
{
    public class ZerosChallenge
    {
        public static int ZerosChallengeMethod(int number)
        {
            int result = 0;
            int streak = 0;
            char[] numberArray = number.ToString().ToCharArray();
            foreach (char element in numberArray)
            {
                if (element == '0')
                {
                    streak += 1;
                }
                else 
                {
                    streak = 0;
                }
            }
            result = Math.Max(result, streak);
            return result;
        }
    }
}
