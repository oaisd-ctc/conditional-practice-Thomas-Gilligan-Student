using System;

class Program {
    public static void Main(string[] args) {
        Console.Clear();

        CheckForPositiveNegativeZero(-1);
        CheckForPositiveNegativeZero(1); //Double checked
        CheckForPositiveNegativeZero(0);
        
        FindMinimum(1, 2, 3);
        FindMinimum(2, 1, 3); //Double checked & fixed
        FindMinimum(3, 2, 1);

        FindMaximum(1, 2, 3);
        FindMaximum(2, 1, 3); //Double checked & fixed
        FindMaximum(3, 2, 1);

        IsDivisibleBy5(5); //Double checked
        IsDivisibleBy5(6);

        CheckEvenOrOdd(2); //Double checked
        CheckEvenOrOdd(3);

        CheckVowelOrConsonant('e');
        CheckVowelOrConsonant('E'); //Double checked
        CheckVowelOrConsonant('s');
        CheckVowelOrConsonant('S');

        DisplayDayOfWeek(0);
        DisplayDayOfWeek(3); //Double checked
        DisplayDayOfWeek(6);

    }
    // Define your functions below:
    public static void CheckForPositiveNegativeZero(int number) {
        if (number == 0) {
            Console.WriteLine("Your number is zero");
        } else if (number > 0) {
            Console.WriteLine("Your number is positive");
        } else {
            Console.WriteLine("Your number is negative");
        }
    }
    public static void FindMinimum(int num1, int num2, int num3) {
        int minimum = num1;
        if (num2 < minimum) {
            minimum = num2;
        }
        if (num3 < minimum){
            minimum = num3;
        }
        Console.WriteLine($"The minimum value is {minimum}.");
    }
    public static void FindMaximum(int num1, int num2, int num3) {
        int maximum = num1;
        if (num2 > maximum){
            maximum = num2;
        }
        if (num3 > maximum){
            maximum = num3;
        }
        Console.WriteLine($"The maximum value is {maximum}.");
    }

    public static void IsDivisibleBy5(int number) {
        if (number % 5 == 0) {
            Console.WriteLine($"{number} is divisible by 5.");
        } else {
            Console.WriteLine($"{number} is not divisible by 5.");
        }
    }
    public static void CheckEvenOrOdd(int number) {
        if (number % 2 == 0) {
            Console.WriteLine($"{number} is an even number.");
        } else {
            Console.WriteLine($"{number} is an odd number.");
        }
    }

    public static void CheckVowelOrConsonant(char letter) {
        if ("aeiouyAEIOUY".Contains(letter)) {
            Console.WriteLine(letter + " is a vowel.");
        } else {
            Console.WriteLine(letter + " is a consonant.");
        }
    }

    public static void DisplayDayOfWeek(int dayCode) {
        switch (dayCode) {
            case 0: Console.WriteLine("Sunday"); break;
            case 1: Console.WriteLine("Monday"); break;
            case 2: Console.WriteLine("Tuesday"); break;
            case 3: Console.WriteLine("Wednesday"); break;
            case 4: Console.WriteLine("Thursday"); break;
            case 5: Console.WriteLine("Friday"); break;
            case 6: Console.WriteLine("Saturday"); break;
            default: Console.WriteLine("Invalid day code."); break;
        }
    }
}