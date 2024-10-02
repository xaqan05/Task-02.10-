int number = 255;
int result = 1;
while (number != 0)
{
    result *= number % 10;
    number /= 10;
}
Console.WriteLine(result);