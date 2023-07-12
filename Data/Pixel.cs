using System;
namespace MyPhotoshop
{
    public struct Pixel
    {
        public Pixel(double r, double g, double b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }

        private double r;
        private double g;
        private double b;
        public double R 
        {
            get
            {
                return r;
            }
            set
            {
                r = Check(value);
            }
        }
        public double G 
        {
            get
            {
                return g;
            }
            set
            {
                g = Check(value);
            }
        }
        public double B 
        {
            get
            {
                return b;
            }
            set
            {
                b = Check(value);
            }
        }

        public static Pixel operator * (Pixel p, double num)
        {
            return new Pixel(p.R * num,
                             p.G * num,
                             p.B * num);
        }

        public static Pixel operator *(double num, Pixel p)
        {
            return p * num;
        }

        public static double Check(double num)
        {
            if (num < 0 || num > 1)
                throw new ArgumentException();
            return num;
        }
    }
}
