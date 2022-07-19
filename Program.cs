using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            //Restriction
            //int[] numbers = { 5, 3, 1, 6, 8, 9, 4, 2, 0 };

            //var lowNumber = from num in numbers
            //                where num < 5
            //                select num;
            //Console.WriteLine("Number less than 5");

            //foreach(var n in lowNumber)
            //{
            //    Console.WriteLine(n);
            //}
            // Restriction using Where() method
            //string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Shortdigits = digits.Where((digit, index)  => digit.Length < index);
            //Console.WriteLine("Short digit:");

            //    foreach(var x in Shortdigits)
            //{
            //    Console.WriteLine($"The word {x} in  shorter than their value");
            //}

            // Projection
            // using select keyword
            //int[] numbers = {1, 2, 3, 5, 4, 6, 9 };

            //var incNum = from n in numbers
            //             select n + 1;

            //Console.WriteLine("Increased array");

            //foreach(var x in incNum)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = {1, 2, 3, 4, 5, 7, 6, 0, 8, 9};
            //string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var strNum = from n in  numbers
            //             select strings[n];

            //Console.WriteLine("Number in strings");

            //foreach(var x in strNum)
            //{
            //    Console.WriteLine(x);
            //}

            //string[] words = { "aPPle", "sNake", "ShaKe"};

            //var UpperLower = from n in words
            //                 select (Upper : n.ToUpper(), Lower : n.ToLower());

            //Console.WriteLine("Upper and Lower case ");

            //foreach(var ul in UpperLower)
            //{
            //    Console.WriteLine($"Upper : {ul.Upper} Lower : {ul.Lower}");
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 7, 6, 0, 8, 9 };
            //string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var digitOddEven = from n in numbers
            //                   select (Digit: strings[n], Even: (n % 2 == 0));

            //foreach (var d in digitOddEven)
            //{
            //    Console.WriteLine($"The digit {d.Digit} is {(d.Even ? "even" : "odd")}.");
            //}
            //int[] numbers = { 1, 2, 2, 3, 9, 8, 6, 7, 9, 0 };

            //var numsInPlace = numbers.Select((num, index) => (Num: num, InPlace: (num == index)));

            //Console.WriteLine("Number: In-place?");
            //foreach (var n in numsInPlace)
            //{
            //    Console.WriteLine($"{n.Num}: {n.InPlace}");
            //}
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var lowNums = from n in numbers
            //              where n < 5
            //              select digits[n];

            //Console.WriteLine("Numbers < 5:");
            //foreach (var num in lowNums)
            //{
            //    Console.WriteLine(num);
            //}

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var pairs = from a in numbersA
            //            from b in numbersB
            //            where a < b
            //            select (a, b);

            //Console.WriteLine("Pairs where a < b:");
            //foreach (var pair in pairs)
            //{
            //    Console.WriteLine($"{pair.a} is less than {pair.b}");
            //}

            //Partition
            //int[] numbers = {1, 2, 5, 4, 6, 7, 8, 9 };

            //var Lnum = numbers.Take(3);
            //Console.WriteLine("First three numbers");
            //foreach(var c in Lnum)
            //{
            //    Console.WriteLine(c);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 6, 8 };

            //var skipNum = numbers.Skip(3);

            //Console.WriteLine("Skip the four numbers");

            //foreach(var s in skipNum)
            //{
            //    Console.WriteLine(s);
            //}

            //int[] numbers = { 2, 5, 6, 7, 4, 8, 9, 1, 3};

            //var lseNumm = numbers.TakeWhile(n => n < 6);
            //Console.WriteLine("Skip the numbers less than six");

            //foreach(var s in lseNumm)
            //{
            //    Console.WriteLine(s);
            //}
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //// In the lambda expression, 'n' is the input parameter that identifies each
            //// element in the collection in succession. It is is inferred to be
            //// of type int because numbers is an int array.
            //var allButFirst3Numbers = numbers.SkipWhile(n => n % 3 != 0);

            //Console.WriteLine("All elements starting from first element divisible by 3:");
            //foreach (var n in allButFirst3Numbers)
            //{
            //    Console.WriteLine(n);
            //}

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var laterNumbers = numbers.SkipWhile((n, index) => n >= index);

            Console.WriteLine("All elements starting from first element less than its position:");
            foreach (var n in laterNumbers)
            {
                Console.WriteLine(n);
            }
        }

        //public class Product
        //{
        //    public int ProductID { get; set; }
        //    public string ProductName { get; set; }
        //    public string Category { get; set; }
        //    public decimal UnitPrice { get; set; }
        //    public int UnitsInStock { get; set; }
        //    public override string ToString() =>
        //        $"ProductID={ProductID} ProductName={ProductName} Category={Category} UnitPrice={UnitPrice:C2} UnitsInStock={UnitsInStock}";

        //}




    }
}
