using System.Collections.Generic;

namespace ITI.Unicorn.Core.Level1
{
    public class P01_Unicorn
    {
        public static string[] GetSolution(int[] input)
        {
            List<string> result = new List<string>();

            foreach (int num in input)
            {
                string str = "";
                if (num % 3 == 0) str += "uni";
                if (num % 5 == 0) str += "corn";
                if (num % 7 == 0) str += "flakes";

                result.Add(str == "" ? num.ToString() : str);
            }

            return result.ToArray();
        }
    }
}
