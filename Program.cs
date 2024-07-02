// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

// namespace DataTypes;

// public class DataTypes{
//     static void Main(string[] args){
//         int myNum;
//         double myDoubleNum;
//         char myLetter;
//         bool myBool;
//         string myText;

//         myNum = 5;
//         myDoubleNum = 5.99D;
//         myLetter = 'A';
//         myBool = false;
//         myText = "AB";

//         Console.WriteLine(myNum);
//         Console.WriteLine(myDoubleNum);
//         Console.WriteLine(myLetter);
//         Console.WriteLine(myBool);
//         Console.WriteLine(myText);
//     }
// }

namespace Transaction;

public class Transaction{
    static void Main(string[] args){

        string martName;
        string product;
        float price;
        float sumOfMoney;
        //double total;
        float balance;

        martName = "Ada Mall";
        product= "Snickers";
        price =  1750.45F;
        sumOfMoney = 2000;
        balance = sumOfMoney-price;




    Console.WriteLine("Olumide got "+product+" from "+martName+ " @ N"+price +
    " and paid the sum of N"+sumOfMoney+", and was give a change of N"+balance);



    }
}
