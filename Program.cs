// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("I am learning C#");

//Console.Write("I will print on the same line.");
//Console.WriteLine(29 + 37);

//string name = "Sourav";
//int val = 0 ;
//bool flag = true ; 
//Console.WriteLine(val);

//Console.WriteLine(Convert.ToString(flag) + flag);


// Taking Input
/*
    Console.Write("Enter your name: ");
    string myName = Console.ReadLine();
    Console.WriteLine("Your name is: " + myName);

    Console.WriteLine("Enter your age: ");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Your age is: " + age);

    Console.WriteLine("Press any key to continue...");
    ConsoleKeyInfo keyInfo = Console.ReadKey();
    Console.WriteLine($"\nYou pressed: {keyInfo.KeyChar}");
*/

/*
Console.WriteLine(5 % 3.2);
*/

/*
for(int i=1; i<=5; ++i) {
    Console.WriteLine(i + " : " + i * i);
}
*/

/*
string txt = "ABcDEfGHIJKlmnOPqRsTuVwXYz";
Console.WriteLine("The length of the txt string is: " + txt.Length);

Console.WriteLine(txt) ;
Console.WriteLine(txt.ToUpper()) ;
Console.WriteLine(txt.ToLower()) ;

string concatStr = string.Concat(s1, " ", s2, " ", s3) ;

Console.WriteLine(concatStr) ;
Console.WriteLine($"{s1} {s2} {s3} Roy.");
*/


string s1 = "Ammi", s2 = "Holam", s3 = "Sourav" ;

/*
Console.WriteLine(s1[2]);
Console.WriteLine(s1.IndexOf('n')) ; // -1
Console.WriteLine(s1.Substring(s1.IndexOf('A'), 3));

int day = 4;
switch (day)
{
    case 4:
        Console.WriteLine("Today is Saturday.");
        break;
    case 7:
        Console.WriteLine("Today is Sunday.");
        break;
    default:
        Console.WriteLine("Looking forward to the Weekend.");
        break;
}
*/

int[] arr = { 10, 12, 14, 16, 18 };

foreach (int ele in arr) {
    // Console.WriteLine(ele);
}

int[,] mat = { {7, 8, 9}, {3, 2, 1} };

int rows = mat.GetLength(0);    // 0 for the first dimension (rows)
int cols = mat.GetLength(1);    // 1 for the second dimension (columns)
Console.WriteLine("Rows: " + rows);   // Output: 2
Console.WriteLine("Columns: " + cols); // Output: 3

for (int i = 0; i < mat.GetLength(0); i++)
{
    for (int j = 0; j < mat.GetLength(1); j++)
    {
        Console.Write(mat[i, j] + " ");
    }
    Console.WriteLine("\n");
}
