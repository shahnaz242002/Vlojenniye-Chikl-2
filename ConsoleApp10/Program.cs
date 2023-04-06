int start = Convert.ToInt32(Console.ReadLine());
int end = Convert.ToInt32(Console.ReadLine());
for(int i = start;i<= end;i++)
{
    int count = 0;
 for(int j =2;j<i;j++)
    {
        if (i%j == 0)
        {
            count++;
        }
    }
 if(count ==0)
    {
        Console.WriteLine(i);
    }
}