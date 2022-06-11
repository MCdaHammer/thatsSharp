namespace Questions
{
    class Program
    {
        static void Main(string[] args)
        {


            int questionsCount = 0;
            string[] questions = new string[] 
            {         //ASK THE QUESTIONS BY THEIR ID IN THE ARRAY BASED ON YES/NO
                "1Does it live on land?",
                "2Does it live on water?",
                "3Does it live in Africa?",
                "4Does it live in Asia?",
                "5Does it live in Europe?",
                "6Does it live in North America?",
                "7Does it live in South America?",
                "8Does it live in Australia?",
                "9Does it live in Antarctica?",
                "0Does it live in the Arctic?",
                "1Does it fly?",
                "2Does it have a backbone?",
                "3Is it a mammal?",
                "4Does it have feathers?",
                "5Does it walk on four legs?",
                "6Does it have a tail?",
                "7Does it live in the wild?",
                "8Does it hunt in packs?",
                "9Does it frequent trees?",
                "0Does it live in the desert?",
                "1Does it live in the rainforest?",
                "2Does it live in the mountains?",
                "3Does it live in the tundra?",
                "4Does it live in the jungle?",
                "5Are there numerous species of it?",
                "6Do they vary in size?",
                "7Have they been domesticated?",
                "8Are they considered to be endangered?",
                "9Are they considered to be nocturnal?",
                "0Are they considered to be omnivorous?",
                "1Are they considered to be carnivorous?",
                "2Does it live in the Pacific?",
                "3Does it live in the Atlantic?",
                "4Does it live in the Indian Ocean?",
                "5Does it live in the Arctic Ocean?",
                "6Does it live in the Southern Ocean?",
                "7Does it live in freshwater?",
                "8Does it eat fish?",
                "9Does it eat plankton?",
                "0Does it eat coral?",
                "1Does it eat seaweed?",
                "2Does it eat algae?"
                }; 
             while (questionsCount < 21)
            {
                Console.WriteLine("I bet that I can guess the animal that you're thinking of in 20 questions or less!");
                Console.WriteLine("Would you like to play?");
                
                string ? answer = Console.ReadLine();
                if (answer == "yes" || answer == "Yes")
                {
                    Console.WriteLine($"Question: {questionsCount}", questions[0]);
                    questionsCount++;

                    string ? answer1 = Console.ReadLine();
                    if (answer1 == "yes" || answer1 == "Yes")
                    {
                        Console.WriteLine($"Question: {questionsCount}", questions[2]);
                        questionsCount++;
                        string ? answer2 = Console.ReadLine();
                        if (answer2 == "yes" || answer2 == "Yes")
                        {
                            Console.WriteLine($"Question: {questionsCount}", questions[3]);
                            questionsCount++;
                            string ? answer3 = Console.ReadLine();
                        }
                        else if(answer2 == "no" || answer2 == "No")
                        {
                            Console.WriteLine($"Question: {questionsCount}", questions[4]);
                            questionsCount++;
                            string ? answer4 = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Please enter yes or no to proceed.");
                            questionsCount--;
                        }
                    }
                    else if (answer1 == "no" || answer1 == "No")
                    {
                        Console.WriteLine($"Question: {questionsCount}", questions[1]);
                        string ? answer2 = Console.ReadLine();
                        questionsCount++;
                    }
                    else
                    {
                        Console.WriteLine("Please enter yes or no to proceed.");
                        questionsCount--;
                    }
                }

                else if (answer == "no" || answer == "No")
                {
                    Console.WriteLine("Have a great day!");
                }
            
                else
                {
                    Console.WriteLine("Please enter yes or no");
                }
            }

            if (questionsCount == 21)
            {
                Console.WriteLine("That was fun!", "Would you like to play again?");
                string ? playAgain = Console.ReadLine();
                if (playAgain == "yes" || playAgain == "Yes")
                {
                    questionsCount = 0;
                }
                else
                {
                    Console.WriteLine("Thanks for playing!");
                }
            }
        }
    }
}