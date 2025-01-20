namespace AbstractClassInterfaceErrorHandling.Abstract
{
    abstract class Shape
    {


        //public int Perimeter() => 10;
        //public decimal Area() => 15;
        public abstract int Perimeter();
        public virtual decimal Area()
        {
            return Length * Width;
        }
        public int Length;

        public int Width;
    }
}
