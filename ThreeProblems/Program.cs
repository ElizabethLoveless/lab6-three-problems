/*
* Name: Elizabeth Loveless
* Course: CSCI 1250, Section 001
* Assignment: Lab 06, Three Short Problems
* Date: October 23, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/

// One Random for the program so the dice carry over
Random rng = new Random (4000);

// Fixed values that do not change
const int Dice_Seed = 4000;
const int Score_Count = 5;
const int Passing_Score = 60;
const int Menu_Options = 5;
const int Quit_Option = 5;

int choice = 0;

// The Menu: shows the options, validates the choice, run and repeats until quit
// do while: the menu must be shown before the user can choose to quit
do
{
    choice = 0;
    Console.WriteLine ("=== CSCI 1250 Lab 06 ===");
    Console.WriteLine ("1. The Grade Checker");
    Console.WriteLine ("2. The Dice Table");
    Console.WriteLine ("3. The Score Report");
    Console.WriteLine ("4. All three");
    Console.WriteLine ("5. Quit");
    Console.Write("Choose 1 through " + Menu_Options + ": ");
    choice = 
    Convert.ToInt32(Console.ReadLine());

// while: the user can enter the wrong choice multiple times or none at all
    while (choice < 1 || choice > Menu_Options);
    {
        Console.WriteLine ("Choose a number from 1 to " + Menu_Options + ".");
        Console.Write("Choose 1 through " + Menu_Options + ": ");
        choice = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();

    //Exercise 1: Grade Checker (run choices 1 and 4)
    if (choice == 1 || choice == 4)
    {
        Console.WriteLine ("=== Exercise 1: The Grade Checker ===");
        Console.Write ("Score: ");
        int score = Convert.ToInt32 (Console.ReadLine());
        //while: a bad score might be entered many times or zero times, and the program will not continue until its valid 
        while ( score < 0 || score > 100)
        {
            Console.WriteLine ("A score must be between 0 and 100");
            Console.Write("Score: ");
            score = Convert.ToInt32(Console.ReadLine());
        }
        // Bands go from top down: The first branch wins 
        string grade;
        if (score >= 90)
        {
        grade = "A";
        }
        else if (score >= 80)
        {
        grade = "B";
         }
        else if (score >= 70)
        {
        grade = "C";
          }
        else if (score >= 60)
        {
        grade = "D";
        }
        else
        {
        grade = "F";
        }
        Console.WriteLine(score + " earns a " + grade + ".");
        Console.WriteLine();
    }
    //Exercise 2: Dice Table (The counter resets on each visit, the dice stay the same)
    if (choice == 2 || choice == 4)
    {
        Console.WriteLine ("=== Exercise 2: The Dice Table ===");
        int rolls = 0;
        int wins = 0;
        string again;

        // do while: the player came to roll, so the body has to run atleast once before you can ask anything.
    do 
    {
        rolls ++;
        int die1 = rng.Next(1,7);
        int die2 = rng.Next(1,7);
        int total = die1 + die2;

        Console.Write ("Roll " + rolls + ": " + die1 + " and " + die2 + ", total " + total + ".");

        // Snake eyes is doubles 
    if(die1 == 1 && die2 == 1)
    {
        Console.Write(" Snake eyes.");
    }
    else if (die1 == die2)
    {
        Console.Write(" Doubles!");
    }
    else if (total == 7 || total == 11)
    {
        Console.Write(" A winner.");
    }

    if (total == 7 || total == 11)
    {
        wins++;
    }
        Console.WriteLine();
        Console.Write ("Roll again? (y/n): ");
        again = Console.ReadLine();
    } while (again == "y");

    Console.WriteLine("You rolled " + rolls + " times and won " + wins + ".");
    Console.WriteLine();
}

//Exercise 3: Score Report 
if (choice == 3 || choice 4)
{
    Console.Write("Score " + (i + 1) + ": ");
    scores[i] = Convert.ToInt32(Console.ReadLine());
}
int total = 0;
int highest = scores[0];
int passing = 0;

    // foreach: adding, comparing, and counting every value
    foreach (int s in scores)
    {
        total +=s;
        if (s > highest)
        {
            highest = s;
        }
        if (s >= PASSING_SCORE)
        { 
            passing++:
        } 
    }
    // One side is a double so the divsion keeps the decimals 
    double average = (double)total / scores.Length;
    Console.Writeline();
    Console.Writeline("Scores entered: " + scores.Length);    
    Console.Writeline("Total: " + total);
    Console.Writeline("Average: " + Math.Round(average, 1)); 
    Console.Writeline("Highest: " + highest);
    Console.Writeline("Passing: "+ passing + " of " + score.Length);
    Console.WriteLine();
    }
} while (choice != QUIT_OPTION);

Console.WriteLine("Goodbye. ");






    









        












    


        



        







            




        
        
        















        
