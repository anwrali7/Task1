namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("enter your favorite number between 1 and 100");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"No really!! {number} is my favorite number too.");

            //Console.WriteLine("What is Your First Name?");
            //String Fna = Console.ReadLine()!;
            //Console.WriteLine($"Hello, {Fna}!, Nice to meet you!");

            //int[] emp = new int[3];
            //emp[0] = 1;
            //emp[1] = 2;
            //emp[2] = 3;
            //Console.WriteLine(emp[0]);
            //Console.WriteLine(emp[1]);
            //Console.WriteLine(emp[2]);
            //emp[0] = 90;
            //Console.WriteLine(emp[0]);

            // small 
            Console.WriteLine("Enter number of small carpets:");
            int sCarpetsN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You have entered {sCarpetsN} small carpets.");
            // large
            Console.WriteLine("Enter number of Large carpets:");
            int lCarpetsN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You have entered {lCarpetsN} large carpets.");

            // الاسعار والضريبه
            decimal priceSmall = 25m;
            decimal taxRate = 0.06m;
            decimal priceLarge = 35m;

            // حساب التكلفة 
            decimal smallCost = sCarpetsN * priceSmall;
            decimal largeCost = lCarpetsN * priceLarge;

            // حساب التكلفة الإجمالية والضريبة
            decimal cost = smallCost + largeCost;
            decimal tax = cost * taxRate;
            decimal total = cost + tax;

            Console.WriteLine("======================================");
            Console.WriteLine("Estimate for carpet cleaning service");
            Console.WriteLine("Number of small carpets: " + sCarpetsN);
            Console.WriteLine("Number of large carpets: " + lCarpetsN);
            Console.WriteLine("Price per small carpet: $" + priceSmall);
            Console.WriteLine("Price per large carpet: $" + priceLarge);
            Console.WriteLine($"Cost: ${cost}");
            Console.WriteLine($"Tax: ${tax}");
            Console.WriteLine("======================================");
            Console.WriteLine($"Total estimate: ${total}");
            Console.WriteLine("This estimate is valid for 30 days");

            int X = 10;
            int Y = 20;
            Console.WriteLine($"Equation: {X} + {Y} = {X + Y:C}");

            double discount = 0.25;
            Console.WriteLine($"Discount Rate: {discount:P}");
        }

    }
}

