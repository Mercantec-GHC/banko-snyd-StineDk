// BankoCheater
bool play = false;
bool oneRow = false;
bool twoRows = false;
bool fullPlate = false;
string input = "";
int count1 = 0;
int count2 = 0;
int[,] plate1 ={
    {21, 40, 61, 70, 81},
    {36, 57, 66, 77, 84},
    {5, 13, 29, 78, 87}
};
int[,] plate2 ={
    {21, 30, 56, 67, 83},
    {4, 14, 25, 43, 72},
    {17, 59, 69, 73, 90}
};

// Checkpoint the program goes back to.
Label:
// Write numbers drawn.
Console.WriteLine("Number Drawn: ");
input = Console.ReadLine().Trim();
int numberDrawn = int.Parse(input);
// Checks the number drawn.
if (numberDrawn >= 1 && numberDrawn <= 90)
{
    play = true;
}
// Cross Check the numberDrawn with the plates.
while (play == true)
{
    // Runs plate1.
    // Runs the length of the array lateral.
    for (int i = 0; i < plate1.GetLength(0); i++)
    {
        // runs the length of the array horizontal.
        for (int j = 0; j < plate1.GetLength(1); j++)
        {
            // Makes numberDrawn to 0.
            if (plate1[i, j] == numberDrawn)
            {
                plate1[i, j] = 0;
                // Method that checks if there is full plate bingo. 
                CheckFullPlate(plate1, 0, 1, 2);
                if (fullPlate)
                {
                    Console.WriteLine("plate1 is full.");
                }
                // Method checks if there is 2 row bingo.
                CheckTwoRows(plate1, 0, 1, 2);
                if (twoRows && !fullPlate && count1 == 0)
                {
                    Console.WriteLine("You have 2 rows on plate1.");
                    // So we only get this notification once.
                    count1++;
                }
                // Method checks if the is 1 row bingo.
                CheckOneRow(plate1, i);
                if (oneRow && !twoRows && !fullPlate)
                {
                    Console.WriteLine("You have 1 row on plate1.");

                }
            }
        }
    }
    // Runs plate2.
    for (int i = 0; i < plate2.GetLength(0); i++)
    {
        for (int j = 0; j < plate2.GetLength(1); j++)
        {
            if (plate2[i, j] == numberDrawn)
            {
                plate2[i, j] = 0;

                CheckFullPlate(plate2, 0, 1, 2);
                if (fullPlate)
                {
                    Console.WriteLine("plate2 is full.");
                }
                CheckTwoRows(plate2, 0, 1, 2);
                if (twoRows && !fullPlate && count2 == 0)
                {
                    Console.WriteLine("You have 2 rows on plate2.");
                    count2++;
                }
                CheckOneRow(plate2, i);
                if (oneRow && !twoRows && !fullPlate)
                {
                    Console.WriteLine("You have 1 row on plate2.");

                }
            }
        }
    }
    // Goes to checkpoint.
    goto Label;
}
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
    // All the values stored in the row 
    return oneRow = true;
}
bool CheckTwoRows(int[,] array, int row1, int row2, int row3)
{
    // Loop through the array length horizontal, and compares the values with 0.
    for (int i = 0; i < array.GetLength(1); i++)
    {
        if (array[row1, i] == array[row2, i])
        {
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
        if (array[row1, i] == array[row1, i])
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
    for (int i = 0; i < array.GetLength(1); i++)
    {
        if (array[row1, i] == array[row2, i])
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[row2, j] != array[row3, j])
                {
                    return fullPlate = false;
                }
            }
            return fullPlate = true;
        }
        if (array[row2, i] == array[row3, i])
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[row3, j] != array[row1, j])
                {
                    return fullPlate = false;
                }
            }
            return fullPlate = true;
        }
        if (array[row3, i] == array[row1, i])
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[row1, j] != array[row2, j])
                {
                    return fullPlate = false;
                }
            }
            return fullPlate = true;
        }
    }
    return fullPlate = false;
}