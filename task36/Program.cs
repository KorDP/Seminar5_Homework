﻿int[] array = {2, 6, 4, 8, 9, 4, 3, 7, 12, 6, 3, 5};

int OddIndexSum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}

int oddSum = OddIndexSum(array);
Console.WriteLine(oddSum);