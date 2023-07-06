using System.Linq.Expressions;

namespace Generics
{
    public class Program
    {
      //  public static void toprint<T>(T[] inputArraty)
      //  {
        //    foreach (var element in inputArraty)
         //   {
          //      Console.WriteLine(element);
          //  }
       // }
        //public static void toprint(double[] inputArraty)
        //{
        //    foreach (double element in inputArraty)
        //    {
        //        Console.WriteLine(element);
        //    }
        //}
        //public static void toprint(char[] inputArraty)
        //{
        //    foreach (char element in inputArraty)
        //    {
        //        Console.WriteLine(element);
        //    }
        //}
        public static void Main(string[] args)
        {
            int[] inputArray = { 1, 2, 3, 4, };
            double[] doubleArray = { 1.1, 2.2, 7.7 };
            char[] charArray = { 'M', 'E', 'S', 'I' };


            //  Program.toprint<int>(inputArray);
            //  Program.toprint<double>(doubleArray);
            //  Program.toprint<char>(charArray);
            // PrintArray<int> printArray= new PrintArray<int>(inputArray);
            // printArray.toprint();
            //  PrintArray<double> doubleprintArray = new PrintArray<double>(doubleArray);
            //  doubleprintArray.toprint();
            //  PrintArray<char> charprintArray = new PrintArray<char>(charArray);
            //  charprintArray.toprint();
            find_max.solution(4,5,7);
        }
    }
}
 
    
