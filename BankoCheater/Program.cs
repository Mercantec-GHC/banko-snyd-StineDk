// BankoCheater

bool oneRow = false;
bool twoRows = false;
bool fullPlate = false;
string drawHistory = "";
int numberDrawn = 0;
int bingoCount = 0;
int countPlate1 = 0;
int countPlate2 = 0;
int countPlate3 = 0;
int countPlate4 = 0;
int countPlate5 = 0;
int[,] STB_1 ={
    {1, 11, 20, 64, 81},
    {5, 23, 42, 57, 76},
    {15, 26, 34, 59, 67}
};
int[,] STB_2 ={
    {4, 30, 41, 50, 85},
    {6, 14, 51, 73, 87},
    {29, 48, 67, 74, 90}
};
int[,] STB_3 ={
    {10, 35, 51, 64, 70},
    {6, 44, 65, 77, 85},
    {29, 39, 69, 78, 89}
};
int[,] STB_4 ={
    {23, 31, 45, 60, 83},
    {14, 27, 36, 47, 55},
    {9, 16, 49, 67, 77}
};
int[,] STB_5 ={
    {2, 10, 42, 52, 60},
    {16, 33, 54, 63, 77},
    {18, 29, 66, 78, 88}
};
// Checkpoint the program goes back to.
Label:
Console.Clear();
Console.WriteLine(drawHistory);
Console.Write("Number Drawn: ");
string input = Console.ReadLine().Trim();
drawHistory = drawHistory + "--" + input;
// Try, attempt to do what is inside the block, if it can't go to catch.
try
{
    // Converts a string variable to an int variable.
    numberDrawn = int.Parse(input);
}
// Catches the format exception, AKA if the conversion is unsuccessful go here. 
catch (FormatException)
{
    // go to check point.
    goto Label;
}
// Cross Checks the numberDrawn with the plates.
while (numberDrawn >= 1 && numberDrawn <= 90)
{
    // Runs STB_1.
    // Runs the length of the array lateral.
    for (int i = 0; i < STB_1.GetLength(0); i++)
    {
        // runs the length of the array horizontal.
        for (int j = 0; j < STB_1.GetLength(1); j++)
        {
            // Makes numberDrawn to 0.
            if (STB_1[i, j] == numberDrawn)
            {
                STB_1[i, j] = 0;
                // Method that checks if there is full plate bingo. 
                CheckFullPlate(STB_1, 0, 1, 2);
                if (fullPlate)
                {
                    Console.WriteLine("STB_1 is full.");
                    // So I can se the result, before the screen is cleared.
                    Console.Write("Press Enter to continue.");
                    Console.ReadLine();
                }
                // Method checks if there is 2 row bingo.
                CheckTwoRows(STB_1, 0, 1, 2);
                if (twoRows && !fullPlate && countPlate1 == 0 && bingoCount == 1)
                {
                    Console.WriteLine("You have 2 rows on STB_1.");
                    Console.Write("Press Enter to continue.");
                    Console.ReadLine();
                    // So I only get this notification once.
                    countPlate1++;
                    bingoCount++;
                }
                // Method checks if the is 1 row bingo.
                CheckOneRow(STB_1, i);
                if (oneRow && !twoRows && !fullPlate && bingoCount == 0)
                {
                    Console.WriteLine($"You have 1 row on STB_1.\nRow: {i+1}");
                    Console.Write("Press Enter to continue.");
                    Console.ReadLine();
                    bingoCount++;
                }
            }
        }
    }
    // Runs STB_2
    for (int i = 0; i < STB_2.GetLength(0); i++)
    {
        for (int j = 0; j < STB_2.GetLength(1); j++)
        {
            if (STB_2[i, j] == numberDrawn)
            {
                STB_2[i, j] = 0;
                CheckFullPlate(STB_2, 0, 1, 2);
                if (fullPlate)
                {
                    Console.WriteLine("STB_2 is full.");
                    Console.Write("Press Enter to continue.");
                    Console.ReadLine();
                }
                CheckTwoRows(STB_2, 0, 1, 2);
                if (twoRows && !fullPlate && countPlate2 == 0 && bingoCount == 0)
                {
                    Console.WriteLine("You have 2 rows on STB_2.");
                    Console.Write("Press Enter to continue.");
                    Console.ReadLine();
                    countPlate2++;
                    bingoCount++;
                }
                CheckOneRow(STB_2, i);
                if (oneRow && !twoRows && !fullPlate && bingoCount == 0)
                {
                    Console.WriteLine($"You have 1 row on STB_2.\nRow: {i+1}");
                    Console.Write("Press Enter to continue.");
                    Console.ReadLine();
                    bingoCount++;
                }
            }
        }
    }
    // Runs STB_3.
    for (int i = 0; i < STB_3.GetLength(0); i++)
    {
        for (int j = 0; j < STB_3.GetLength(1); j++)
        {
            if (STB_3[i, j] == numberDrawn)
            {
                STB_3[i, j] = 0;
                CheckFullPlate(STB_3, 0, 1, 2);
                if (fullPlate)
                {
                    Console.WriteLine("STB_3 is full.");
                    Console.Write("Press Enter to continue.");
                    Console.ReadLine();
                }
                CheckTwoRows(STB_3, 0, 1, 2);
                if (twoRows && !fullPlate && countPlate3 == 0 && bingoCount == 1)
                {
                    Console.WriteLine("You have 2 rows on STB_3.");
                    Console.Write("Press Enter to continue.");
                    Console.ReadLine();
                    countPlate3++;
                    bingoCount++;
                }
                CheckOneRow(STB_3, i);
                if (oneRow && !twoRows && !fullPlate && bingoCount == 0)
                {
                    Console.WriteLine($"You have 1 row on STB_3.\nRow: {i+1}");
                    Console.Write("Press Enter to continue.");
                    Console.ReadLine();
                    bingoCount++;
                }
            }
        }
    }
    // Runs STB_4.
    for (int i = 0; i < STB_4.GetLength(0); i++)
    {
        for (int j = 0; j < STB_4.GetLength(1); j++)
        {
            if (STB_4[i, j] == numberDrawn)
            {
                STB_4[i, j] = 0;
                CheckFullPlate(STB_4, 0, 1, 2);
                if (fullPlate)
                {
                    Console.WriteLine("STB_4 is full.");
                    Console.Write("Press Enter to continue.");
                    Console.ReadLine();
                }
                CheckTwoRows(STB_4, 0, 1, 2);
                if (twoRows && !fullPlate && countPlate4 == 0 && bingoCount == 1)
                {
                    Console.WriteLine("You have 2 rows on STB_4.");
                    Console.Write("Press Enter to continue.");
                    Console.ReadLine();
                    countPlate4++;
                    bingoCount++;
                }
                CheckOneRow(STB_4, i);
                if (oneRow && !twoRows && !fullPlate && bingoCount == 0)
                {
                    Console.WriteLine($"You have 1 row on STB_4.\nRow: {i + 1}");
                    Console.Write("Press Enter to continue.");
                    Console.ReadLine();
                    bingoCount++;
                }
            }
        }
    }
    // Runs STB_5.
    for (int i = 0; i < STB_5.GetLength(0); i++)
    {
        for (int j = 0; j < STB_5.GetLength(1); j++)
        {
            if (STB_5[i, j] == numberDrawn)
            {
                STB_5[i, j] = 0;
                CheckFullPlate(STB_5, 0, 1, 2);
                if (fullPlate)
                {
                    Console.WriteLine("STB_5 is full.");
                    Console.Write("Press Enter to continue.");
                    Console.ReadLine();
                }
                CheckTwoRows(STB_5, 0, 1, 2);
                if (twoRows && !fullPlate && countPlate2 == 0 && bingoCount == 0)
                {
                    Console.WriteLine("You have 2 rows on STB_5.");
                    Console.Write("Press Enter to continue.");
                    Console.ReadLine();
                    countPlate5++;
                    bingoCount++;
                }
                CheckOneRow(STB_5, i);
                if (oneRow && !twoRows && !fullPlate && bingoCount == 0)
                {
                    Console.WriteLine($"You have 1 row on STB_5.\nRow: {i + 1}");
                    Console.Write("Press Enter to continue.");
                    Console.ReadLine();
                    bingoCount++;
                }
            }
        }
    }
    goto Label;
}
goto Label;
bool CheckOneRow(int[,] array, int row)
{
    // Loop through the array length horizontal, and compares the values stored with 0.
    for (int i = 0; i < array.GetLength(1); i++)
    {
        if (array[row, i] != 0)
        {
            return oneRow = false;
        }
    }
    // All the values stored in the row equals 0, return true.
    return oneRow = true;
}
bool CheckTwoRows(int[,] array, int row1, int row2, int row3)
{
    // Loop through the array length horizontal, and compares the values with 0.
    for (int i = 0; i < array.GetLength(1); i++)
    {
        if (array[row1, i] == array[row2, i])
        {
            // Loop through the array length horizontal, a second time to check if all the numbers in both rows are the samme.
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[row1, j] != array[row2, j])
                {
                    return twoRows = false;
                }
            }
            return twoRows = true;
        }
        if (array[row2, i] == array[row3, i])
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[row2, j] != array[row3, j])
                {
                    return twoRows = false;
                }
            }
            return twoRows = true;
        }
        if (array[row3, i] == array[row1, i])
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[row3, j] != array[row1, j])
                {
                    return twoRows = false;
                }
            }
            return twoRows = true;
        }
    }
    // If the values in two rows aren't the samme, return false.
    return twoRows = false; ;
}
bool CheckFullPlate(int[,] array, int row1, int row2, int row3)
{
    // Loop through the array length horizontal, and compares the values to 0.
    for (int i = 0; i < array.GetLength(1); i++)
    {
        if (array[row1, i] == array[row2, i])
        {
            // Loop through array length horizontal, a second time to se if all of the last row matches the other 2 rows.
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[row2, j] != array[row3, j])
                {
                    return fullPlate = false;
                }
            }
            return fullPlate = true;
        }
    }
    // If all 3 rows don't match, return false.
    return fullPlate = false;
}