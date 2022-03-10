/* Exercise 8 Part D */

int[] numbers = new int[10];

// User Input
int input = 0;

// Counts Number Of Inputs
int counter = 0;

int total = 0;

Console.WriteLine("Enter Up To 10 Whole Numbers: ");
while (input != -1)
{
    if (input <= -2)
    {
        Console.WriteLine("ERROR. \nEnter Positive Numbers Only: "); // If User Enters Number <= -2, ERROR And Doesn't Add To Counter
        input = Convert.ToInt32(Console.ReadLine());
    }
    else if (input > -1)
    {
        input = Convert.ToInt32(Console.ReadLine());
    }
    // User Enters Number > -1, Adds Input To Counter
    if (input > -1)
    {
        numbers[counter] = input;
        counter++;
    }

    if (counter == 10) // User Enters 10 Valid Numbers(x > -1), Input Automatically = -1 To Stop
    {
        input = -1;
    }
}
foreach (int num in numbers) // Creats Int For Each Input In Array
{
    total = total + num;
}

Console.WriteLine($"Your Total Is: {total}");