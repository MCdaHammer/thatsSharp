using System;
namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int heroHP = 100;
            int bossHP = 120;

            int [] dices = new int [] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int [] heals = new int [] {4, 6, 8};
            int [] mageHeals = new int [] {5, 7, 9};

            int [] fireballs = new int [] {10, 11, 12};
            int [] frostbolts = new int [] {6, 7, 8};
            int [] whacks = new int [] {2, 3, 4};

            int [] slices = new int [] {8, 9, 10};
            int [] bashes = new int [] {3, 4, 5};
            int [] battleCrys = new int [] {1, 2, 3};

            int [] shootArrows = new int [] {7, 8, 9};
            int [] volleys = new int [] {3, 4, 5};

            int smite = 125;
            
            int money = 4;

            int [] swipes = new int [] {5, 6, 7};
            int [] bites = new int [] {8, 9, 10};
            
            

            Random randDices = new Random ();
            Random randHeals = new Random();
            Random randMageHeals = new Random();
            Random randFireballs = new Random();
            Random randFrostbolts = new Random();
            Random randWhacks = new Random();
            Random randSlices = new Random();
            Random randBashes = new Random();
            Random randBattleCrys = new Random();
            Random randShootArrows = new Random();
            Random randVolleys = new Random();
            Random randSwipes = new Random();
            Random randBites = new Random();

            int randDice = randDices.Next(0, dices.Length);
            int randHeal = randHeals.Next(0, 3);
            int randMageHeal = randMageHeals.Next(0, 3);
            int randFireball = randFireballs.Next(0, 3);
            int randFrostbolt = randFrostbolts.Next(0, 3);
            int randWhack = randWhacks.Next(0, 3);
            int randSlice = randSlices.Next(0, 3);
            int randBash = randBashes.Next(0, 3);
            int randBattleCry = randBattleCrys.Next(0, 3);
            int randShootArrow = randShootArrows.Next(0, 3);
            int randVolley = randVolleys.Next(0, 3);
            int randSwipe = randSwipes.Next(0, 3);
            int randBite = randBites.Next(0, 3);
            do 
            {
                Console.WriteLine("You stir awake; conscious at last. It's dark. You can't see much of anything.");
                Console.WriteLine("In the distance you hear a faint *drip* every other second or so. Somehow you've ended up in a cave.");
                Console.WriteLine("You feel the weight of your _______ against your back. (Staff, Sword, or Bow)");
                string ? heroClass = Console.ReadLine();
            
                if (heroClass == "Staff" || heroClass == "staff")
                {
                    Console.WriteLine("Ah yes. You remember now. You're a mage and have knowledge of frost and fire.");
                    Console.WriteLine("As the fog in your mind dissipates, you begin to remember your training. Fireball, Frostbolt, and a good, old-fashioned Whack with your staff.");
                    System.Threading.Thread.Sleep(3000);
                    Console.WriteLine("Let's see just how much you remember. Arise and venture forth!");
                        do
                        {
                            Console.WriteLine($"In front of you is a beast with {bossHP} Health. You're currently sitting at {heroHP} Health.");
                            Console.WriteLine("What do you do? (Heal, Fireball, Frostbolt, or Whack with your staff)");
                            string ? mageAttack = Console.ReadLine();
                            if (mageAttack == "Heal" || mageAttack == "heal")
                            {
                                heroHP += randMageHeal;
                                Console.WriteLine($"You heal yourself for {mageHeals[randMageHeal]} Health.");
                                System.Threading.Thread.Sleep(3000);
                                if (randDice >= 5)
                                {
                                Console.WriteLine($"The beast swipes at you for {swipes[randSwipe]} damage.");
                                heroHP -= randSwipe;
                                }
                                else if (randDice < 5)
                                {
                                Console.WriteLine($"The beast bites you for {bites[randBite]} damage.");
                                heroHP -= randBite;
                                }
                                else if (randDice == 0)
                                {
                                Console.WriteLine($"The beast lunges at you and misses.");
                                }
                            }
                            else if (mageAttack == "Fireball" || mageAttack == "fireball")
                            {
                                bossHP -= randFireball;
                                Console.WriteLine($"The beast takes {fireballs[randFireball]} damage.");
                                if (randDice >= 5)
                                {
                                Console.WriteLine($"The beast swipes at you for {swipes[randSwipe]} damage.");
                                heroHP -= randSwipe;
                                }
                                else if (randDice < 5)
                                {
                                Console.WriteLine($"The beast bites you for {bites[randBite]} damage.");
                                heroHP -= randBite;
                                }
                                else if (randDice == 0)
                                {
                                Console.WriteLine($"The beast lunges at you and misses.");
                                }
                            }
                            else if (mageAttack == "Frostbolt" || mageAttack == "frostbolt")
                            {
                                bossHP -= randFrostbolt;
                                Console.WriteLine($"The beast takes {frostbolts[randFrostbolt]} damage.");
                                System.Threading.Thread.Sleep(3000);
                                if (randDice >= 5)
                                {
                                    heroHP -= randSwipe;
                                Console.WriteLine($"The beast swipes at you for {swipes[randSwipe]} damage.");
                                }
                                else if (randDice < 5)
                                {
                                    heroHP -= randBite;
                                Console.WriteLine($"The beast bites you for {bites[randBite]} damage.");
                                
                                }
                                else if (randDice == 0)
                                {
                                Console.WriteLine($"The beast lunges at you and misses.");
                                }
                            }
                            else if (mageAttack == "Whack" || mageAttack == "whack")
                            {
                                bossHP -= randWhack;
                                Console.WriteLine($"The beast takes {whacks[randWhack]} damage.");
                                System.Threading.Thread.Sleep(3000);
                                Console.WriteLine("The beast looks at you. What did you hope to accomplish?");
                                System.Threading.Thread.Sleep(3000);
                                Console.WriteLine("The beast, annoyed, let's out a deep breath. It's going to be a long day.");
                                System.Threading.Thread.Sleep(2000);
                                Console.WriteLine("The beast swats at you, like a bug. The big, meaty paw knocks you against the wall.");
                                heroHP -= 80;
                                System.Threading.Thread.Sleep(3000);
                                Console.WriteLine($"That hurt. You now have {heroHP}. I will let you live on one condition. Would you like to hear it?");
                                string ? thisAnswer = Console.ReadLine();
                                if (thisAnswer == "yes" || thisAnswer == "Yes")
                                {
                                    Console.WriteLine("The beast says: My daughter is actually having a fundraiser and it would mean the world to her to win.");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Would you mind helping us? I'll let you live and you would be doing a good thing for a little girl.");
                                    System.Threading.Thread.Sleep(3000);
                                    Console.WriteLine("You start to notice the beast isn't so horrific after all. He is starting to resemble a humanoid-type creature.");
                                    System.Threading.Thread.Sleep(2000);
                                    Console.WriteLine("Would you please donate to her? She doesn't need much, after all? (howmuch or no)");
                                    System.Threading.Thread.Sleep(2000);
                                    string ? thatAnswer = Console.ReadLine();
                                    if (thatAnswer == "howmuch" || thatAnswer == "Howmuch")
                                    {
                                        Console.WriteLine("Oh not alot. I.... I just need about tree-fiddy.");
                                        System.Threading.Thread.Sleep(1000);
                                        Console.WriteLine("It's at about that time that you realize that this isn't a humanoid creature at all.");
                                        System.Threading.Thread.Sleep(1000);
                                        Console.WriteLine("It's a 20-story tall crustacean from the Paleozoic era. Some also know it as the Loch Ness Monster.");
                                        bossHP += 100;
                                        System.Threading.Thread.Sleep(1000);
                                        Console.WriteLine("Will you donate the $3.50?");
                                        string ? whatAnswer = Console.ReadLine();
                                        if (whatAnswer == "yes" || whatAnswer == "Yes")
                                        {
                                            Console.WriteLine("Well no wonder he keeps coming back; seeing as how you keep giving him tree-fiddy!");
                                            money -= 4;
                                            System.Threading.Thread.Sleep(1000);
                                        }
                                        else if (whatAnswer == "no" || whatAnswer == "No")
                                        {
                                            heroHP -= randSwipe * 3;
                                            Console.WriteLine($"For not giving him tree-fiddy. He's not happy and swipes you for {swipes[randSwipe*3]}");
                                            System.Threading.Thread.Sleep(1000);
                                        }
                                        else 
                                        {
                                            Console.WriteLine("Please enter yes or no.");
                                            System.Threading.Thread.Sleep(1000);
                                        }
                                    }
                                    else if (thatAnswer == "no" || thatAnswer == "No")
                                    {
                                            Console.WriteLine("Well, I guess it looks like you're the REAL monster, here. You had this coming!");
                                            System.Threading.Thread.Sleep(1000);
                                            Console.WriteLine("The beast rushes you and stomps you into the ground.");
                                            heroHP -= 500;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter howmuch or no.");
                                        System.Threading.Thread.Sleep(1000);
                                    }

                                    }
                                else if (thisAnswer == "no" || thisAnswer == "No")
                                {
                                    Console.WriteLine("So be it. *The last thing you see is a giant boulder flying at your face.*");
                                    System.Threading.Thread.Sleep(1000);
                                    heroHP -= 500;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter yes or no.");
                                    System.Threading.Thread.Sleep(1000);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid ability.");
                            }
                        
                            if (bossHP <= 0)
                            {
                                Console.WriteLine("Congratulations! You have defeated the beast. Sadly, your princess lies within another cave. You must find her.");
                                System.Threading.Thread.Sleep(3000);
                                Console.WriteLine("Would you like to play again?");
                                string ? playAgain = Console.ReadLine();
                                if (playAgain == "yes" || playAgain == "Yes")
                                {
                                    bossHP = 100;
                                    heroHP = 100;
                                    money = 4;
                                }
                                else
                                {
                                    Console.WriteLine("Goodbye!");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Have a great day!");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("Press any key to exit.");
                                }
                            }
                            else if (heroHP <= 0)
                            {
                                Console.WriteLine("You can see blood begin to flow past you on the floor as everything fades to black.");
                                System.Threading.Thread.Sleep(2000);
                                Console.WriteLine("Better luck next time.");
                            }
                    
                    }
                    while (bossHP > 0 && heroHP > 0 && money > 0);
                }
                else if (heroClass == "Sword" || heroClass == "sword")
                {
                    Console.WriteLine("You reach back and grab your sword. 1000 lives it's taken. Each more fierce than the last. It yearns for 1000 more.");
                    Console.WriteLine("You can almost feel the sword whispering, *slash, bash, battlecry*.");
                    System.Threading.Thread.Sleep(3000);
                    Console.WriteLine("Let's rend another soul from it's body; shall we?");
                    System.Threading.Thread.Sleep(2000);
                    do
                    {
                    Console.WriteLine($"A beast stands before you with {bossHP} Health. It's eyes look like burning embers in the darkness.");
                    Console.WriteLine($"It's keeping it's distance and growling menacingly. You have {heroHP} HP. How would you like to start the fight?");
                    string ? swordAttack = Console.ReadLine();
                    if (swordAttack == "slash" || swordAttack == "Slash")
                    {
                        Console.WriteLine($"You slash the beast for {randSlice} damage. The beast lets out a grunt as the blade cuts the hide.");
                        System.Threading.Thread.Sleep(2000);
                                if (randDice >= 5)
                                {
                                Console.WriteLine($"The beast swipes at you for {swipes[randSwipe]} damage.");
                                heroHP -= randSwipe;
                                }
                                else if (randDice < 5)
                                {
                                Console.WriteLine($"The beast bites you for {bites[randBite]} damage.");
                                heroHP -= randBite;
                                }
                                else if (randDice == 0)
                                {
                                Console.WriteLine($"The beast lunges at you and misses.");
                                }
                    }
                    else if (swordAttack == "bash" || swordAttack == "Bash")
                    {
                        Console.WriteLine($"You bash the beast in the noggin for {bashes[randBash]} damage. This disorients him and he takes a step back.");
                        bossHP -= randBash;
                        System.Threading.Thread.Sleep(2000);
                    }
                    else if (swordAttack == "battlecry" || swordAttack == "Battlecry")
                    {
                        Console.WriteLine($"You let out a fierce battlecry, empowering your sword.");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine($"The beast looks at you, puzzled. He swats you for {randSwipe}");
                        heroHP -= randSwipe;
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine("I recommend you slash here, just to see what happens. But hey, you do you.");
                        System.Threading.Thread.Sleep(1000);
                        string ? funnyAnswer = Console.ReadLine();
                
                        if (funnyAnswer == "slash" || funnyAnswer == "Slash")
                        {
                            Console.WriteLine($"You can read! You slash the beast for {randSlice+10} damage.");
                            bossHP -= randSlice+10;
                                if (randDice >= 5)
                                {
                                Console.WriteLine($"The beast swipes at you for {swipes[randSwipe]} damage.");
                                heroHP -= randSwipe;
                                }
                                else if (randDice < 5)
                                {
                                Console.WriteLine($"The beast bites you for {bites[randBite]} damage.");
                                heroHP -= randBite;
                                }
                                else if (randDice == 0)
                                {
                                Console.WriteLine($"The beast lunges at you and misses.");
                                }
                        }
                        else if (funnyAnswer == "bash" || funnyAnswer == "Bash")
                        {
                            Console.WriteLine("Reading is hard. It'll be okay, little one.");
                            System.Threading.Thread.Sleep(2000);
                            Console.WriteLine($"You try to bash the beast, but since you screamed like a lunatic beforehand; he swats you like a fly for {randSwipe} damage.");
                            heroHP -= randSwipe;
                        }
                        else if (funnyAnswer == "battlecry" || funnyAnswer == "Battlecry")
                        {
                            Console.WriteLine("The monster looks at you, confused. You're an awfully loud creature.");
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("What do?");
                            string ? cryAnswer = Console.ReadLine();
                            if (cryAnswer == "slash" || cryAnswer == "Slash")
                            {
                                Console.WriteLine("Your sword turns into a guitar and all of the sudden you're wearing a bunch of leather.");
                                System.Threading.Thread.Sleep(1000);
                                Console.WriteLine("You look up to see that you've also gained a TopHat. The beast looks at you; intrigued.");
                                System.Threading.Thread.Sleep(2000);
                                Console.WriteLine($"What will you do now? (Shred or Slash)");
                                string ? shredAnswer = Console.ReadLine();
                                if (shredAnswer == "shred" || shredAnswer == "Shred")
                                {
                                    Console.WriteLine("You shred your guitar with the best guitar solo the world has ever heard. Speakers erupt from the ground and intensify the solo even more.");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("The beast LOVES rock music and starts to headbang. He gets so into the solo that he slams his head into the roof of the cave.");
                                    System.Threading.Thread.Sleep(1000);
                                    Console.WriteLine("The roof of the cave collapses in on the beast, making him seemingly disappear. Light shines through the newly-added hole in the roof. You can finally see around");
                                    System.Threading.Thread.Sleep(3000);
                                    Console.WriteLine("The solo is so good that you can't stop playing. You and your tophat, jamming it out through time.");
                                    System.Threading.Thread.Sleep(1000);
                                    bossHP -= 500;
                                }
                                else if (shredAnswer == "slash" || shredAnswer == "Slash")
                                {
                                    Console.WriteLine("Yeah, you're Slash. Don't tell him that though. I don't own the copyright.");
                                    System.Threading.Thread.Sleep(2000);
                                    if (randDice >= 5)
                                    {
                                    Console.WriteLine($"You throw your tophat at the beast for {slices[randSlice*10]} damage.");
                                    bossHP -= randSlice*10;
                                    }
                                    else if (randDice < 5)
                                    {
                                    Console.WriteLine($"You throw a rose at the beast and shoot him with your gun. Get it? Guns N' Roses?");
                                    System.Threading.Thread.Sleep(2000);
                                    Console.WriteLine("It's a good thing that the beast is allergic to roses... and bullets.");
                                    bossHP -= 600;
                                    }
                                    else if (randDice == 0)
                                    {
                                    Console.WriteLine($"The beast turns into Axl Rose. You both jam out so hard that the cave collapses.");
                                    bossHP = 0;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please answer shred or slash");
                                }
                            }
                            else if (cryAnswer == "bash" || cryAnswer == "Bash")
                            {
                                Console.WriteLine($"All that screaming made the beast nervous to your next move. He catches you with his mouth, biting you for {randBite+5} damage.");
                                heroHP -= randBite+5;                        
                            }
                            else if (cryAnswer == "battlecry" || cryAnswer == "Battlecry")
                            {
                                Console.WriteLine("The beast is annoyed with how noisy you are and hurls a boulder at you, hitting you for 35 damage.");
                                heroHP -= 35;
                            }
                            else 
                            {
                                Console.WriteLine("Please enter a valid ability");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid ability.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid ability.");
                    }
                    }
                    while (heroHP > 0 && bossHP > 0);
                }
                else if (heroClass == "Bow" || heroClass == "bow")
                {
                    Console.WriteLine("Your bow and quiver won't do you much good in the damp, cramped spaces of this cave. It's time to leave.");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("As you begin to get up, you remember your abilities. Shoot, Volley, and Feign");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Volley fires 3 arrows. Roughly 30% chance 3 hit.");
                    Console.WriteLine("Feign, short for feign death, can only be used when below 20 HP. High risk/High reward play.");
                    System.Threading.Thread.Sleep(3000);
                    Console.WriteLine("Are you ready to proceed?");
                    string ? bowAnswer = Console.ReadLine();
                
                    if (bowAnswer == "yes" || bowAnswer == "Yes")
                    { 
                        do 
                        {
                        Console.WriteLine($"There's a beast in front of you with {bossHP} Health.");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine("What would you like to do?");
                        string ? fightAnswer = Console.ReadLine();
                        if (fightAnswer == "shoot" || fightAnswer == "Shoot")
                        {
                            Console.WriteLine($"You draw your bowstring; pulling the nock to your cheekbone. You release, striking the beast for {shootArrows[randShootArrow]} damage.");
                            bossHP -= randShootArrow;
                            System.Threading.Thread.Sleep(3000);
                            Console.WriteLine($"The beast lunges to swipe at you, hitting you for {swipes[randSwipe]} damage.");
                        }
                        else if (fightAnswer == "volley" || fightAnswer == "Volley")
                        {

                            if (randDice >= 8)
                            {

                                Console.WriteLine($"You pull 3 arrows back on your bowstring and release dealing {volleys[randVolley * 3]} damage.");
                                bossHP -= randVolley * 3;
                                System.Threading.Thread.Sleep(2000);
                                Console.WriteLine($"The now porcupine-esque boss lunges to bite you for {bites[randBite]} damage.");
                            }
                            else if (randDice <= 7 && randDice >= 4)
                            {
                                Console.WriteLine($"You pull 3 arrows back and release. 2 hit the beast (dealing {volleys[randVolley * 2]} damage) and the other disappears into the darkness.");
                                bossHP -= randVolley * 2;
                                System.Threading.Thread.Sleep(2000);
                                Console.WriteLine($"The now semi-spiked beast leaps to bite you and does {bites[randBite]} damage.");
                            }
                            else if (randDice <= 3)
                            {
                                Console.WriteLine($"You pull 3 arrows back and release. The first hits the beast, dealing {volleys[randVolley]} damage. The second and third disappear into the darkness.");
                                bossHP -= randVolley;
                                System.Threading.Thread.Sleep(2000);

                                if (randDice >= 5)
                                {
                                Console.WriteLine($"The beast swipes at you for {swipes[randSwipe]} damage.");
                                heroHP -= randSwipe;
                                }
                                else if (randDice < 5)
                                {
                                Console.WriteLine($"The beast bites you for {bites[randBite]} damage.");
                                heroHP -= randBite;
                                }
                                else if (randDice == 0)
                                {
                                Console.WriteLine($"The beast lunges at you and misses.");
                                }
                            }
                            else if (randDice ==0)
                            {
                                Console.WriteLine("You pull 3 arrows back and release. All 3 fly into the darkness and out of sight. Maybe you should try shooting 1 arrow at a time.");
                                System.Threading.Thread.Sleep(1000);
                                if (randDice >= 5)
                                {
                                Console.WriteLine($"The beast swipes at you for {swipes[randSwipe]} damage.");
                                heroHP -= randSwipe;
                                }
                                else if (randDice < 5)
                                {
                                Console.WriteLine($"The beast bites you for {bites[randBite]} damage.");
                                }
                                else if (randDice == 0)
                                {
                                Console.WriteLine($"The beast lunges at you and misses. It looks like you both suck XD");
                                }
                            }
                        }
                        else if (fightAnswer == "feign" && heroHP <= 20 || fightAnswer =="Feign" && heroHP <= 20)
                        {
                            Console.WriteLine("You let out a yelp of sharp pain and fall to the ground, limp.");
                            System.Threading.Thread.Sleep(3000);
                            Console.WriteLine("The beast slowly starts to approach you. He leans over to sniff what *seems-to-be* your carcass");
                            System.Threading.Thread.Sleep(6000);
                            if (randDice >= 4)
                            {
                                int feign = 90;
                                Console.WriteLine($"You leap and slice the beast's throat with your dagger; dealing {feign} damage!");
                            }
                            else if (randDice >=1 && randDice <=3)
                            {
                                int feign = 45;
                                Console.WriteLine($"You mistimed the leap for the throat, but you still connect with your dagger; dealing {feign} damage.");
                            }
                            else if (randDice == 0)
                            {
                            Console.WriteLine("You let out a long, drawn out fart. You shouldn't have had those burritos.");
                            System.Threading.Thread.Sleep(2000);
                            Console.WriteLine("The smell is pungeant and wreaks of sulfur. The beast lets out a loud roar and proceeds to stomp you into jelly.");
                            heroHP = 0;
                            }
                        }
                    }
                    while (bossHP > 0 && heroHP > 0 && money > 0);
                } 
                else if (bowAnswer == "no" || bowAnswer == "No")
                {
                        Console.WriteLine($"That's too bad. There's a beast in front of you with {bossHP} Health.");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine("What would you like to do?");
                        string ? fightAnswer = Console.ReadLine();
                        if (fightAnswer == "shoot" || fightAnswer == "Shoot")
                        {
                            Console.WriteLine($"You draw your bowstring; pulling the nock to your cheekbone. You release, striking the beast for {shootArrows[randShootArrow]} damage.");
                            bossHP -= randShootArrow;
                            System.Threading.Thread.Sleep(3000);
                            Console.WriteLine($"The beast lunges to swipe at you, hitting you for {swipes[randSwipe]} damage.");
                        }
                        else if (fightAnswer == "volley" || fightAnswer == "Volley")
                        {

                            if (randDice >= 8)
                            {

                                Console.WriteLine($"You pull 3 arrows back on your bowstring and release dealing {volleys[randVolley*3]} damage.");
                                bossHP -= randVolley*3;
                                System.Threading.Thread.Sleep(2000);
                                Console.WriteLine($"The now porcupine-esque boss lunges to bite you for {bites[randBite]} damage.");
                            }
                            else if (randDice <= 7 && randDice >= 4)
                            {
                                Console.WriteLine($"You pull 3 arrows back and release. 2 hit the beast (dealing {volleys[randVolley*2]} damage) and the other disappears into the darkness.");
                                bossHP -= randVolley*2;
                                System.Threading.Thread.Sleep(2000);
                                Console.WriteLine($"The now semi-spiked beast leaps to bite you and does {bites[randBite]} damage.");
                            }
                            else if (randDice <= 3)
                            {
                                Console.WriteLine($"You pull 3 arrows back and release. The first hits the beast, dealing {volleys[randVolley]} damage. The second and third disappear into the darkness.");
                                bossHP -= randVolley;
                                System.Threading.Thread.Sleep(2000);
                                if (randDice >= 5)
                                {
                                Console.WriteLine($"The beast swipes at you for {swipes[randSwipe]} damage.");
                                heroHP -= randSwipe;
                                }
                                else if (randDice < 5)
                                {
                                Console.WriteLine($"The beast bites you for {bites[randBite]} damage.");
                                heroHP -= randBite;
                                }
                                else if (randDice == 0)
                                {
                                Console.WriteLine($"The beast lunges at you and misses.");
                                }
                            }
                            else if (randDice ==0)
                            {
                                Console.WriteLine("You pull 3 arrows back and release. All 3 fly into the darkness and out of sight. Maybe you should try shooting 1 arrow at a time.");
                                System.Threading.Thread.Sleep(1000);
                                if (randDice >= 5)
                                {
                                Console.WriteLine($"The beast swipes at you for {swipes[randSwipe]} damage.");
                                heroHP -= randSwipe;
                                }
                                else if (randDice < 5)
                                {
                                Console.WriteLine($"The beast bites you for {bites[randBite]} damage.");
                                }
                                else if (randDice == 0)
                                {
                                Console.WriteLine($"The beast lunges at you and misses. It looks like you both suck XD");
                                }
                            }
                        }
                        else if (fightAnswer == "feign" && heroHP <= 20 || fightAnswer =="Feign" && heroHP <= 20)
                        {
                            Console.WriteLine("You let out a yelp of sharp pain and fall to the ground, limp.");
                            System.Threading.Thread.Sleep(3000);
                            Console.WriteLine("The beast slowly starts to approach you. He leans over to sniff what *seems-to-be* your carcass");
                            System.Threading.Thread.Sleep(6000);
                            if (randDice >= 4)
                            {
                                int feign = 90;
                                Console.WriteLine($"You leap and slice the beast's throat with your dagger; dealing {feign} damage!");
                            }
                            else if (randDice >=1 && randDice <=3)
                            {
                                int feign = 45;
                                Console.WriteLine($"You mistimed the leap for the throat, but you still connect with your dagger; dealing {feign} damage.");
                            }
                            else if (randDice == 0)
                            {
                            Console.WriteLine("You let out a long, drawn out fart. You shouldn't have had those burritos.");
                            System.Threading.Thread.Sleep(2000);
                            Console.WriteLine("The smell is pungeant and wreaks of sulfur. The beast lets out a loud roar and proceeds to stomp you into jelly.");
                            heroHP = 0;
                            }
                        }

            
                }
                else if (bowAnswer == "please" || bowAnswer == "Please")
                {
                    Console.WriteLine("You cheeky bastard. Have an extra 50 HP.");
                    heroHP += 50;
                        Console.WriteLine($"That's too bad. There's a beast in front of you with {bossHP} Health.");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine("What would you like to do?");
                        string ? fightAnswer = Console.ReadLine();
                        if (fightAnswer == "shoot" || fightAnswer == "Shoot")
                        {
                            Console.WriteLine($"You draw your bowstring; pulling the nock to your cheekbone. You release, striking the beast for {shootArrows[randShootArrow]} damage.");
                            bossHP -= randShootArrow;
                            System.Threading.Thread.Sleep(3000);
                            Console.WriteLine($"The beast lunges to swipe at you, hitting you for {swipes[randSwipe]} damage.");
                        }
                        else if (fightAnswer == "volley" || fightAnswer == "Volley")
                        {

                            if (randDice >= 8)
                            {

                                Console.WriteLine($"You pull 3 arrows back on your bowstring and release dealing {volleys[randVolley*3]} damage.");
                                bossHP -= randVolley*3;
                                System.Threading.Thread.Sleep(2000);
                                Console.WriteLine($"The now porcupine-esque boss lunges to bite you for {bites[randBite]} damage.");
                            }
                            else if (randDice <= 7 && randDice >= 4)
                            {
                                Console.WriteLine($"You pull 3 arrows back and release. 2 hit the beast (dealing {volleys[randVolley*2]} damage) and the other disappears into the darkness.");
                                bossHP -= randVolley*2;
                                System.Threading.Thread.Sleep(2000);
                                Console.WriteLine($"The now semi-spiked beast leaps to bite you and does {bites[randBite]} damage.");
                            }
                            else if (randDice <= 3)
                            {
                                Console.WriteLine($"You pull 3 arrows back and release. The first hits the beast, dealing {volleys[randVolley]} damage. The second and third disappear into the darkness.");
                                bossHP =- randVolley;
                                System.Threading.Thread.Sleep(2000);
                                if (randDice >= 5)
                                {
                                Console.WriteLine($"The beast swipes at you for {swipes[randSwipe]} damage.");
                                heroHP =- randSwipe;
                                }
                                else if (randDice < 5)
                                {
                                Console.WriteLine($"The beast bites you for {bites[randBite]} damage.");
                                heroHP =- randBite;
                                }
                                else if (randDice == 0)
                                {
                                Console.WriteLine($"The beast lunges at you and misses.");
                                }
                            }
                            else if (randDice ==0)
                            {
                                Console.WriteLine("You pull 3 arrows back and release. All 3 fly into the darkness and out of sight. Maybe you should try shooting 1 arrow at a time.");
                                System.Threading.Thread.Sleep(1000);
                                if (randDice >= 5)
                                {
                                Console.WriteLine($"The beast swipes at you for {swipes[randSwipe]} damage.");
                                heroHP -= randSwipe;
                                }
                                else if (randDice < 5)
                                {
                                Console.WriteLine($"The beast bites you for {bites[randBite]} damage.");
                                }
                                else if (randDice == 0)
                                {
                                Console.WriteLine($"The beast lunges at you and misses. It looks like you both suck XD");
                                }
                            }
                        }
                        else if (fightAnswer == "feign" && heroHP <= 20 || fightAnswer =="Feign" && heroHP <= 20)
                        {
                            Console.WriteLine("You let out a yelp of sharp pain and fall to the ground, limp.");
                            System.Threading.Thread.Sleep(3000);
                            Console.WriteLine("The beast slowly starts to approach you. He leans over to sniff what *seems-to-be* your carcass");
                            System.Threading.Thread.Sleep(6000);
                            
                            if (randDice >= 7)
                            {
                                int feign = 90;
                                Console.WriteLine($"You leap and slice the beast's throat with your dagger; dealing {feign} damage!");
                            }
                            else if (randDice >=3 && randDice <=6)
                            {
                                int feign = 45;
                                Console.WriteLine($"You mistimed the leap for the throat, but you still connect with your dagger; dealing {feign} damage.");
                            }
                            else if (randDice <= 2)
                            {
                            Console.WriteLine("You let out a long, drawn out fart. You shouldn't have had those burritos.");
                            System.Threading.Thread.Sleep(2000);
                            Console.WriteLine("The smell is pungeant and wreaks of sulfur. The beast lets out a loud roar and proceeds to stomp you into jelly.");
                            heroHP = 0;
                            }
                        }
                        while (bossHP > 0 && heroHP > 0 && money > 0);
                    }
                else
                {
                    Console.WriteLine("Yes or No, please.");
                }
                }
           
            else if (heroClass == "God" || heroClass == "god")
            {
                Console.WriteLine("A walk in the park, eh?");
                Console.WriteLine("I mean, you're just gonna 1 shot the poor guy anyway. Your ability is Smite.");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Beast in front of you. 100 hp. You have 120 hp. Go ahead. Smite him. (Smite or No)");
                string ? smiteAnswer = Console.ReadLine();
                if (smiteAnswer == "smite" || smiteAnswer == "Smite")
                {
                    Console.WriteLine($"You smite the beast for {smite} damage.");
                    bossHP -= smite;
                }
                else if (smiteAnswer == "no" || smiteAnswer == "No")
                {
                    Console.WriteLine("What do you think you're going to do, have tea with the beast?");
                    Console.WriteLine("Just Smite him already. (Smite)");
                    string ? smiteAnswer2 = Console.ReadLine();
                    if (smiteAnswer2 == "smite" || smiteAnswer2 == "Smite")
                    {
                        Console.WriteLine($"You smite the beast for {smite} damage.");
                        bossHP -= smite;
                    }
                    else 
                    {
                        Console.WriteLine("You really can't read. S M I T E");
                    }
                }
            }
            else 
            {
                Console.WriteLine("Please enter Staff, Sword, or Bow to proceed.");
            }
        }
         while(bossHP > 0 && heroHP > 0 && money > 0);
                
    



                }
                }
}
                