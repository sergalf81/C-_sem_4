System.Console.Write("Inpet number a: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input number b: ");
int b = Convert.ToInt32(Console.ReadLine());
int n = a;
for(int i = 1; i < b; i++)
{
    n = n * a;
}
System.Console.WriteLine(n);