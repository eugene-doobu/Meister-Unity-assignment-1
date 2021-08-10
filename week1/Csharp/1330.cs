using System;

public class 1330{
    public static void Main(){
        string str = Console.ReadLine();
        string[] s = str.Split(' ');
        
        int a = Int32.Parse(s[0]);
        int b = Int32.Parse(s[1]);
        
        if (a > b){
            Console.WriteLine(">");
        }
        else if (a < b){
            Console.WriteLine("<");
        }
        else if (a == b){
            Console.WriteLine("==");
        }
    }
}