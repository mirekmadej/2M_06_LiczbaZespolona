namespace _2M_06_LiczbaZ
{
    class LiczbaZ
    {
        private double re;
        private double im;
        public LiczbaZ(double re = 0, double im = 0)
        {
            this.re = re;
            this.im = im;
        }
        public override string ToString()
        {
            if(re == 0) 
                return $"{im}i";
            if(im == 0) 
                return $"{re}";
            if(im<0)
                return $"{re}{im}i";
            return $"{re}+{im}i";
        }
        public static LiczbaZ operator+(
            LiczbaZ z1, LiczbaZ z2)
        {
            double re = z1.re + z2.re;
            double im = z1.im + z2.im;
            return new LiczbaZ(re, im);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            LiczbaZ z1 = new LiczbaZ(3,6);
            Console.WriteLine(z1);
            LiczbaZ z2 = new LiczbaZ(3, -1);
            Console.WriteLine(z2);
            
            Console.WriteLine(z1+z2);

        }
    }
}