/*
 Teacher: AsherGhelich SeyedMohammadi
 Course Title: POLYVERSE
 Session: 3
 Session Title: C# Basic Programming
 Date: 2025-12-02
 GitHub: kakajan
*/


// This is a simple C# program that demonstrates basic console output and string manipulation.
Console.WriteLine("Hello, PolyVerse!");
Console.WriteLine("This is a sample C# program.");

// Declaring and initializing string variables
string greeting = "Welcome to the world of C# programming!";
// Outputting the greeting message to the console
Console.WriteLine(greeting);

// Demonstrating string concatenation and interpolation
string friendOneName = "   Beni   ";
string friendTwoName = "Arsam";

friendOneName = friendOneName.Trim();

// Console.WriteLine("My friends are" + friendOneName + "and" + friendTwoName + ".");
string friendsMessage = $"My friends are {friendOneName} and {friendTwoName}.";
Console.WriteLine(friendsMessage);
friendsMessage = friendsMessage.Replace("Arsam", "Asher");
Console.WriteLine(friendsMessage);