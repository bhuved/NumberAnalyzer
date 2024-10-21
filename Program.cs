// See https://aka.ms/new-console-template for more information
//Prompt the user to enter name
using System.Linq.Expressions;

Console.WriteLine("Enter your name");
string name = Console.ReadLine();

//Loop continues till the user wants to continue
bool cont = true;
while (cont)
{
    //Prompt the user to enter number
    repeat:
    Console.WriteLine($"Hi {name}, Enter a number between 1 and 100");
    //checking for valid number
    string numString = Console.ReadLine();
    //handle exception if user enters string value
    try { int checkValid = Convert.ToInt32(numString); }
    catch (FormatException)
    {
        Console.WriteLine("{0} is not an integer", numString);
        goto repeat;
    }
    int numberEntered = Convert.ToInt32(numString);


    if (numberEntered <= 0 || numberEntered > 100)
    {
        Console.WriteLine("InValid number");
        goto repeat;
    }
    else
    {
        // checking the num is odd and print the message accordingly
        int numCheck = numberEntered % 2;
        if (numCheck != 0)
        {
            if (numberEntered < 60)
            {
                Console.WriteLine($"{name}, you entered {numberEntered} is Odd and less then 60");
            }
            else if (numberEntered > 60)
            {
                Console.WriteLine(numberEntered + " is Odd and greater then 60");
            }
        } // checking the num is even and print the message accordingly
        else if (numCheck == 0)
        {
            if (numberEntered >= 2 && numberEntered < 25)
            {
                Console.WriteLine(name + ",you entered " + numberEntered + " is Even and less then 25");
            }
            else if (numberEntered >= 26 && numberEntered <= 60)
            {
                Console.WriteLine(name + ",you entered " + numberEntered + " is Even and between 26 and 60 inclusive");
            }
            else if (numberEntered > 60)
            {
                Console.WriteLine(name + ",you entered " + numberEntered + " is Even and greater then 60");
            }

        }
    }// prompt the user wants to continue
    Console.WriteLine(name +", Do you want to stop y/n");
    string answer = Console.ReadLine();
    if (answer != null)
    {
        switch (answer.ToLower())
        {
            case "n":
            case "no":
                cont = true;
                break;
            case "y":
            case "yes":
                cont = false;
                break;
            default:
                cont = false;
                break;

        }
    }
    if (!cont)
    { break; }

}