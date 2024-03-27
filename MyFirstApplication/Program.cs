using MyFirstApplication;

// See https://aka.ms/new-console-template for more information
using MyFirstApplication;

// The statement below calls a local function
// single line comment
Console.WriteLine("Hello, World!");

/*
 Multi-line comment
 The below statement is a local function. Local functions
 are inside members and are private by default. This means
 They are specific to that member and can only be called
 inside that memeber.
 */
 HouseExample();

void HouseExample()
{
    House myHouse = new House();
    myHouse.DoorOpenClose();

}

// This local function is for my first exercise lab.//

void MyLocalFuntion()
{
    Console.WriteLine("This is my first sentence");
    Console.WriteLine("I am new to CSharp");
    Console.WriteLine("This CSharp course is cool");
    Console.WriteLine("I am learning stuff every day.");

}