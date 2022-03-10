/* Exercise 8 Part D */

int[] numbers = new int[10];


int input = 0;


int counter = 0;

int total = 0;

Console.WriteLine("Enter Up To 10 Whole Numbers: ");
while (input != -1)
{
    if (input <= -2)
    {
        Console.WriteLine("ERROR. \nEnter Positive Numbers Only: ");
        input = Convert.ToInt32(Console.ReadLine());
    }
    else if (input > -1)
    {
        input = Convert.ToInt32(Console.ReadLine());
    }
 
    if (input > -1)
    {
        numbers[counter] = input;
        counter++;
    }

    if (counter == 10)
    {
        input = -1;
    }
}
foreach (int num in numbers)
{
    total = total + num;
}

Console.WriteLine($"Your Total Is: {total}");