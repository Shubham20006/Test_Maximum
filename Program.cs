namespace GenericsDemo
{
    class Program
    {
      
        public static void Main(string[] args)
        {
            
            string A = "Banana";
            string B = "Peach";
            string C = "Apple";
            string val = FindMaximum.MaxIntNum(A,B,C);
            Console.WriteLine("The maximum String is " + val);
        }
    }
}
