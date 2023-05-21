int [] array = {1,2,3,4,6,4,9,8,51,565,66};

int n = array.Length;
int find = 4;

int index = 0;

while (index<n)
{
    if(array[index] == find)
    {
        System.Console.Write(index);
        break;
    }
    index++;
}