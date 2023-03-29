using System.Collections;

namespace Task13_2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputArr = new ArrayList() { 1, 2, 3, 4, 5, "a","b","c" };

            var summary = SummaryList(inputArr);
        }

        static ArrayList SummaryList (ArrayList input)
        {
            int intRes = 0;
            string strRes = string.Empty;
            foreach(var item in input)
            {

                if(item is int)
                {
                    intRes += (int)item;
                }
                else if (item is string) 
                { 
                    strRes += item.ToString();
                }
            }

            return new ArrayList() {intRes, strRes};
        }


    }
}