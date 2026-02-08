// See https://aka.ms/new-console-template for more information
// Create an instance of Game.

using GuessingGame;
Game game = new Game();
int numberOfGuesses = 0;
string result = "";

// Game Started
Console.WriteLine("Hello Gamer!");
// asking Gamer name 
Console.WriteLine("What's your name Gamer");

string gamerName = Console.ReadLine()!;

Console.WriteLine($"Welcome {gamerName} to the Guessing Game!");

Console.WriteLine("I have a secret number between 1 and 15. Can you guess it?");
// Convert the input to an integer

while (result != "correct")
{
    Console.WriteLine(" Enter your guess:");
    string input = Console.ReadLine()!;

    // Validate the input to ensure it's a valid integer

    if (!int.TryParse(input, out int gamerGuessingNumber))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
        continue; // Skip the rest of the loop and prompt again
    }
    numberOfGuesses++;
    result = game.CheckGuess(gamerGuessingNumber);

    if (result == "low")
    {
        Console.WriteLine("Your guess is too low. Try again!");
    }
    else if (result == "high")
    {
        Console.WriteLine("Your guess is too high. Try again!");
    }    
}
    Console.WriteLine($"Congratulations {gamerName}! You've guessed the secret number in {numberOfGuesses} guesses!");



