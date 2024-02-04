void Task1(int start, int end)
{
    if (start>end) 
    {
        Console.Write(" ");
        return;
    }
    else if (start==end){
        Console.Write(start+" ");
        return;
    }
    Console.Write(start+" ");
    Task1(start+1,end);
}
int Task2(int n, int m)
{
    if (n==0) return m+1;
    else if (m==0) return Task2(n-1, 1);
    else{
        return Task2(n - 1, Task2(n, m - 1));
    }
}
void Task3(int[] array, int index)
{
    if (index==0){
        Console.Write(array[0]+" ");
        return;
    }
    Console.Write(array[index]+" ");
    Task3(array,index-1);
}
int[] CreateArray(int lenght,int down,int up)
{
    Random rnd = new Random();
    int[] array = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        array[i] = rnd.Next(down,up+1);
    }
    return array;
}
Task1(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));
Console.WriteLine(' ');
Console.WriteLine("Во второй задаче СНАЧАЛО ВВОДИТСЯ N, ПОТОМ M!");
Console.WriteLine(Task2(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine())));
Console.WriteLine(' ');
int[] array = CreateArray(10,0,10);
Console.WriteLine(string.Join(' ', array));
Console.WriteLine(' ');
Task3(array,array.Length-1);
