using System.Collections;

namespace Task13_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var months = new[]
            {
               "Jan", "Feb", "Mar", "Apr", "May" , "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
            };

            var numbers = new[]
            {
               1, 2, 3,4, 5, 6, 7, 8, 9, 10, 11, 12
            };

            var mnthNum = new ArrayList();
            
            foreach  (var num in numbers)
            {
                mnthNum.Add(months[num - 1]);
                mnthNum.Add(num);
            }
        }
    }
}