/* 
Shaliyah Johnson
Lab 4 Spring 2023 Due Feb 15th
Methods/Menus
Last update: Feb 13
*/
// Goal Feb 13th: 
// Create Display Mend method
// routing method  
// Error handling method

//TODO: Understand nested for loops
//TODO: Genrate random number with holy triangle
//TODO: Watch arrays video

//*start main
int userChoice = GetUserChoice();
while (userChoice != 3) //does not execute if userInput is 3
{
    RouteMethod(userChoice);
    userChoice = GetUserChoice();
}

//*end main

//************************************METHODS*****************************************************************************

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

static void GetPartial(Random rnd)
{
    int number = rnd.Next(3, 9);

    System.Console.WriteLine("partial triangle");
    for (int row = 0; row <= number; row++)
    {
        for (int col = row; col >= 0; col--)
        {
                         System.Console.Write(" o ");
        }
        System.Console.WriteLine("\n");
    }

}

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

