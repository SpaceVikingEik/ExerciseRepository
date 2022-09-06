using System;

public class Program{
// See https://aka.ms/new-console-template for more information

private static void Main(string[] args){
Console.WriteLine("Enter Year:");

string yearString = Console.ReadLine();
int year = int.Parse(yearString);

Program HahaThisIsABadTemplate = new Program();

if (HahaThisIsABadTemplate.IsLeapYear(year)){
    Console.WriteLine("yaaaaaay :33333");
} else {
    Console.WriteLine("nayyyyyy 333333:");
}

}
public string HelloWorld(){
return "HelloWorld";
}

public bool IsLeapYear(int year){

    if(year % 4 == 0){
    if(year % 100 == 0 && year % 400 != 0) {
    return false;
    } else if (year % 100 == 0 && year % 400 == 0){
    return true;
    }
    return true;
    }

    return false;
    //Serious
}
}