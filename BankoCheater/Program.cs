// BankoCheater
using System.Reflection.Emit;

int[,] plate1 = new int[3, 5];
int[,] plate2 = new int[3, 5];
int[,] plate3 = new int[3, 5];
string inputText = "";
bool check = false;
bool play = true;

Console.WriteLine();
Console.WriteLine("What is your plateID?");
string plateID = Console.ReadLine().Trim().ToLower();

Console.WriteLine($"Type in your {plateID} plate, row 1. Separate the numbers with ','");
inputText = Console.ReadLine().Trim();
string[] inputArray = inputText.Split(",");
for (int i = 0; i < inputArray.Length; i++)
{
    plate1[0, i] = Convert.ToInt32(inputArray[i]);
}

Console.WriteLine($"Type in your {plateID} plate, row 2. Separate the numbers with ','");
inputText = Console.ReadLine().Trim();
inputArray = inputText.Split(",");
for (int i = 0; i < inputArray.Length; i++)
{
    plate1[1, i] = Convert.ToInt32(inputArray[i]);
}

Console.WriteLine($"Type in your {plateID} plate, row 3. Separate the numbers with ','");
inputText = Console.ReadLine().Trim();
inputArray = inputText.Split(",");
for (int i = 0; i < inputArray.Length; i++)
{
    plate1[2, i] = Convert.ToInt32(inputArray[i]);
}

Label:
Console.WriteLine("Number Drawn: ");
inputText = Console.ReadLine().Trim();
int numberDrawn = int.Parse(inputText);

if (numberDrawn != null)
{
    check = true;
}
while (check == true)
{
    for (int i = 0; i < plate1.GetLength(0); i++)
    {
        for (int j = 0; j < plate1.GetLength(1); j++)
        {
            // if numberDrawn matches a number on the plate it changes the number to 0.
            if (plate1[i, j] == numberDrawn)
            {
                plate1[i, j] = 0;
                // Checks if there is bingo on one row.
                if (plate1[i,0] == 0 && plate1[i,1] == 0 && plate1[i,2] == 0 && plate1[i,3] == 0 && plate1[i,4] == 0)
                {
                    Console.WriteLine($"You have one row on {plateID} row {i+1}");
                    for (int k = 0; k < plate1.GetLength(1); k++)
                    {
                        if (plate1[k,0] == plate1[i,0] && plate1[k,1] == plate1[i,1] && plate1[k,2] == plate1[i,2] && )
                    }
                }
            }
        }
    }
    PrintPlates();
    goto Label;
}
void PrintPlates()
{
    Console.WriteLine($"Plate ID: {plateID}");
    for (int i = 0; i < plate1.GetLength(1); i++)
    {
        Console.Write(plate1[0, i] + " ");
    }
    Console.WriteLine();
    for (int i = 0; i < plate1.GetLength(1); i++)
    {
        Console.Write(plate1[1, i] + " ");
    }
    Console.WriteLine();
    for (int i = 0; i < plate1.GetLength(1); i++)
    {
        Console.Write(plate1[2, i] + " ");
    }
    Console.WriteLine();
}