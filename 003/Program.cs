// Поиск индекса заданного числа  с помощью методов и массивов
int[] array = {1,12,13,31,6,8,15,201};

int n = array.Length;
int find = 13;

int index = 0;

while(index<n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index+1;
    index++;
}


