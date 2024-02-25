string[] array1 = new string[4] { "Hello", "2", "world", ":-)" };
string[] array2 = new string[array1.Length];
FillSecondArray(array1, array2);
PrintArrayContents(array2);

void FillSecondArray(string[] array1, string[] array2)
    {
        int count = 0;
        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i].Length <= 3)
            {
                array2[count] = array1[i];
                count++;
            }
        }
    }

    void PrintArrayContents(string[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != null)
                Console.Write($"\"{array[i]}\"");
            if (i < array.Length - 1 && array[i + 1] != null)
                Console.Write(" ");
        }
        Console.WriteLine("]");
    }