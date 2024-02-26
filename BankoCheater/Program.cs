// BankoCheater
int[,] plate = new int[3, 5];
string inputText = "";
MakeBankoPlates("Hej", 1);
PrintPlates();
void MakeBankoPlates(string plateID, int plateAmount)
{
    Console.WriteLine();
    Console.WriteLine("How many plates do you have?");
    plateAmount = Convert.ToInt32(Console.ReadLine());

    for (int k = 0; k < plateAmount; k++)
    {
        Console.WriteLine($"Type in your {plateID} plate, row 1. Separate the numbers with ','");
        inputText = Console.ReadLine().Trim();
        string[] inputArray = inputText.Split(",");
        for (int i = 0; i < inputArray.Length; i++)
        {
            plate[0, i] = Convert.ToInt32(inputArray[i]);
        }

        Console.WriteLine($"Type in your {plateID} plate, row 2. Separate the numbers with ','");
        inputText = Console.ReadLine().Trim();
        inputArray = inputText.Split(",");
        for (int i = 0; i < inputArray.Length; i++)
        {
            plate[1, i] = Convert.ToInt32(inputArray[i]);
        }

        Console.WriteLine($"Type in your {plateID} plate, row 3. Separate the numbers with ','");
        inputText = Console.ReadLine().Trim();
        inputArray = inputText.Split(",");
        for (int i = 0; i < inputArray.Length; i++)
        {
            plate[2, i] = Convert.ToInt32(inputArray[i]);
        }
    }
}

//Console.WriteLine("Number drawn: ");
//int numbersDrawn= Convert.ToInt32(Console.ReadLine());
void PrintPlates()
{
    Console.WriteLine("Your plate: ");
    for (int i = 0; i < plate.GetLength(1); i++)
    {
        Console.Write(plate[0, i] + " ");
    }
    Console.WriteLine();
    for (int i = 0; i < plate.GetLength(1); i++)
    {
        Console.Write(plate[1, i] + " ");
    }
    Console.WriteLine();
    for (int i = 0; i < plate.GetLength(1); i++)
    {
        Console.Write(plate[2, i] + " ");
    }
}