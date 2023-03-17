using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        string[] students = { "Hector", "Skyler", "Saul", "Huell", "Tuco", "Walter", "Jesse", "Gus", "Jane", "Hank" };
        int[] grades = new int[10];

        Console.WriteLine("- - - - - - - - - - - - - -");
        Console.WriteLine("Bruno's Student-Marks-CO453");
        Console.WriteLine("- - - - - - - - - - - - - -");
        Console.WriteLine("*ᴾʳᵉˢˢ ᵃⁿʸ ᵏᵉʸ ᵗᵒ ᶜᵒⁿᵗᶦⁿᵘᵉ*");
        Console.ReadKey();

        for (int i = 0; i < students.Length; i++)
        {
            Console.Write($"Enter {students[i]}'s grade: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out grades[i]) || grades[i] < 0 || grades[i] > 100)
            {
                Console.WriteLine("[ERROR] 0 to 100 input only accepted");
                i--; // repeat this iteration
            }
        }

        Console.WriteLine("Would you like to see the grades displayed? (Y/N)");
        string showGrades = Console.ReadLine();

        if (showGrades.ToUpper() == "Y")
        {
            Console.WriteLine("\nGrades:");

            for (int i = 0; i < students.Length; i++)
            {
                Console.Write($"{students[i]} = {grades[i]} / ");

                if (grades[i] >= 70)
                {
                    Console.WriteLine("A");
                }
                else if (grades[i] >= 60)
                {
                    Console.WriteLine("B");
                }
                else if (grades[i] >= 50)
                {
                    Console.WriteLine("C");
                }
                else if (grades[i] >= 40)
                {
                    Console.WriteLine("D");
                }
                else
                {
                    Console.WriteLine("F");
                }
            }
        }

        Console.WriteLine("Would you like to see the mean grade? (Y/N)");
        string showMean = Console.ReadLine();

        if (showMean.ToUpper() == "Y")
        {
            double mean = CalculateMean(grades);
            Console.WriteLine($"The mean grade is: {mean:N2}");
        }

        Console.WriteLine("*ᴾʳᵉˢˢ ᵃⁿʸ ᵏᵉʸ ᵗᵒ ᵉˣᶦᵗ*");
        Console.ReadKey();
    }

    static double CalculateMean(int[] grades)
    {
        double sum = 0;

        foreach (int grade in grades)
        {
            sum += grade;
        }

        return sum / grades.Length;
    }
}
