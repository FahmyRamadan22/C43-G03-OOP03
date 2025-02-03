namespace OOP_Assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part01
            #region Q1) Write a class named Calculator that contains a method named Add. Overload the Add method to:

            //Console.WriteLine(Calculator.Add(4, 6));
            //Console.WriteLine(Calculator.Add(7, 6, 4));
            //Console.WriteLine(Calculator.Add(5.5, 5.5));

            #endregion
            #region Q2) Create a class named Rectangle with the following constructors:

            //Rectangle rectangle = new Rectangle();
            //Console.WriteLine(rectangle);
            //rectangle = new Rectangle(10);
            //Console.WriteLine(rectangle);
            //rectangle = new Rectangle(5, 10);
            //Console.WriteLine(rectangle);
            #endregion
            #region Q3) Define a class Complex Number that represents a complex number with real and imaginary parts.
            //Complex complex = new Complex(5, 10);
            //Console.WriteLine(complex);

            //Complex complex1 = new Complex(30, 15);
            //Complex result = complex + complex1;
            //Console.WriteLine(result);
            #endregion
            #region Q4 ) Create a base class named Employee with method That Work as it prints    "Employee is  working".
            //Employee employee = new Employee();
            //employee.Work();

            //Employee manager = new Manager();
            //manager.Work();
            #endregion

            //Part02
            #region 1-Define Class Duration To include Three Attributes Hours, Minutes and Seconds.
            Duration D1 = new(3600 * 2);

            Duration D2 = new(3600 * 2);
            Console.WriteLine(D1.ToString());
            Console.WriteLine("=================================================================");

            #endregion
            #region 2-Override All System. Object Members [To String(), Equals(),GetHashCode() ] .
            Console.WriteLine(D1.Equals(D2));
            Console.WriteLine(D1.GetHashCode());
            Console.WriteLine(D2.GetHashCode());
            Console.WriteLine("=================================================================");

            #endregion
            #region  3 - Define All Required Constructors to Produce this output:
            Console.WriteLine("Before D1 = D2");
            Console.WriteLine($"== Result {D1 == D2}"); 
            Console.WriteLine($"Equals Result {D1.Equals(D2)}");

            #endregion
            #region 4-Implement All required Operators overloading to enable this Code:
            D1 = D2;

            D1 = new(3700);
            if (D1 >= D2)
                Console.WriteLine("Duration 1 is greater than or equal Duration 2");
            Console.WriteLine("=================================================================");

            D1--;
            Console.WriteLine(D1.ToString());
            Console.WriteLine("=================================================================");


            if (D1)
                Console.WriteLine("Duration is not equal zero");
            else
                Console.WriteLine("Duration is equal zero");

            Console.WriteLine("=================================================================");

            D1 = new(3700);
            Console.WriteLine((DateTime)D1);

            #endregion
        }
    }
}
