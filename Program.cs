internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        var playAgain = true;

        while (playAgain)
        {
            var playerChoice = setPlayerRound();
            var computerChoice = setComputerRound(random);

            Console.WriteLine($"Player : {playerChoice}");
            Console.WriteLine($"Computer : {computerChoice}");

            winDetector(playerChoice , computerChoice);

            playAgain = confirmPlayAgain();  
        }
        Console.WriteLine("Thanks for playing ^-^");
        
    }

    static string setComputerRound(Random random)
    {
        switch(random.Next(1 , 4))
        {
            case 1 :
                return "ROCK";
            case 2 :
                return "PAPER";
            case 3 :
                return "SCISSORS";
            default :
                return "";
        }
    }

    static string setPlayerRound()
    {
        var playerChoice = "";
        while(playerChoice != "ROCK" && playerChoice!= "PAPER" && playerChoice != "SCOSSORS")
        {
        Console.WriteLine("Enter ROCK , PAPER or SCISSORS : ");
        playerChoice = Console.ReadLine();

        playerChoice = playerChoice.ToUpper();
        }

        return playerChoice; 
    }


    static void winDetector(string playerChoice , string computerChoice)
    {
        switch(playerChoice)
        {
            case "ROCK" : 
                if(computerChoice == "ROCK")
                {
                    Console.WriteLine("It's a draw !!");
                    
                }else if (computerChoice == "PAPER")
                { 
                    Console.WriteLine("You lose !!");
                }else {
                    Console.WriteLine("You win !!");
                    
                }
                break;
            case "PAPER" :
                if (computerChoice == "PAPER")
                {
                    Console.WriteLine("I'ts a draw !!");

                    
                }else if (computerChoice == "SCISSORS")
                {
                    Console.WriteLine("You lose !!");
                    
                }else{
                    Console.WriteLine("You win !!");
                    
                }
                break;
            case "SCISSORS" :
                if (computerChoice == "Scissors")
                {
                    Console.WriteLine("I'ts a draw !!");
                }else if (computerChoice == "ROCK")
                {
                    Console.WriteLine("You lose !!");
                }else {
                    Console.WriteLine("You win");
                }
                break;
        }
    }

    static bool confirmPlayAgain()
    {
        Console.WriteLine("Would you like to play again ? Y / N");
        var inputAnswer = Console.ReadLine();
        bool playAgain = inputAnswer.ToUpper() == "Y";

        return playAgain;
    } 
}