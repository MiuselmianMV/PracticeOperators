namespace PracticeOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex1();
            Ex2();
            Ex3();
            Ex4();
        }

        public static void Ex1()
        {
            Console.WriteLine("\n---------------------------EX1---------------------------\n");

            var worker1 = new Worker("Kit P.V", "12.11.2011", "+12341234", "email.com", "director", "description!!", 150000);
            var worker2 = new Worker("Dog A.G", "01.01.2001", "+64395234", "gmail.com", "manager", "description!!?!", 943000);

            worker1.Show();
            Console.WriteLine();
            worker2.Show();
            Console.WriteLine();


            Console.WriteLine("worker's 1 salary == worker's 2 salary - {0}", worker1 == worker2);
            Console.WriteLine("worker's 1 salary (150000) + 150000 = {0}", (worker1 + 150000).Salary) ;
            Console.WriteLine("Worker 1 equals worker 2  - {0}", worker1.Equals(worker2));
            Console.WriteLine("Worker 1 > worker 2 + 2,000,000 = {0}", worker1 > (worker1 + 2000000));
        }

        public static void Ex2()
        {
            Console.WriteLine("\n---------------------------EX2---------------------------\n");

            var matrix1 = new Matrix(3,3);
            matrix1.FillValues();

            var matrix2 = new Matrix(3,3);
            matrix2.FillValues();

            Console.WriteLine("First matrix:");
            matrix1.Print();
            Console.WriteLine();

            Console.WriteLine("Second matrix:");
            matrix2.Print();
            Console.WriteLine();

            Console.WriteLine("Matrix 1 == matrix 2 - {0}", matrix1 == matrix2);
            Console.WriteLine("Matrix 1 * matrix 2 :");
            matrix1 *= matrix2;
            matrix1.Print();

            Console.WriteLine();
            Console.WriteLine("Matrix 2 + matrix 1: ");
            matrix2 += matrix1;
            matrix2.Print();

        }

        public static void Ex3()
        {
            Console.WriteLine("\n---------------------------EX3---------------------------\n");
            var kyiv = new City("Kyiv", "UA", 1000000, "+38", "Kyivska oblast'");
            var zp = new City("Zp", "UA", 150000, "+38", "Zaporizhka oblast'");

            Console.WriteLine("Zp == kyiv: {0}", zp == kyiv);
            Console.WriteLine("Kyiv > Zp : {0}", kyiv > zp);
            Console.WriteLine("Kyiv.Equals(Zp) : {0}", kyiv.Equals(zp));
            Console.WriteLine("Zp + 1000 = {0}", (zp + 1000));
            Console.WriteLine("Kyiv - 150000 = {0}", (kyiv - 150000));

        }

        public static void Ex4()
        {
            Console.WriteLine("\n---------------------------EX4---------------------------\n");

            var card1 = new CreditCard("4444 4444 4444 4444", 123, 1500);
            var card2 = new CreditCard("4111 1111 4111 4111", 123, 150);

            Console.WriteLine("First card:");
            card1.Show();
            Console.WriteLine();

            Console.WriteLine("Second card:");
            card2.Show();
            Console.WriteLine();

            Console.WriteLine("First card add 500: {0}", (card1 += 500).Money);
            Console.WriteLine("Second card == first card : {0}", card1 == card2);


        }
    }
}
