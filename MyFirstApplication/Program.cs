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