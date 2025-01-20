namespace AbstractClassInterfaceErrorHandling.ErrorHandling
{
    internal class WorkSpaceForErrorHandling
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    BekzodSaysDivide();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("--Bekzod Divide StackTrace--");
            //    Console.WriteLine(e.StackTrace);
            //    throw;
            //}

            
        }
        public static decimal DivideHandled(decimal arg1, decimal? arg2)
        {
            if (arg2 == null) throw new BetterDevisionException("Cannot divide by null") { Dividend = arg1, Divisor = arg2 };
            if (arg2.Value == 0) throw new BetterDevisionException() { Dividend = arg1, Divisor = arg2 };
            return arg1 / arg2.Value;
        }
        public static void BekzodSaysDivide() 
        {
            DoTheDivideThing(); 
        }
        public static void DoTheDivideThing() 
        {
            TryDividing();
        }

        public static void TryDividing()
        {
            try
            {
                Console.WriteLine(DivideHandled(4, 0));
            }
            catch (BetterDevisionException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine($"Division attempted {e.Dividend}/{e.Divisor}");
                Console.WriteLine(e.StackTrace);
              
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divided by zero");
                throw;
            }
            catch
            {
                Console.WriteLine("Did something else");
                throw;
            }
        }
    }
}
