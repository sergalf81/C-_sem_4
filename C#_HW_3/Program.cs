int[] Array = new int[8];
for(int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(1,20);
    System.Console.WriteLine(Array[i]);
}
