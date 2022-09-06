using System;

public class Program{
// See https://aka.ms/new-console-template for more information

private static void Main(string[] args){
Program HahaThisIsABadTemplate = new Program();
int year = 0;
year = HahaThisIsABadTemplate.userInput();


if (HahaThisIsABadTemplate.IsLeapYear(year)){
    Console.WriteLine("yaaaaaay :33333");
} else {
    Console.WriteLine("nayyyyyy 333333:");
}

}
public string HelloWorld(){
return "HelloWorld";
}


public int userInput(){
Console.WriteLine("Enter Year:");
string yearString = Console.ReadLine();
try{
int year = int.Parse(yearString);
if(year < 1582){
    throw new Exception("Invalid Year");
}
return year;
} catch (Exception e){
    Console.WriteLine("Error, Please enter a valid year");
    userInput();
}
return 0;
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