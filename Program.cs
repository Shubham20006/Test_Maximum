namespace GenericsDemo
{
    class Program
    {
      
        public static void Main(string[] args)
        {
            
            float A = 5.2F;
            float B = 1.5F;
            float C = 3.4F;
            float val = FindMaximum<float>.MaxIntNum(A,B,C);
            Console.WriteLine("The greater num is " + val);
        }
    }
}
