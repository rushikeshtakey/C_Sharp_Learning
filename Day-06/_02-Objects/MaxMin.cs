using System;

namespace Object
{
    public class MaxMin
    {

        public  int n1;
        public  int n2;

        public  int Max()
        {
            return ((n1 > n2) ? n1 : n2);
        }
        public  int Min()
        {
            return ((n1 < n2) ? n1 : n2);
        }

    }
}