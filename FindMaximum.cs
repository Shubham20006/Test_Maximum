using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    public class FindMaximum
    {
        public static float MaxIntNum(float A, float B, float C)
        {
            if(A.CompareTo(B) > 0 && A.CompareTo(C)>0 || 
                    A.CompareTo(B) >= 0 && A.CompareTo(C) > 0 || 
                    A.CompareTo(B) > 0 && A.CompareTo(C) >= 0)
            {
                return A;
            }

            if (B.CompareTo(A) > 0 && B.CompareTo(C) > 0 ||
                    B.CompareTo(A) >= 0 && B.CompareTo(C) > 0 ||
                    B.CompareTo(B) > 0 && B.CompareTo(C) >= 0)
            {
                return B;
            }

            if (C.CompareTo(B) > 0 && C.CompareTo(A) > 0 ||
                    C.CompareTo(B) >= 0 && C.CompareTo(A) > 0 ||
                    C.CompareTo(B) > 0 && C.CompareTo(A) >= 0)
            {
                return C;
            }
            return A;
        }
    }
}
