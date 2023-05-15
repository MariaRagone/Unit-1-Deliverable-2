// See https://aka.ms/new-console-template for more information
//Welcome the player to the game and ask their name
using System;
//ask the user their name
Console.WriteLine("Hello! Welcome to the COIN FLIP CHALLENGE!");
Console.WriteLine("What is your name?");

string name = Console.ReadLine();

//greet the user and ask if they want to play
Console.WriteLine($"Welcome {name}. Do you want to do the COIN FLIP CHALLENGE? Yes/No?");

string answer = Console.ReadLine();

//Starts the game if the user accepts the challenge
if (answer == "Yes")
{
    Console.WriteLine("Great let's begin.");
    int score = 0;

    //game plays for 5 rounds
    for (int round = 1; round <= 5; round++)
    {
        Console.Write($"Round {round}: Heads or Tails?");
        string guess = Console.ReadLine();

        /*program secretly pics a random number 0 or 1 and the program assigns 0 to "heads" 
         * otherwise the result is "tails". Can also use a ternary operator "string result = (randomValue == 0) ? "Heads" : "Tails";"*/
        Random randomNumber = new Random();
        int randomValue = randomNumber.Next(2);
        string result;
        if (randomValue == 0)
        { result = "Heads";
        }
        else { result = "Tails";
        }
        //checks if the guess is correct
        if (guess == result)
        {
            Console.WriteLine("You are correct! You get a point.");
            score++;
        }
        else
        {
            Console.WriteLine("Wrong!");
        }

    }
    // show the user their final score, if their score is less than 3 they lose, otherwise they win
    if (score < 3)
    {
        Console.Write($"{name}, your score is {score} out of 5. You LOSE!");
    }
    else
    {
        Console.Write($"Hey, {name}, your final score is {score} out of 5. You WIN!");
    }
}
//Ends the program if the user declined the challenge
else
{
    Console.WriteLine($"You are a coward {name}! I'm done with you, bye!");
}