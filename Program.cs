namespace GenericsDemo
{
    class Program
    {
      
        public static void Main(string[] args)
        {
            
            int A = 15;
            int B = 21;
            int C = 33;
            int val = FindMaximum.MaxIntNum(A,B,C);
            Console.WriteLine("The maximum Number is " + val);
        }
    }
}
