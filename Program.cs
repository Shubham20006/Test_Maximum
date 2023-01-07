namespace GenericsDemo
{
    class Program
    {
      
        public static void Main(string[] args)
        {
            

           
           FindMaximum<int> F= new FindMaximum<int>(5,15,24);
           F.MaxMethod();
            //F.toPrint();



        }
    }
}
