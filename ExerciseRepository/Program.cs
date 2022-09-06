using System;

public class Program{
// See https://aka.ms/new-console-template for more information

private static void Main(string[] args){

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
}
}