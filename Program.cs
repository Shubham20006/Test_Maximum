namespace GenericsDemo
{
    class Program
    {
      
        public static void Main(string[] args)
        {
            
            float A = 15.2F;
            float B = 29.6F;
            float C = 18.4F;
            float val = FindMaximum.MaxIntNum(A,B,C);
            Console.WriteLine("The maximum Number is " + val);
        }
    }
}
