using System;
try
{
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int r = a / b;
    Console.WriteLine(r);
}

catch (Exception e)
{
    Console.WriteLine("Occured error: "+e.Message);
}
finally
{
    Console.WriteLine("Executed finally block");
}