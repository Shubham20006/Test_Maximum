namespace GenericsDemo
{
    class Program
    {
      
        public static void Main(string[] args)
        {
            
            int A = 5;
            int B = 15;
            int C = 14;
            int val= FindMaximum<int>.MaxIntNum(A,B,C);
            Console.WriteLine("The greater num is " + val);
        }
    }
}
