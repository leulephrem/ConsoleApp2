// See https://aka.ms/new-console-template for more information

using System;


int countDigit(int n,int digit)
{
    int count = 0;
    int retval = 0;
    int rem = 0;

    if(n<=0 || digit < 0)
    {
        retval = -1;
    }
    else
    {
        while (n != 0)
        {
            rem = n % 10;
            n= n / 10;
            if (rem == digit)
            {
                count++;
            }
        }
        retval = count;
    }
    return retval;
}

Console.WriteLine("Enter the number");

int y = Convert.ToInt32(Console.ReadLine());




Console.WriteLine("Enter the digit");

int z = Convert.ToInt32(Console.ReadLine());




int k = countDigit(y, z);

Console.WriteLine("The number of times " + z + " is found : " + k);