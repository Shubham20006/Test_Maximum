namespace GenericsDemo
{
    class Program
    {
      
        public static void Main(string[] args)
        {
            float A = 5.2F;
            float B = 1.5F;
            float C = 3.4F;
            float val = FindMaximum<float>.MaxIntNum(A, B, C);
            Console.WriteLine("The greater Float num is   : " + val);

            int P = 5;
            int Q = 15;
            int R = 14;
            int NUM = FindMaximum<int>.MaxFloatNum(P, Q, R);
            Console.WriteLine("The greater Integer num is : " + NUM);

            string X = "Banana";
            string Y = "Peach";
            string Z = "Apple";
            string U = FindMaximum<string>.MaxString(X,Y,Z);
            Console.WriteLine("The maximum String is      : " + U);
        }
    }
}
