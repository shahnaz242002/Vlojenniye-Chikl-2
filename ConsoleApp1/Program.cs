int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
int f = firstNumber;
int issame = 0;
while(secondNumber!=0)
{
    int d = secondNumber % 10;
    firstNumber = f;
    while(firstNumber!=0)
    {
        int tmp = firstNumber % 10;
        if(tmp == d)
        {
            issame = 1;
        }
    firstNumber/= 10;
    }
    secondNumber /= 10;
}
if(issame==1)
{
    Console.WriteLine("DA");
}
else 
{
    Console.WriteLine("NET");
}
