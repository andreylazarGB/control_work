// 

string[] array = { "hello", "2", "world", ";)" };

void GetArray(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        char[] arr = Array[i].ToCharArray();
        for (int j = 0; j < arr.Length; j++)
        {
            int size = 3;
            if (arr.Length <= size)
            {
                //Array[i] = Array[0];
                //Console.WriteLine($"{Array[i]}");
                //Console.Write(arr[j]+" | ");
            }
            Console.WriteLine($"{String.Join(Array)}");
        }
        //Console.WriteLine($"{arr}");
    }
    //Console.WriteLine(Array);
}

GetArray(array);