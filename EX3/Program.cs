int CreateArray(string message)
{
    Console.WriteLine("Введите элементы массива");
    int[] a = new int[8];
        for(int i = 0; i<8;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                
            }
    Console.WriteLine("\nМассив: {0}",String.Join(",",a));
    return 1;
}

int a = CreateArray("");
