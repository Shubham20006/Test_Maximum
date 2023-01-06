namespace GenericsDemo
{
    class Program
    {
      
        public static void Main(string[] args)
        {
            
            string A = "Apple";
            string B = "Peach";
            string C = "Banana";
            string val = FindMaximum<string>.MaxIntNum(A,B,C);
            Console.WriteLine("The maximum String is " + val);
        }
    }
}
