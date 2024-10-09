using System;

class Test
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        byte a = 1;
        byte b = 2;
        System.Console.WriteLine((byte)(a + b)); // Cast the result to byte

        // Jagged Array example
        int[][] arr = new int[3][];

        arr[0] = new int[5] { 4, 2, 2, 15, 3 };
        arr[1] = new int[2] { 2, 3 };
        arr[2] = new int[3] { 2, 3, 4 };

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                System.Console.Write(arr[i][j] + " ");
            }
            System.Console.WriteLine();
        }

        //int[][] aaa = new int[2][] { { 2, 3, 4, 5, 3 }, { 2, 3, 4, } };//this is wrong way to declare the jagged array onyl multidimensional arrya can be declared by this method


        //For Each Loop
        String[] str = { "Haldwani", "Nainital", "Bhimtal" };

        foreach(String city in str)
        {
            Console.WriteLine(city);
        }

        Stack<String> s1=new Stack<String>();
        Stack<int> s2=new Stack<int>();

        s1.Push("Hello");
        s1.Push("Hi");
        s1.Push("JJ");

        foreach (var item in s1)
        {
            Console.WriteLine(item);   
        }

        s1.Pop();
        s1.Pop();

        foreach(String sk in s1)
        {
            Console.WriteLine(sk);
        }



        //fibonaci series

        int num = Convert.ToInt32( Console.ReadLine());
        int first = 0, second = 1,next;

        if (num <= 0)
        {
            Console.WriteLine("The number cant be negative or zero"); ;

        }
        else if (num == 1)
        {
            Console.Write($"{second}");
        }
        else
        {
            Console.Write($"{first} {second}");

            for (int i = 2; i < num; i++)
            {
                next = first + second;
                Console.Write(next);
                first = second;
                second = next;
            }
        }
    }
}

