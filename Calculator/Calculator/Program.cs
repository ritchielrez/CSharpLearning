using System;
using LibCalculator;

namespace Calculator {
    class Program {
        static void Main() {
            decimal num1, num2, result = 0;

            Console.Write("What you want to do(add, sub, mul, div)? ");
            var option = Console.ReadLine().ToLower();

            if(option != "add" && option != "sub" && option != "mul" && option != "div") {
                throw new InvalidOperationException("Wrong calculation operation picked, valid options are add(Addition), sub(Subtraction), mul(Multiplication) and div(Division)");
            }

            Console.Write("Enter 2 numbers, like this(12 12): ");
            var nums = Console.ReadLine().Split();

            if (nums.Length > 2) {
                throw new ArgumentOutOfRangeException(nameof(nums.Length), "Too many numbers to calculate");
            }

            num1 = Convert.ToDecimal(nums[0]);
            num2 = Convert.ToDecimal(nums[1]);

            if (option == "add") {
                result = Calculate.add(num1, num2);
            }
            else if(option == "sub") {
                result = Calculate.sub(num1, num2);
            }
            else if(option == "mul") {
                result = Calculate.mul(num1, num2);
            }
            else if(option == "div") {
                result = Calculate.div(num1, num2);
            }

            Console.WriteLine($"The calculated result is {result}");

        }
    }
}

