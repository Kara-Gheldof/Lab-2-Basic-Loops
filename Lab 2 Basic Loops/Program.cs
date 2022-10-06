// See https://aka.ms/new-console-template for more information


//Exercise 1

string i;

do
{
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Would you like to continue? (y/n)?");
    i = Console.ReadLine();
}
while (i == "y");

    Console.WriteLine("Goodbye!");
  





//Exercise 2
string p;
do
{
    Console.WriteLine("Please enter a number.");
    string numberEntered = Console.ReadLine();
    int n = Convert.ToInt32(numberEntered);
    int k = 0;

    for (int j = n; j >= 0; j--)
    {
        Console.WriteLine(j);
    }

    for (int j = 0; j <= n; j++)
    {
        Console.WriteLine(j);
    }
    Console.WriteLine("Would you like to continue? (y/n)?");
    p = Console.ReadLine();
}
while (p == "y");

    Console.WriteLine("Goodbye!");



// Exercise 3
Console.WriteLine("Hello, this door is locked. Please enter a key code.");
string codeAttempt = Console.ReadLine();

bool locked = false;
bool unlocked = true;

while (codeAttempt == "13579") ;
