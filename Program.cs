using System;

class Program {
    public static void Main(string[] args) {
        Console.Clear();

        checkForPositiveNegativeZero(-1);
        checkForPositiveNegativeZero(1);
        checkForPositiveNegativeZero(0);
        
        findMinimum(1, 2, 3);
        findMinimum(2, 1, 3);
        findMinimum(3, 2, 1);

        findMaximum(1, 2, 3);
        findMaximum(2, 1, 3);
        findMaximum(3, 2, 1);

        isDivisibleBy5(5);
        isDivisibleBy5(6);

        checkEvenOrOdd(2);
        checkEvenOrOdd(3);

        checkVowelOrConsonant('e');
        checkVowelOrConsonant('E');
        checkVowelOrConsonant('s');
        checkVowelOrConsonant('S');

        displayDayOfWeek(0);
        displayDayOfWeek(3);
        displayDayOfWeek(6);

    }
    // Define your functions below:
    public static void checkForPositiveNegativeZero(int number) {
        if (number == 0) {
            Console.WriteLine("Your number is zero");
        } else if (number > 0) {
            Console.WriteLine("Your number is positive");
        } else {
            Console.WriteLine("Your number is negative");
        }
    }
    public static void findMinimum(int num1, int num2, int num3) {
        int minimum = 0;
        if (num1 < num2 && num1 < num3) {
            minimum = num1;
        } else if (num2 < num1 && num2 < num3) {
            minimum = num2;
        } else {
            minimum = num3;
        }
        Console.WriteLine($"The minimum value is {minimum}.");
    }
    public static void findMaximum(int num1, int num2, int num3) {
        int maximum = 0;
        if (num1 > num2 && num1 > num3) {
            maximum = num1;
        } else if (num2 > num1 && num2 > num3) {
            maximum = num2;
        } else {
            maximum = num3;
        }
        Console.WriteLine($"The maximum value is {maximum}.");
    }

    public static void isDivisibleBy5(int number) {
        if (number % 5 == 0) {
            Console.WriteLine($"{number} is divisible by 5.");
        } else {
            Console.WriteLine($"{number} is not divisible by 5.");
        }
    }
    public static void checkEvenOrOdd(int number) {
        if (number % 2 == 0) {
            Console.WriteLine($"{number} is an even number.");
        } else {
            Console.WriteLine($"{number} is an odd number.");
        }
    }

    public static void checkVowelOrConsonant(char letter) {
        if ("aeiouyAEIOUY".Contains(letter)) {
            Console.WriteLine(letter + " is a vowel.");
        } else {
            Console.WriteLine(letter + " is a consonant.");
        }
    }

    public static void displayDayOfWeek(int dayCode) {
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