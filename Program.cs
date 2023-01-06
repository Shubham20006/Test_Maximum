namespace GenericsDemo
{
    class Program
    {
      
        public static void Main(string[] args)
        {
           

           
           int D= FindMaximum<int>.MaxNum(5,15,24);
            Console.WriteLine("The greater Integer num is : " + D);


        }
    }
}
