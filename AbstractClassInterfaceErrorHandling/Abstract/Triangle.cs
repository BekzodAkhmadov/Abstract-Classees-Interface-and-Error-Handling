namespace AbstractClassInterfaceErrorHandling.Abstract
{
    class Triangle : Shape
    {
        public int Side1Length { get; set; }
        public int Side2Length { get; set; }
        public int Side3Length { get; set; }

        public override int Perimeter()
        {
            return Side1Length + Side2Length + Side3Length;
        }
        //public override decimal Area()
        //{
        //    var semiPerimeter = 0.5 * Perimeter();
        //    return (decimal)Math.Sqrt(semiPerimeter * (semiPerimeter - Side1Length) * (semiPerimeter - Side2Length) * (semiPerimeter - Side3Length));
        //}


    }
}
