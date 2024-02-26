// BankoCheater
int[,] plate1 = new int[3, 5];
int[,] plate2 = new int[3, 5];
int[,] plate3 = new int[3, 5];
string inputText = "";

PrintPlates();

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

//Console.WriteLine("Number drawn: ");
//int numbersDrawn= Convert.ToInt32(Console.ReadLine());
void PrintPlates()
{
    Console.WriteLine("Your plate: ");
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
}