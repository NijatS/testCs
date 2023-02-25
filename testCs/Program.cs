int[] numbers = new int[10];

Console.WriteLine("Please fill the array : ");
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = (int)Convert.ToInt32(Console.ReadLine());
}
int count1 = 0, count2 = 0, sum1 = 0, sum2 = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        count1++;
        sum1 += numbers[i];
    }
    else
    {
        count2++;
        sum2 += numbers[i];
    }
}
Console.WriteLine("Count of Odd Number : " + count1);
Console.WriteLine("Count of Even Number : " + count2);
Console.WriteLine("Sum of Odd Number : " + sum1);
Console.WriteLine("Sum of Even Number : " + sum2);

if(sum1 > sum2)
{
    Console.WriteLine("Sum of Odd Number more than other");
}
else
{
    Console.WriteLine("Sum of Even Number more than other");
}
