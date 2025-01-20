namespace AbstractClassInterfaceErrorHandling.Abstract
{
    class Rectangular : Shape
    {
        public override int Perimeter()
        {
            return Length * 2 + Width * 2;
        }
        public override decimal Area()
        {
            Console.WriteLine("Calculating area for a rectangle");
            return base.Area();
        }

    }
}
