// Build the Rock Paper Scissors Console Game in C#
// Note if your project is throwing a Swashbuckler error run this command to add a source to your files: dotnet nuget add source https://api.nuget.org/v3/index.json.
// Also if your project spins up but gives a security warning, run this line in your terminal: dotnet dev-certs https --trust.
// Both of these solutions will also fix the problem for future projects as well
// Suggestions
// Game Loop Create a loop that continues until the player decides to quit

// while(playing){

// Game Logic ...

//     string keepPlaying = Console.ReadLine();
//     if (keepPlaying == "rock")
//     {
//         playing = false;
//     }
// }
// User Input
// Start by asking the user input.
// The Play Method
// Creating a method named Play .
// This method will accept a string argument that represent the players choice: "rock" "paper" or "scissors".
// Inside the method create a variable and set it to a random choice for the computer.
// to start simple set the computerChoice equal to "rock".
// Determine a Winner!
// Add logic to Play that will determine who wins the game.
// This can be accomplished with a series of if() else if () statements but push yourself to use Dictionary for a more elegant solution.
// 💡 From a coding standpoint try solving the problem of a tie game before anything else.
// Once you get the logic figured out be sure to let the user know the result of the match by updating the user interface.
// Push yourself to keep track of wins, losses and ties and present this data in the UI
// HINT: You can use multiline and string interpolation to build your UI
// Console.Write(@"
// ******** ROCK PAPER SCISSORS ********            
// WINS: {wins}        LOSSES: {losses} 
// *************************************
// ")



// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
