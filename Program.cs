/* 
Shaliyah Johnson
Lab 4 Spring 2023 Due Feb 15th
Methods/Menus/Random numbers/For-loops/Input error handling 
Last update: Feb 15
*/



//*start main
int userChoice = GetUserChoice();
while (userChoice != 3) //does not execute if userInput is 3
{
    RouteMethod(userChoice);
    userChoice = GetUserChoice();
}

//*end main

//______________________________________________________METHODS_______________________________________________

static int GetUserChoice()
{

    DisplayMenu();
    string userChoice = Console.ReadLine();

    if (IsValidChoice(userChoice))
    { return int.Parse(userChoice); }

    else return 0;

}



static void DisplayMenu()
{
    System.Console.WriteLine("Enter 1 to display full triangle\nEnter 2 to display partial triangle\nEnter 3 to exit\n");
}

//Output full triangle
static void GetFull(Random rnd)
{
    int number = rnd.Next(3, 9);

    for (int row = 0; row <= number; row++)
    {
        for (int col = row; col >= 0; col--)
        {

            System.Console.Write(" o ");
        }
        System.Console.WriteLine("\n");
    }

}
//Output triangle with missing spots
static void GetPartial(Random rnd)
{
    int number = rnd.Next(3, 9);
    int num2 = rnd.Next(3, 9);

    System.Console.WriteLine("partial triangle");
    for (int row = 0; row <= number; row++)
    {
        for (int col = row; col >= 0; col--)
        {

            if ((row == num2) || (col == num2))
            {
                System.Console.Write(" ");
            }
            else System.Console.Write("o ");

        }
        System.Console.WriteLine("\n");
    }


}

//Displays error message
static void SayInvalid()
{

    System.Console.WriteLine("ERROR. Please enter valid input.");

}

//Assigns correct user choice with correct option
static void RouteMethod(int userChoice)
{
    if (userChoice == 1) GetFull(new Random());
    else if (userChoice == 2) GetPartial(new Random());
    else if (userChoice != 3) SayInvalid();
}

//Determines if input if input is valid i.e not outside scope of choices 
static bool IsValidChoice(string userChoice)
{
    if ((userChoice == "1") || (userChoice == "2") || (userChoice == "3"))
    {
        return true;
    }
    else return false;
}
//* End Methods

/*
Method Definitions 
GetUserChoice() int - read in user input from console
DisplayMenu() - void - Display menu items
GetFull() - void - Displats a randomly generated triangle between 3 and 9 rows and columns
GetPartial() -void  - Displays a randomly generated triangle that has between 3 and 9 rows and columns with random spots missing 
SayInvalid() -  void - Display error message if user input is invalid
RouteMethod() - void - Connects user input with intended function
IsValidChoice() - bool - return true if user inpur is in the scope of options and return false if user input is not in the scope of options
*/