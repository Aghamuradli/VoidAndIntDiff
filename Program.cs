using System;

namespace VoidLeIntFerqi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateNums CalculateNums = new CalculateNums();

            int result1 = CalculateNums.Count1(3, 6);//int tipinde oldugu ucun alinan neticeni "result"a beraber edib islede bilirik .
            Console.WriteLine(result1 * 2);

            //int result2= CalculateNums.Count2(3, 6); //error =>cannot implicitly convert type 'void' to 'int' //void tipinde olan metodu basqa yerde cagirib ona islem gordure bilmerik!
            //Console.WriteLine(result2 * 2);
            //ona sadece deyer verib netice alia bilerik :
            CalculateNums.Count2(3, 6);
        }
    }
}
