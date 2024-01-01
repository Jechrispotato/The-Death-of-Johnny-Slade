using System;
using System.Threading;
using System.Media;
class Program
{
    static void Main(string[] args)
    {
        Beginning();
        ShowMenu();
    }

    //Menu//
    static void JohnnyRed()
    {
        string logo1 = @"
    						  ▄█  ▄██████▄     ▄█    █▄    ███▄▄▄▄   ███▄▄▄▄   ▄██   ▄   
					         ███ ███    ███   ███    ███   ███▀▀▀██▄ ███▀▀▀██▄ ███   ██▄ 
					         ███ ███    ███   ███    ███   ███   ███ ███   ███ ███▄▄▄███ 
					         ███ ███    ███  ▄███▄▄▄▄███▄▄ ███   ███ ███   ███ ▀▀▀▀▀▀███ 
					         ███ ███    ███ ▀▀███▀▀▀▀███▀  ███   ███ ███   ███ ▄██   ███ 
					         ███ ███    ███   ███    ███   ███   ███ ███   ███ ███   ███ 
					         ███ ███    ███   ███    ███   ███   ███ ███   ███ ███   ███ 
					     █▄ ▄███  ▀██████▀    ███    █▀     ▀█   █▀   ▀█   █▀   ▀█████▀  
					     ▀▀▀▀▀▀ ";


        ColorRed(logo1);
    }
    static void SladeWHite()
    {
        string logo2 = @"
						   ▄████████  ▄█          ▄████████ ████████▄     ▄████████ 
						  ███    ███ ███         ███    ███ ███   ▀███   ███    ███ 
						  ███    █▀  ███         ███    ███ ███    ███   ███    █▀  
						  ███        ███         ███    ███ ███    ███  ▄███▄▄▄     
						▀███████████ ███       ▀███████████ ███    ███ ▀▀███▀▀▀     
						         ███ ███         ███    ███ ███    ███   ███    █▄  
						   ▄█    ███ ███▌    ▄   ███    ███ ███   ▄███   ███    ███ 
						 ▄████████▀  █████▄▄██   ███    █▀  ████████▀    ██████████ 
                                                           
 ";
        Console.WriteLine(logo2);
    }
    static void JohnnySladeIntro()
    {
        string logo = @"
							      ___  __ _  _____           ___  ___ 
							     /   \/__/_\/__   \/\  /\   /___\/ __\
						   	    / /\ /_\//_\\ / /\/ /_/ /  //  // _\  
							   / /_///_/  _  / / / __  /  / \_// /    
							  /___,'\__\_/ \_\/  \/ /_/   \___/\/";

        Console.WriteLine(logo);
    }
    static void ShowMenu()
    {
         

        Console.Clear();

        menu();

        int selectedOption = 1;
        bool exitMenu = false;

        while (!exitMenu)
        {
            string text = "\n\t\t\t\t\t\t      Witness the death of the infamous Jonny slade.";
            Console.Clear();
            JohnnySladeIntro();
            JohnnyRed();
            SladeWHite();
            ColorRed(text);

            for (int i = 1; i <= 3; i++)
            {
                if (i == selectedOption)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                switch (i)
                {
                    case 1:
                        
                        Console.WriteLine("\n\n\n\t\t\t\t\t\t\t		  Start  ");
                        break;
                    case 2:
                        
                        Console.WriteLine("\t\t\t\t\t\t\t		  About  ");
                        break;
                    case 3:
                        
                        Console.WriteLine("\t\t\t\t\t\t\t		  Exit   ");
                        break;
                }
            }

            Console.ResetColor();

            // Wait for arrow key input
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    selectedOption = selectedOption > 1 ? selectedOption - 1 : 3;
                    break;
                case ConsoleKey.DownArrow:
                    selectedOption = selectedOption < 3 ? selectedOption + 1 : 1;
                    break;
                case ConsoleKey.Enter:
                    exitMenu = true;
                    break;
            }
        }

        switch (selectedOption)
        {
            case 1:
                StartGame();
                break;
            case 2:
                About();
                break;
            case 3:
                Exit();
                break;
        }
    }
    static void StartingScene()
    {
        Console.Clear();
        DeadBody();
        int option1 = MakeChoice("What would you do if you saw a dead body?\n", new string[] { "Call an ambulance", "Ignore", "Investigate" });


        if (option1 == 1)
        {
            JechrisInstructions();
        }

        if (option1 == 2)
        {
            mimoy();
        }

        if (option1 == 3)
        {
            HorrorProgram();
        }
    }                               //Starting story (if you see a dead body...)//

    //Menu options//
    static void PrintCentered(string text)
    {
        int margin = (Console.WindowWidth - text.Length) / 2;
        Console.WriteLine(new string(' ', Math.Max(0, margin)) + text);
    }
    static void StartGame()
    {
        Console.Clear();
        Console.CursorTop = 18; Console.CursorLeft = 49; Console.WriteLine("\t\tGame loading...Please wait");
        Console.WriteLine();
        int totalProgress = 100;

        for (int i = 0; i <= totalProgress; i++)
        {
            DrawProgressBar(i, totalProgress);
            Thread.Sleep(10); // Simulate some work being done
            Console.SetCursorPosition(0, Console.CursorTop);
        }

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.CursorTop = 18; Console.CursorLeft = 49; Console.WriteLine("\t\t Press [enter] to continue");
        Console.ResetColor();

        Console.ReadKey(true);

        string text = "Instructions:\n\t\t\t\tThe goal for you, I'll recite in verse. \n\t\t\t\tFinish the levels and lift the curse. \n\t\t\t\tIf you wish to leave the game, you must save Johnny and call out its name.";
        string text2 = "\n\n\t\t\t\tThe game is key sensitive, choose your answers correctly, unless it will malfunction.";
        string text3A = "\n\n\t\t\t\tPress [enter] to continue.";
        string text3 = "\n\n\t\t\t\tGoodluck and may God be with you. ";
        string text4 = "\n\n\t\t\t\tTo play the game/s, click the number of your chosen option. Choose your option carefully. ";
        string text5 = "\n\n\t\t\t\tPress [escape] key to go back to the main menu.";
        Console.Clear();

        instructions1();
        MainInstructions();
        Typewriter1(text);
        Typewriter1(text2);
        Typewriter1(text3);

        
        ColorRed(text3A); Console.ReadKey();
        instructions2();
        Typewriter1(text4);
        Typewriter1(text5);
        Console.ReadKey();

        Console.Clear();

        JDS();
        string text4A = "\t\t\t\t\tRemember: ";
        string text4B = "\n\t\t\t\t\t          '4444' angels will always guide you. For all time, always. ";
        string text4C = "\n\n\t\t\t\t\t\t\t\t   Press [enter] to continue";
        ColorRed(text4A);
        Typewriter(text4B);
        ColorRed(text4C);
        Console.ReadKey();

        FirstChapter();
        Console.ReadKey();

        StartingScene();
        Console.ReadKey();


    }
    static void About()
    {

        string text = "\n\t\tABOUT:       \n\n\t\t\t\tThe game 'Death of Johnny Slade' was based from the genre of text-based games from the 60's.  \n\t\t\t\tA text game or text-based game is an electronic game that uses a text-based user interface, that is, the user interface \n\temploys a set of encodable characters, such as ASCII, instead of bitmap or vector graphics. \n\n\t\t\t\tText-based games trace as far back as teleprinters in the 1960s, when they were installed on early mainframe computers as \n\tan input-and-output form. ";
        string text2 = "\n\n\t\t\t\tThe game itself is a text-base maze like game, which brings you to a story of the dead Johnny Slade, and unlocked different\n\tgames for you to play.";
        string text3A = "\n\n\t\t\t\tPress [enter] to continue.";
        string text4 = "\n\n\t\t\t\tIt consists of mini games such as guess the number, riddles, story-making; that uses the user's critical thinking skills \n\tand how will they handle the story of the death of Johnny Slade.";
        string text5 = "\n\t\tABOUT THE DEVS:       \n\n\t\t\t\tThe game 'Death of Johnny Slade' was made by Jechris C., Lawrence D., & Lee Xymon B.  \n\t\t\t\tIt was created on November 07, 2023 as a final task for ITEC 102 Finals by Mr. Al Jhon Villareal.";
        string text6 = "\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t    all rights reserved 2023.";
        Console.Clear();

        aboutSong();
        AboutLogo();
        Typewriter(text);
        Typewriter(text2);
        ColorRed(text3A); Console.ReadKey();
        Typewriter(text4);
        Console.ReadKey();
        Console.Clear();

        AboutLogo();
        Typewriter(text5);
        ColorRed(text6);
        Console.ReadKey();
        Console.Clear();
        ShowMenu();
    }
    static void Exit()
    {
        Console.Clear();
        Console.WriteLine("Exiting the game. Goodbye!");
        Environment.Exit(0);
    }

    //Utilities
    static int MakeChoice(string question, string[] options)
    {
        PrintCentered(question);
        for (int i = 0; i < options.Length; i++)
            PrintCentered((i + 1) + "." + options[i]);

        int selectedIndex = 0;

        ConsoleKeyInfo key;
        do
        {
            key = Console.ReadKey(true);

            

            if (key.Key == ConsoleKey.Escape)
            {
                CallAnotherMethod();
            }

            else if (key.Key == ConsoleKey.Escape)
            {
                return -1; // Return -1 to indicate going back to previous part
            }

            else if (key.KeyChar >= '1' && key.KeyChar <= ('1' + options.Length - 1))
            {
                selectedIndex = key.KeyChar - '1';
                break;
            }
            else 
            {
                PrintCentered("Invalid choice. Please enter a number between 1 and " + options.Length);
            }
        } while (true);

        Console.Clear();
        return selectedIndex + 1;
    } //To check what the user clicked if it's inside the parameter//
    static void ColorRed(string text)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write(text);
        Console.ResetColor();
    } 						//To color the texts red//
    static void PrintCenter(string text)
    {
        int margin = (Console.WindowWidth - text.Length) / 2;
        Console.WriteLine(new string(' ', Math.Max(0, margin)) + text);

        ConsoleKeyInfo keyInfo = Console.ReadKey();

        if (keyInfo.Key == ConsoleKey.Escape)
        {
            Console.Clear();
            Console.WriteLine("Are you sure you want to go to the Main Menu? (y/n)");

            ConsoleKey responseKey = Console.ReadKey().Key;

            if (responseKey == ConsoleKey.Y)
            {
                Console.Clear();
                Thread.Sleep(500);
                ShowMenu();
            }
        }
    } 					//To print text on Center Top of the Console//
    static void PrintCenter1(string text)
    {
        int margin = (Console.WindowWidth - text.Length) / 2;
        Console.WriteLine(new string(' ', Math.Max(0, margin)) + text);
    }
    static void Typewriter(string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            Console.Write(text[i]);
            Thread.Sleep(15); // Adjust the speed of the animation by changing the sleep duration
        }
    }
    static void Typewriter1(string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            Console.Write(text[i]);
            Thread.Sleep(60); // Adjust the speed of the animation by changing the sleep duration
        }
    }//TYpewriting text animation//
    static void MainInstructions()
    {
        string instructionsLogo = @"
		  ▄█  ███▄▄▄▄      ▄████████     ███        ▄████████ ███    █▄   ▄████████     ███      ▄█   ▄██████▄  ███▄▄▄▄      ▄████████ 
		 ███  ███▀▀▀██▄   ███    ███ ▀█████████▄   ███    ███ ███    ███ ███    ███ ▀█████████▄ ███  ███    ███ ███▀▀▀██▄   ███    ███ 
		 ███▌ ███   ███   ███    █▀     ▀███▀▀██   ███    ███ ███    ███ ███    █▀     ▀███▀▀██ ███▌ ███    ███ ███   ███   ███    █▀  
		 ███▌ ███   ███   ███            ███   ▀  ▄███▄▄▄▄██▀ ███    ███ ███            ███   ▀ ███▌ ███    ███ ███   ███   ███        
		 ███▌ ███   ███ ▀███████████     ███     ▀▀███▀▀▀▀▀   ███    ███ ███            ███     ███▌ ███    ███ ███   ███ ▀███████████ 
		 ███  ███   ███          ███     ███     ▀███████████ ███    ███ ███    █▄      ███     ███  ███    ███ ███   ███          ███ 
		 ███  ███   ███    ▄█    ███     ███       ███    ███ ███    ███ ███    ███     ███     ███  ███    ███ ███   ███    ▄█    ███ 
		 █▀    ▀█   █▀   ▄████████▀     ▄████▀     ███    ███ ████████▀  ████████▀     ▄████▀   █▀    ▀██████▀   ▀█   █▀   ▄████████▀  
		                                          ███    ███                                                                          
                                                                     
	";
        ColorRed(instructionsLogo);
    } 							//Main instructions logo//
    static void PrintSlow2(string text)
    {
        int left = (Console.WindowWidth - text.Length) / 2;
        int top = Console.WindowHeight - 12;
        Console.SetCursorPosition(left, top);

        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(50);
        }
        Console.WriteLine();


        ConsoleKeyInfo keyInfo = Console.ReadKey();

        if (keyInfo.Key == ConsoleKey.Escape)
        {
            Console.Clear();
            Console.WriteLine("Are you sure you want to go to the Main Menu? (y/n)");

            ConsoleKey responseKey = Console.ReadKey().Key;

            if (responseKey == ConsoleKey.Y)
            {
                Console.Clear();
                Thread.Sleep(500);
                ShowMenu();
            }
        }

        Console.Clear();

    }
    static void sladeInstructions()
    {
        WarningSigns();
    }
    static void WarningSigns()
    {
        Console.Clear();
        int selectedOption = 1;
        bool exitMenu = false;

        while (!exitMenu)
        {
            string text0 = "\n\n\t\tWARNING:";
            string text = "       \n\n\t\t\t\tThis game contains violent and dsiturbing languages and assets.  \n\t\t\t\tProceed with guaranteed caution. ";
            string text1 = "\n\n\t\t\t\tPlayer discretion IS adviced. Thank you.";
            Console.Clear();
            ColorRed(text0);
            Console.WriteLine(text);
            Console.WriteLine(text1);

            string text0a = "\n\t\tADVERTENCIA; ";
            string texta = "       \n\n\t\t\t\tEste juego contiene lenguaje y recursos violentos y perturbadores.   \n\t\t\t\tProceda con precaución. ";
            string text1a = "\n\n\t\t\t\tSe DEBE Y SE recomienda la discreción del jugador. Gracias.";
            ColorRed(text0a);
            Console.WriteLine(texta);
            Console.WriteLine(text1a);

            string text0b = "\n\t\tBABALA:";
            string textb = "       \n\n\t\t\t\tAng larong ito ay naglalaman ng marahas at nakakabagbag-damdaming mga wika at mga assets. \n\t\t\t\tMagpatuloy nang may garantisadong pag-iingat. ";
            string text1b = "\n\n\t\t\t\tAng pagpapasya ng manlalaro AY pinapayuhan. Salamat.";
            ColorRed(text0b);
            Console.WriteLine(textb);
            Console.WriteLine(text1b);

            string text0c = "\n\t\tAVVERTIMENTO:";
            string textc = "       \n\n\t\t\t\tQuesto gioco contiene linguaggi e risorse violenti e inquietanti.  \n\t\t\t\tProcedere con la massima cautela. ";
            string text1c = "\n\n\t\t\t\tLa discrezione del giocatore DEVE ED È consigliata. Grazie.";
            ColorRed(text0c);
            Console.WriteLine(textc);
            Console.WriteLine(text1c);

            for (int i = 1; i <= 2; i++)
            {
                if (i == selectedOption)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                switch (i)
                {
                    case 1:
                        Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tContinue");
                        break;
                    case 2:
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tExit");
                        break;
                }
            }

            Console.ResetColor();

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    selectedOption = selectedOption > 1 ? selectedOption - 1 : 2;
                    break;
                case ConsoleKey.DownArrow:
                    selectedOption = selectedOption < 2 ? selectedOption + 1 : 1;
                    break;
                case ConsoleKey.Enter:
                    exitMenu = true;
                    break;
            }
        }

        switch (selectedOption)
        {
            case 1:
                ShowMenu();
                break;
            case 2:
                Exit();
                break;
        }
    }
    static void JDS()
    {
        SoundPlayer player = new SoundPlayer("JDS.wav");
        player.PlayLooping();
    }
    static void menu()
    {
        SoundPlayer player = new SoundPlayer("3intro.wav");
        player.Play(); 

    }
    static void instructions1()
    {
        SoundPlayer player = new SoundPlayer("1.wav");
        player.Play();
    }
    static void instructions2()
    {
        SoundPlayer player = new SoundPlayer("2.wav");
        player.Play();
    }
    static void ENDsong()
    {
        SoundPlayer player = new SoundPlayer("END.wav");
        player.PlayLooping();
    }
    static void aboutSong()
    {
        SoundPlayer player = new SoundPlayer("about.wav");
        player.PlayLooping();
    }
    static void jump()
    {
        SoundPlayer jump = new SoundPlayer("JUMP.wav");
        jump.Play();
    }
    static void LastGame()
    {
        Console.Clear();
        //4444 angels will always guide you
        string secretWord = "4444angels";
        int maxAttempts = secretWord.Length;
        int attempts = 0;
        bool gameOver = false;
        string hint = "";

        string text1 = "Your phone's battery is dead. But, you found johnny's phone. What's his phone's password?";
        PrintCenter(text1);
        Console.WriteLine("\nIt contains {0} characters. You have {0} attempts.", maxAttempts);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Use your logic. Remember?");
        Console.ResetColor();


        while (!gameOver)
        {
            Console.Write("\nEnter your guess: ");
            string guess = Console.ReadLine();
            attempts++;

            if (guess.Length > secretWord.Length)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t\tInvalid guess! The length of your guess should be at most {0}.", secretWord.Length);
                Console.ResetColor();
                continue;
            }

            if (guess == secretWord)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\t\t\tCongratulations! You guessed Johnny's password '{0}' correctly.", secretWord);
                gameOver = true;
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\t\t\tWrong guess!");
                Console.ResetColor();

                if (attempts >= maxAttempts)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n\t\t\tYou ran out of attempts.");
                    Console.WriteLine("\t\t\tLet's play again!");
                    attempts = 0;
                    hint = "";
                    Console.ReadKey(true);
                    Console.ResetColor();


                    Console.Clear();
                    Console.WriteLine("What is Johnny Slade's last words?");
                    Console.WriteLine("It contains {0} characters. You have {0} attempts.", maxAttempts);

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nUse your logic. Remember?");
                    Console.ResetColor();
                }
                else
                {
                    if (guess.Length == 26)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n\t\t\tYou entered all the letters of the alphabet!");
                        Console.WriteLine("\t\t\tNo hint available.");
                        Console.ResetColor();
                    }
                    else
                    {
                        hint = GetHint(secretWord, guess);
                        Console.WriteLine("\t\t\tHere's a hint: {0}", hint);

                    }
                }
            }
        }

        Console.WriteLine("\t\t\tPress anything to continue");

        Console.ReadKey();
        EndofPathJech();
    }
    static string GetHint(string secretWord, string guess)
    {

        string hint = "";

        for (int i = 0; i < secretWord.Length; i++)
        {
            if (guess.Contains(secretWord[i].ToString()))
            {
                hint += secretWord[i];
            }
            else
            {
                hint += "_";
            }
        }


        return hint;
    }
    static void EndofPathJech()
    {
        string text = "\n\n\t\t\t\tYou chose to call an ambulance when you saw a dead body.   \n\n\t\t\t\tYou are inspiring optimist, readily taking action to do what they feel is right. \n\n\t\t\t\tYou place a lot of importance on empathy, social harmony, and cooperation. \n\n\t\t\t\tYou feel called to serve a greater purpose in life. ";
        string text2 = "\n\n\n\t\t\t\tRating: 79/100";
        string text3A = "\n\n\n\n\n\n\n\n\t\t\t\tPress [enter] to exit.";

        Console.Clear();

        ENDsong();
        End();
        Console.WriteLine(text);


        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(text2);
        Console.ResetColor();


        Console.WriteLine(text3A);
        Console.ReadKey();
        Console.Clear();

        Exit();

    }
    static void EndofPathMimoy()
    {
        string text = "\n\n\t\t\t\tYou chose to ignore the dead body.   \n\n\t\t\t\tYou are a hesitant pessimist, avoiding action and reluctant to do what you feel is right. \n\n\t\t\t\tDriven by fear, you neglect empathy,social harmony, and cooperation. \n\n\t\t\t\tHaunted by fear, you bear the weight of guilt for running away from what you should face. ";
        string text2 = "\n\n\n\t\t\t\tRating: 94/100";
        string text3A = "\n\n\n\n\n\n\n\n\t\t\t\tPress [enter] to exit.";

        Console.Clear();
        ENDsong();
        End();
        Console.WriteLine(text);


        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(text2);
        Console.ResetColor();


        Console.WriteLine(text3A);


        Console.ReadKey();
        Console.Clear();

        Exit();

    }
    static void End()
        {
            string logo1 = @"
		         ▄████████ ███▄▄▄▄   ████████▄        ▄██████▄     ▄████████         ▄███████▄    ▄████████     ███        ▄█    █▄    
		        ███    ███ ███▀▀▀██▄ ███   ▀███      ███    ███   ███    ███        ███    ███   ███    ███ ▀█████████▄   ███    ███   
		        ███    █▀  ███   ███ ███    ███      ███    ███   ███    █▀         ███    ███   ███    ███    ▀███▀▀██   ███    ███   
		       ▄███▄▄▄     ███   ███ ███    ███      ███    ███  ▄███▄▄▄            ███    ███   ███    ███     ███   ▀  ▄███▄▄▄▄███▄▄ 
		      ▀▀███▀▀▀     ███   ███ ███    ███      ███    ███ ▀▀███▀▀▀          ▀█████████▀  ▀███████████     ███     ▀▀███▀▀▀▀███▀  
		        ███    █▄  ███   ███ ███    ███      ███    ███   ███               ███          ███    ███     ███       ███    ███   
		        ███    ███ ███   ███ ███   ▄███      ███    ███   ███               ███          ███    ███     ███       ███    ███   
		        ██████████  ▀█   █▀  ████████▀        ▀██████▀    ███              ▄████▀        ███    █▀     ▄████▀     ███    █▀    
                                                                                                                         

            ";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(logo1);
            Console.ResetColor();
        }

    //Codes for option 1 (Jechris)//
    static void Jechris()
    {
        Console.Clear();
        Console.CursorTop = 18; Console.CursorLeft = 49; Console.WriteLine("\t    This action will have consequences...");
        Console.WriteLine();
        int totalProgress = 100;

        for (int i = 0; i <= totalProgress; i++)
        {
            DrawProgressBar(i, totalProgress);
            Thread.Sleep(15); // Simulate some work being done
            Console.SetCursorPosition(0, Console.CursorTop);
        }

        Console.Clear();


        AreYouWatcher();
        int option1 = MakeChoice("Are you a watcher or a player?\n", new string[] { "watcher", "player" });


        if (option1 == 1)
        {
            Watcher();
        }

        else if (option1 == 2)
        {
            Player();
        }

    }
    static void Watcher()
    {
        Console.Clear();
        string textToAlign = "25% of 100%";

        AlignTextRight(textToAlign);

        questionMark();
        int option1 = MakeChoice("Where's Johnny?\n", new string[] { "he jumped", "no idea" });


        if (option1 == 1)
        {
            Console.Clear();

            string pass = "4444";
            string attempt;

            for (int i = 0; ; i++)
            {

                Console.CursorTop = 18; Console.CursorLeft = 49; Console.Write("Please enter password: ");
                attempt = Console.ReadLine();

                if (attempt == pass)
                {
                    StartingMiniGame();
                    MiniGame();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.CursorTop = 20; Console.CursorLeft = 51; Console.Write("Access denied.");
                    Console.ResetColor();
                }
            }


            Console.ReadKey(true);

        }

        if (option1 == 2)
        {
            StartGame();
        }


    }
    static void Player()
    {
        Console.Clear();
        string textToAlign = "25% of 100%";

        AlignTextRight(textToAlign);

        HUngry();
        int option1 = MakeChoice("you're really hungry. Breakfast?\n", new string[] { "oat meal", "water" });


        if (option1 == 1)
        {
            Console.Clear();
            string textToAlign2 = "30% of 100%";

            AlignTextRight(textToAlign2);
            Curse();
            int option2 = MakeChoice("today is monday\n", new string[] { "work", "sleep" });
            

            if (option2 == 1)
            {
                Console.Clear();
                Console.CursorTop = 18; Console.CursorLeft = 49; Console.WriteLine("oh snap! nothing seems to be working. press any key to go back.");
                Console.ReadKey();
                Player();
            }

            else if (option2 == 2)
            {
                Console.Clear();

                string textToAlign3 = "30% of 100%";

                AlignTextRight(textToAlign3);

                int option3 = MakeChoice("system reboot?\n", new string[] { "i am sentient", "i am aware", "i am alive" });


                if (option3 == 1)
                {
                    string textToAlign4 = "50% of 100%";

                    AlignTextRight(textToAlign4);

                    int option4 = MakeChoice("are you out of your fucking mind?\n", new string[] { "yes", "no" });


                    if (option4 == 1)
                    {
                        string textToAlign5 = "75% of 100%";

                        AlignTextRight(textToAlign5);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.CursorTop = 18; Console.CursorLeft = 49; Console.WriteLine("shall we play a game, shall we? press any key to continue"); Console.ResetColor();
                        Console.ReadKey();

                        MiniGame();
                    }

                    if (option4 == 2)
                    {
                        string textToAlign6 = "75% of 100%";

                        AlignTextRight(textToAlign6);

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.CursorTop = 18; Console.CursorLeft = 49; Console.WriteLine("shall we play a game, shall we? press any key to continue"); Console.ResetColor();
                        Console.ReadKey();

                        MiniGame();
                    }
                }

                else if (option3 == 2)
                {
                    StartingScene();
                }

                else if (option3 == 3)
                {
                    Watcher();
                }
            }
        }

        else if (option1 == 2)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.CursorTop = 18; Console.CursorLeft = 49; Console.WriteLine("shall we play a game, shall we? press any key to continue"); Console.ResetColor();
            Console.ReadKey();

            MiniGame();
        }
    }
    static void StartingMiniGame()
    {
        Console.Clear();
        PrintCenter("Quite clever. You remember your angel huh?"); Console.ReadKey(); Console.Clear();
    }
    static void MiniGame()
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 4444);
        int attempts = 0;
        bool correctGuess = false;

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Typewriter("\t\t  Now, guess the ambulance telephone number to call. Make sure it's between 1 - 4444. Good luck! [press any key to continue]");
        Console.ReadKey();
        Console.ResetColor();

        while (!correctGuess)
        {
            Console.Write("\n\nTake a guess: ");
            string input = Console.ReadLine();

            try
            {
                int guess = Convert.ToInt32(input);
                attempts++;

                if (guess == secretNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n\nCongratulations! You guessed the number in {0} attempt/s.", attempts);
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press enter to continue");
                    Console.ReadKey();

                    Console.Clear();
                    break;
                }
                else if (guess < secretNumber)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\n\t\tToo low! Try again.");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n\t\tToo high! Try again.");
                    Console.ResetColor();
                }
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\t\tInvalid number! Try again.");
                Console.ResetColor();
            }
        }

        LastNoteJechris();

        Console.ReadKey(true);

        Console.Clear();
    }
    static void PrintSlow(string text)
    {
        int left = (Console.WindowWidth - text.Length) / 2;
        int top = Console.WindowHeight / 2;
        Console.SetCursorPosition(left, top);

        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(50);
        }
        Console.WriteLine();


        ConsoleKeyInfo keyInfo = Console.ReadKey();

        if (keyInfo.Key == ConsoleKey.Escape)
        {
            Console.Clear();
            Console.WriteLine("Are you sure you want to go to the Main Menu? (y/n)");

            ConsoleKey responseKey = Console.ReadKey().Key;

            if (responseKey == ConsoleKey.Y)
            {
                Console.Clear();
                Thread.Sleep(500);
                ShowMenu();
            }
        }

        Console.Clear();
    }
    static void LastNoteJechris()
    {
        Console.Clear();
        string text1 = "You're good finding the ambulances' number. Now, we should be calling them. ";
        ambulance();
        Console.Write("");
        PrintCenter(text1);
        Console.ReadKey();

        LastGame();
    }
    static void JechrisInstructions()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        PrintCenter1("This path is a text-based maze. Try to memorize the correct options to finish the chapter. Some options makes you go back! Goodluck!"); Console.ResetColor();
        PrintCenter1(" ");
        PrintCenter1("[press any key to continue]");

        Console.ReadKey();

        Jechris();
    }
    static void ambulance()
    {
        string logo1 = @"                                                               
                                                                    █████                       
                                                                    █████                       
                                                                  █      █ █████████████████ ██ 
                                                                 █ █████ █                   ██ 
                                                                █ █   ██ █        █████      ██ 
                                                               █ ██ █ ██ █      █████████    ██ 
                                                               █ █    ██ █      █████████    ██ 
                                                            ██  ████████ █      █████████    ██ 
                                                           █             █ ███    █████   █  ██ 
                                                         █               █                   ██ 
                                                         █ ████████      █          ███████  ██ 
                                                         ████████ ███████████████████████ ████  
                                                            ███ █ █                 ███   █     
                                                              ████                    ████      


";
        ColorRed(logo1);
    }

    // Example usage
    static void DrawProgressBar(int progress, int total)
    {
        int progressBarWidth = 30;
        int filledWidth = (int)((progress / (double)total) * progressBarWidth);
        int emptyWidth = progressBarWidth - filledWidth;

        string progressBar = "[" + new string('█', filledWidth) + new string(' ', emptyWidth) + "] " + (int)((progress / (double)total) * 100) + "%";

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.SetCursorPosition((Console.WindowWidth - progressBar.Length) / 2, Console.CursorTop);
        Console.Write(progressBar);
        Console.ResetColor();
    }
    static void FirstChapter()
    {
        Console.Clear();
        string text1 = "“Am I walking away from something I should be running away from?”";
        Console.CursorTop = 18; Console.CursorLeft = 49; Console.WriteLine(text1);

    }
    static void Beginning()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        string text1 = "\t   enter full screen for better experience.";
        Console.CursorTop = 18; Console.CursorLeft = 49; Console.WriteLine(text1);
        Console.ResetColor();
        Console.CursorTop = 20; Console.CursorLeft = 51; Console.WriteLine("\t         [Press anything to continue]");
        Console.ReadKey();

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        string text2 = "\t    use headphones for bestest experience.";
        Console.CursorTop = 18; Console.CursorLeft = 49; Console.WriteLine(text2);
        Console.ResetColor();
        Console.CursorTop = 20; Console.CursorLeft = 51; Console.WriteLine("\t         [Press anything to continue]");
        Console.ReadKey();

        Console.Clear();
        Console.CursorTop = 18; Console.CursorLeft = 49; Console.WriteLine("\t\t    entering the scene...");
        Console.WriteLine();
        int totalProgress = 100;

        for (int i = 0; i <= totalProgress; i++)
        {
            DrawProgressBar(i, totalProgress);
            Thread.Sleep(10); // Simulate some work being done
            Console.SetCursorPosition(0, Console.CursorTop);
        }

        Console.Clear();

        sladeInstructions();

    }
    static void AlignTextRight(string text)
    {
        int consoleWidth = Console.WindowWidth;
        int textLength = text.Length;
        int spacesToRight = consoleWidth - textLength;

        Console.SetCursorPosition(spacesToRight, Console.CursorTop);
        ColorRed(text);
    }
    static void AboutLogo()
    {
        string logo1 = @"						  
						   ▄████████ ▀█████████▄   ▄██████▄  ███    █▄      ███     
						  ███    ███   ███    ███ ███    ███ ███    ███ ▀█████████▄ 
						  ███    ███   ███    ███ ███    ███ ███    ███    ▀███▀▀██ 
						  ███    ███  ▄███▄▄▄██▀  ███    ███ ███    ███     ███   ▀ 
						▀███████████ ▀▀███▀▀▀██▄  ███    ███ ███    ███     ███     
						  ███    ███   ███    ██▄ ███    ███ ███    ███     ███     
						  ███    ███   ███    ███ ███    ███ ███    ███     ███     
						  ███    █▀  ▄█████████▀   ▀██████▀  ████████▀     ▄████▀";

        ColorRed(logo1);

    }
    static void DeadBody()
    {
        string logo1 = @"                                                                                                                                                                 
                                                                                                                                                                                                  
			                                                                                                                 
			                                                         ███        ███████                                        
			                                                           ██     ███   █████                                      
			                                 ████████████               █     █     ██ █                                       
			                                 ███  ███   ██████████████████ █  █  ██ ████                                       
			                                      ███████████    ██    ███████████   █                                         
			                                             ███████    ████       ██    ██                                        
			    ███                                         ████   ██████████    ████████████                                  
			    ████                     ██       ████   ███ ████████         █████           ████████                         
			     ██  ███             ████████         ███     █         ██    ███████████████       ███ ███                    
			      ██  ████████████████    ██████████      █████████  █████████████    █████████████████    █████████ █         
			        ███   ██                       █████████     ██████████████              ███████████████   ███████         
			           ███████████████████████████████       ████████                                  ████████████████████    
			                                    ███    █     ████                                            ████████          
			                                  ████  █     █████                                                                
			                                 ███      ███████                                                                  
			                                ██     █████                                                                       
			                               █     █████                                                                         
			                             ██    ██                                                                              
			                           ████   █                                                                                
			                   █████████     █                                                                                 
			                █████ ████████  ██                                                                                 
			                 ████████████████                                                                                  
                                                                                                                                                                                                                                      
                                                     

";
        ColorRed(logo1);

    }
    static void AreYouWatcher()
    {
        string logo1 = @"                                                                                                                                                                                              
			                                                                                                               
			                                                                            ███████████                         
			                                                                           █████    ████                        
			                                                                            ██ █  █  ███                        
			                                      ██                                    █████ ██████                        
			                                 █████  ██████                                ███ ███                           
			                               █████       █████                                                                
			                               ██     ██      ██                                                                
			                               █████       █████        ████████                                                
			        ████████████              ███████████         █████   █████                                             
			        ████    ████                                  ██  █  █   ██                      █████████              
			        █████ █  ███                                  █████  ██████                   ████       ████           
			        █████  █████                                    ███  ███                      ████ ██ █  ████          
			           ██████                              ███  ██           █                    ███   ██   ████           
			                                            ██████████████████████████                ██████    █████           
			                                        ██████████             ███████████               █ ███████              
			                                      ███████  ███     ████     ███ ████████                                    
			                                   ███████    ███    ███████     ███    ██████                                  
			                                   ████       ██    ██      █     ██      █████                                 
			                    █████████      ████       ██     █      █    ███      █████                                 
			                 █████     █████   ██████     ███    ████████    ███    ███████                                 
			                 ████    █   ████     ███████  █████   ████     ███ ████████                                   
			                 ████  ██   █████       ████████                █ ████████          █████                       
			                 ███████    █████          ███████████████████████████        █████    ██████                   
			                    ██████████                 ███  ██████████  ███           ████ █  █  ████                   
			                                                                              ██ █  ██   █ ██                   
			          ██                                                █████ █████       ██████    █████                   
			     █████  ██████                                          █████ █ ████         ██████████                     
			   █████       █████                                        ██  █ █  ███                                        
			   ██     ██      ██      ███ ███                           █████  █████                 ███████                
			   █████      ██████    █████ ██████                          ███████                  █████ ██████             
			      ███████████       ██ █  █  ███                                                   ██  █ █  ███             
			                        ████  ██████                                                   ████  ██████             
			                        █████  ████                                                    █████  ████             
                                                                                                               
 ";
        ColorRed(logo1);
    }
    static void HUngry()
    {
        string logo1 = @"                                                                             
									                                             
							      ██   ████████ ███████ ██ █████  ███    
							     ████ ██  ████   ████   ████  ██ █████   
							    ██  ████                 ██    █ ██ ██   
							   ███   ███                       ███  ████ 
							  ███           ██    ██    ██           ███ 
							 █ █       ██  ████████████████  ███       █ 
							 █   ██   ██████  ████  ████  ███████   █  █ 
							 █  ████  ██ ██                ██  ██ ██████ 
							 ████  █████                       █ ███ ███ 
							        ████                       ███       
							          ██                       ██        
							                                             
							    ████                                ███  
							   ██████    ███               ███     ██ █  
							   ██   ████████               █ ████████ ██ 
							   ███   ████ ██               █ █ █ █  █ █  
							    ████      ██████████████████      █████  
							      ███ █ █    ██████████████      ██  █   
							        ███ █                     ████       
							         ██ █                    ████        
							           ███████████ █ ██████████          
				                                                          
                                                                                                  
                                                                                                                       
  ";
        ColorRed(logo1);
    }
    static void questionMark()
    {
        string logo1 = @"                                               
				                                                          
							              ███████████████████              
							            ██████           ███████           
							          ████                   ████          
							         ███       █████████       ███         
							        ███       ████████████       ██        
							        ██       ██         ███      ██        
							        ██████████           ██       ██       
							        █████████           ███       ██       
							                          ████       ██        
							                        ████       ███         
							                      ████        ███          
							                     ███        ████           
							                    ██       █████             
							                   ██       ████               
							                  ██       ██                  
							                  ██      ██                   
							                  ██████████                   
							                           █                   
							                  ███████████                  
							                  ██       ██                  
							                  ██       ██                  
							                  ██       ██                  
							                  ███████████                  
                                                       
       
                                             
  ";
        ColorRed(logo1);
    }
    static void Curse()
    {
        string logo1 = @"                                                                                                    
				                                                                                                                                                                               
				           ██████████████████████████████████████████████████████████████████████████████           
				           ██                                                                         ██            
				      ████████                                                                       ████████       
				       ██                                                                                 ███       
				   ██████                                                                                 ███████   
				   ███                                                                                       ████   
				   ███                                                                                       ████   
				   ███         ████  ███            ██████████       ███        ████     ███       ████      ████   
				   ███         ████  ███         ████        ████ ████ ████   ████ █  ████ ████    ████      ████   
				   ███          ███  ███         ███         ███  ████ ████ ██████    ████ ████    ████      ████   
				   ███    ███████████████████  ███    █████  ███     ███    ███       ████ ████    ████      ████   
				   ███          ██   ███       ███ ████  ██  ████         ███            ███       ████      ████   
				   ███     ██████████████████  ███    ████████         ████   ████    ████ ██████  ████      ████   
				   ███     ██████████████████  █████  ████████       ██████ ████████  ████ ██████  ████      ████   
				   ███          ███  ███         ███                 ███    ███  ███  ████ ███               ████   
				   ███         ████  ███           ████████████   ████        ████       ████████  ████      ████   
				   ██████                                                                                    ████   
				   ██████                                                                                 ███████   
				       ██   █                                                                        ████████       
				      ███████                                                                        █████████      
				       ███ ███████████████████████████         ██████████████████████████████████████████           
				           █████████████████████████       █   ██████████████████████████████████████████           
				                                 █         ███████                                                  
				                               ███      ██████                                                      
				                              ███   ███████                                                         
				                              ████████                                                              
				 


";
        ColorRed(logo1);
    }

    //Lawrence Assets
    static void Cabin()
    {
        string logo1 = @"						                                          
							                    (   )
							                    (    )
							                    (    )
							                    (    )
							                    )  )
							                    (  (                  /\
							                    (_)                 /  \  /\
							            ________[_]________      /\/    \/  \
							    /\      /\        ______    \    /   /\/\  /\/\
							    /  \    //_\       \    /\    \  /\/\/    \/    \
						/\    / /\/\  //___\       \__/  \    \/
						/  \  /\/    \//_____\       \ |[]|     \
						/\/\/\/       //_______\       \|__|      \
					/      \      /XXXXXXXXXX\                  \
							\    /_I_II  I__I_\__________________\
							        I_I|  I__I_____[]_|_[]_____I
							        I_II  I__I_____[]_|_[]_____I
							        I II__I  I     XXXXXXX     I
							    ~~~~~     ~~~~~~~~~~~~~~~~~~~~~~~~  


";
        ColorRed(logo1);

    }
    static void FamPic()
    {
        string logo1 = @"                                              
		                                    ███████████████████████████████████████████████████    
		                                    ██                                                █    
		                                    ██                                                █    
		                                    ██                                                █    
		                                    ██                                ██████████     ██    
		                                    ██                              █████████████     █    
		                                    ██     ████████                 ██         ██    ██    
		                                    ██   ████████████                       █  ██     █    
		                                    ██   ███████  ███                        █ █      █    
		                                    ██  ██                 ███        ███ ██   █     ██    
		                                    ██  ███  ██ ████       ████              █        █    
		                                    ██  █████    ██     ██████████     ███████████   ██    
		                                    ██       █          ████  ████    ██  ███   ███   █    
		                                    ██      ████████    █           ███          ███  █    
		                                    ██     ███  █ ███     █ ██ █   ████          ███  █    
		                                    ██     ███  █ ██████████  █████████          ██  ██    
		                                    ██    ██ █  ██ █ ████████████     █          █   ██    
		                                    ██    ██ █   █████ ██████████     █           ██ ██    
		                                    ██    ██  ███████    █████████    █           █   █    
		                                    ██    ██        ██    ████████    ██      ███ █   █    
		                                    ██    ██ ███ ██ █                 ████████  ████  █    
		                                    ███████████████████████████████████████████████████    
                

";


        ColorRed(logo1);

    }
    static void FootStep()
    {
        string logo1 = @"
								                                   █    
								                                 ███    
								                      ████       ████   
								                     ██████     ████    
								                    ███      ████       
								                   ██                   
								                   ██                   
								                                        
								                     ██                 
								          ██        ████                
								        ██████     ████                 
								       █████   █████                    
								      ██                                
								      ██                                
								                                        
								        ██                              
								       ████                             
								      ████                              
								   ████                                 
								   ██                                   
								                       
                                                                                                                           
";


        ColorRed(logo1);

    }
    static void Forest()
    {
        string logo1 = @"

							   █████████████████                                      
							 ██████           ████                                    
							 █ ███    ████████ █████                                  
							       ████      ███  ████                                
							 █ █ ██ ██████ ████████ ███                               
							 ███ ██████████████     █████                             
							      ██████████████ █    ████                            
							   ████     █   ███  ███ ████                             
							 ██ ███  █       ████████████                             
							 ██████   █ █ █ ███████████                        █      
							  ██    █   ██    ██ █                           ████     
							          ███                                    ████     
							           ██                                   ██ ███    
							           ██                                  ███ █ ██   
							           ██                                 ███ █ ████  
							           ██                                █   ███   █  
							      █████  ████████                        █████  █ ██  
							  ██████ ████████   ██████                       ████ ██  
							 ██               ███████████                 █████  █    
							            ████████████  ██████                  █    ██ 
							       ███████████       ███████████            ████████  
							 ██████ ██████    ███████████████████████████████████████ 
							 █████████    ████████████████████████           ████████ 
							          █████████████████                    ████    ██ 
							 ████████████████████                     ██████████  █   
							    ██████████                       ███████████     ████
          


";
        ColorRed(logo1);

    }
    static void Moon()
    {
        string logo1 = @"                                                                                                                         
					                                                                   
							                 ████████████                  
							              ██████████████████               
							              ██              █████            
							              ███████ ███  ███   ████          
							                   ████ ███     ██ ████        
							                     ████  █     ███ ████      
							                       ███ ██      ███ ███     
							                         ██ ██       ██ ██     
							                         ███ █ ██     █ ███    
							                          ██ █         █ ██    
							                          ██ █ ██ █     █ █    
							                         ███ █   █ █    █ █    
							     ███                ███ ██   ███    █ █    
							    ██████            ████ ██          ████    
							    ██ ██████     ██████  ██        █ ██ ██    
							    ███    ██████████   ███           █ ███    
							     ████ █        ██████          ███ ███     
							      ███    ███████             ███ ████      
							        ███  ██                 ██ ████        
							        █████  █████      ██████  ███          
							            ████               ████            
							             ████████████████████              
							                  ███████████                  
                                                 

";

        ColorRed(logo1);
    }
    static void Body()
    {
        string logo1 = @"                                                                                                                                                                                               
				                                              █████    ██   █  █████           
				                                             ███      ███      █  ████         
				                                           ███ █ █ ██                ███       
				                                          ██   █ █ █ ████   █  █  █    ██      
				                                          █   ██ █ █       █  █  █      ██     
				                                         ██         ███  █  █   █        ██    
				                                        ██                ██              █    
				                                        ██  █ █ ██  █    █     █        █ ██   
				                                        ██  █ █     █ ███  █   ██          ██  
				                                        ██ █   ██   ███ ███     ██         ██  
				                                        ██ █ █ ██              █ █         ██  
				                                        ██ █   ██              █ █  ██      ██ 
				                                        ██ █ ████                            █ 
				                                         █   █ ██               █ █ ██       █ 
				                             ████████    █ ██  █                █ █  ██ █  █ █ 
				                         ██████    ███████ ██ █                 █ █      █  ██ 
				                    ████████    █    █████    ████              █ █       █ ██ 
				                  ██ ███                          ███           █ █       █ █  
				     ██████   ████  ██              ██        ██    ██          █ █       █ █  
				     ██████████   █  ███         ██████               █████     █ █       █ █  
				       ██  ███    ██    █     █████   ████                █     █ ██      █ █  
				     █         █████████   █████         █                ██       ██     █ ██ 
				     ██                   ███           ██                 ████      ████    █ 
				      ████              ██         ██████                                ███   
				        ████            ██       █              ████████████        █████    █ 
				          ███     █      ███ ██    ████████████████████████████  █████  ██████ 
				            ██████████     █   ████     ████████             █████             
				     ████████                    █████████████████████████████████████████████ 
				     ███    ███████████    ███████████████████████████████████████████████████                                                                        
                                                                                                                          	                                                                                     
                                                                                     
";
        ColorRed(logo1);
    }
    static void Spirit()
    {
        string logo1 = @"                                                                                                                                 
																		                                               
							                ███       ██                   
							              ██   ████   █   ██               
							            ██   ██████ █████  █               
							           █   ███  ███ ██████  █              
							       ███   ████ ███    ███ ███  ██           
							     █     ████████        ███████   ███       
							     █      ██ █       █      ██████    ██     
							      ██             ████                 █    
							  █     ███  █                           ██    
							  █ █      █      ███████              ██      
							   █ █     █    ██████████             ██    █ 
							  █ ██    ██    ███████ ████            █   █ █
							 █ ██     █     ███  ██████    ████████     █ █
							 █ █     █      ██  █████     █            █ █ 
							 █ █     █     ███  ███     ██            █ █  
							 █ █     █     ██  ███     █          ████ █   
							 █ ██    █      █  ███    ██       ████████    
							  █ █    █      █  ██     █       ███          
							  ███    █     ██ ███     █      █ ██          
							    ███  █   ██████       █      █ █           
							         █  ██████       █      █ █            
							         █     █       ██       ███            
							          █         ██                         
							            ██    ██                           
										  ████                                                                           
   

";
        ColorRed(logo1);
    }
    static void Symbol()
    {
        string logo1 = @"                                                                                                                                                                                                  
						                      █               █                       
						                      ███            ███                      
						                      █  ██        ██ █ ██                    
						                     ███    ██    █   █   █                   
						                   ██ █  ██     ██    █    ██                 
						                 ██   █    ██     ███ █  ██                   
						                  ██  █   ██         ███                      
						                    █████            ███                      
						                      █            ██ █ ██                    
						                      █           █   █   █                   
						                      █         ██    █    ██                 
						                                                              
						                                                              
						           ███         █             ███        ██ █ ██       
						            █ ██        ██         ██  ██         ███         
						            █    ██       █       ██     ██       ███         
						     ██     █     █        ██   ██  ██          ██ █ ██       
						       ██   █  ██            █ ██     ██      ██   █   █      
						          █████               ██             ██    █   ██     
						          ████              ██  ██              █  █ ██       
						        ██  █  ██          ██    ██               ███         
						     ███    █     ██      ██       ██            █████        
						            █           ██          ██         ██  █  ██      
						            █           █             █            █          


";
        ColorRed(logo1);
    }
    static void Cryptic()
    {
        string logo1 = @"                                                                                                                                                                                   
						          █         █          ██     █      ███████      
						     █    ██  ████  █       ███       █   █  █       ██   
						       █      █     █      ██  █      █  ████ █   ██████  
						   █ █    █    █ █  █    ██    ███    █       ██ █        
						   ██ █   ██ █ ████ █   ██        █   █ ██     ███    ██  
						                    █   ██    █   █   █     ██    ███     
						    █ ██ ███  ███   █    ██    ████   █     ████████      
						          ██   █    █      █████      █     █    █ █      
						                    █                 █  █                
						   █  ████          █                 █                   
						          █████  █  █  ██  ████  ███  █        ███        
						   ████        ██ █ █ ██████  ████ ██ █       █████       
						        ███     ███ █ █  █      ███ █ █     ██    ██      
						            █ █ ██  █ █ █         █ █ █  ███        ████  
						      ██████   ██   █ ███  ██████ ███ █  ████      ████   
						    ███    █████  █ █                 █     ███  ███      
						    ███             █   ██ ████████   █       ████        
						       ███████      █   █ █ █ █ █  █  █         █         
						                                                                                             
                                                              

";
        ColorRed(logo1);
    }
    static void Door()
    {
        string logo1 = @"                                                         
						                        █████████                        
						                      ██         ██                      
						                 █████             █████                 
						               ██    █                  ██               
						             ██      █ █         █ █      ███            
						           █  █      █  ███  ████  █      █  ██          
						          █   █   ██  █     █     █ █ █   █   █          
						         ██    ██     ██ █     █ ██     ██    ██         
						        █    ██ █        ██   ██        █ ██    █        
						       █          █    ███     ███    █          █       
						      ██  ███       ███   █████   ███       ██   ██      
						      ██      ██  ██                 ██  ██      ██      
						      █         ██     █    █          ██         █      
						      █ ██     ██           █    █      ██     ██ █      
						      █     █ █             █             █ █     █      
						      █       █ ███ █████   █   █████ ███ █       █      
						      █       █           █ █ █           █       █      
						      █ ████ ██  █████████  █  ██████████ ██ ████ █      
						      █       ███  █        █        █  ███       █      
						      █       █        ███  █  ███        █       █      
						      ██ ███  █       █   █ █ █   █       █  ███ ██      
						      █       █        █ █  █  █ █   █    █       █      
						      █       █        █ █  █  █ █        █       █      
						      █       █       ██ ██ █ ██ ██       █       █      
						      █████████             █             █████████      
						      █       █ ███ █████   █   █████ ███ █       █      
						      █       █           █ █ █           █       █      
						      █       █  █████████  █  █████████  █       █      
						      ██     ████  █        █        █  ████      █      
						      █       █             █             █       █      
						      █       █████████████████████████████       █      
						      ██████████                         ██████████      
						                                                         

";
        ColorRed(logo1);
    }
    static void DoorOpen()
    {
        string logo1 = @"                                                                                                                       
							 ____________________________________________
							|__||  ||___||  |_|___|___|__|  ||___||  ||__|
							||__|  |__|__|  |___|___|___||  |__|__|  |__||
							|__||  ||___||  |_|___|___|__|  ||___||  ||__|
							||__|  |__|__|  |    || |    |  |__|__|  |__||
							|__||  ||___||  |    || |    |  ||___||  ||__|
							||__|  |__|__|  |    || |    |  |__|__|  |__||
							|__||  ||___||  |    || |    |  ||___||  ||__|
							||__|  |__|__|  |    || |    |  |__|__|  |__||
							|__||  ||___||  |   O|| |O   |  ||___||  ||__|
							||__|  |__|__|  |    || |    |  |__|__|  |__||
							|__||  ||___||  |    || |    |  ||___||  ||__|
							||__|  |__|__|__|____||_|____|  |__|__|  |__||
							|LLL|  |LLLLL|______________||  |LLLLL|  |LLL|
							|LLL|  |LLL|______________|  |  |LLLLL|  |LLL|
							|LLL|__|L|______________|____|__|LLLLL|__|LLL|                         
                                                                                                                                                

";
        ColorRed(logo1);
    }
    static void Breath()
    {
        int top = Console.WindowHeight - 6;
        int left = 45;
        Console.SetCursorPosition(left, top);

        Console.Write("Hold the B key to breath. ");
        Console.Write("[");
        int total = 50;
        int count = 0;

        while (count < total)
        {

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.B)
            {
                count++;
                int progress = (int)((double)count / total * 100);
                Console.Write(" ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("".PadLeft(count, '█'));
                Console.ResetColor();
                Console.Write("".PadLeft(total - count, ' '));
                Console.Write($"] {progress}%");
                Console.CursorLeft = 72;

            }
        }

    }
    static void Summon()
    {
        int top = Console.WindowHeight - 6;
        int left = 45;
        Console.SetCursorPosition(left, top);

        Console.Write("Hold the SpaceBar key to summon. ");
        Console.Write("[");
        int total = 50;
        int count = 0;

        while (count < total)
        {

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.Spacebar)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                count++;
                int progress = (int)((double)count / total * 100);
                Console.Write(" ");
                Console.Write("".PadLeft(count, '█'));
                Console.ResetColor();
                Console.Write("".PadLeft(total - count, ' '));
                Console.Write($"] {progress}%");
                Console.CursorLeft = 79;

            }
        }

    }
    static void Hallway()
    {
        string logo1 = @"


                                                          
							 _____________________________________________
							|.'',        			          ,''.|
							|.'.'',                                 ,''.'.|
							|.'.'.'',                             ,''.'.'.|
							|.'.'.'.'',                         ,''.'.'.'.|
							|.'.'.'.'.|                         |.'.'.'.'.|
							|.'.'.'.'.|===;                 ;===|.'.'.'.'.|
							|.'.'.'.'.|:::|',             ,'|:::|.'.'.'.'.|
							|.'.'.'.'.|---|'.|, _______ ,|.'|---|.'.'.'.'.|
							|.'.'.'.'.|:::|'.|'|???????|'|.'|:::|.'.'.'.'.|
							|,',',',',|---|',|'|???????|'|,'|---|,',',',',|
							|.'.'.'.'.|:::|'.|'|???????|'|.'|:::|.'.'.'.'.|
							|.'.'.'.'.|---|','   /%%%\   ','|---|.'.'.'.'.|
							|.'.'.'.'.|===:'    /%%%%%\    ':===|.'.'.'.'.|
							|.'.'.'.'.|%%%%%%%%%%%%%%%%%%%%%%%%%|.'.'.'.'.|
							|.'.'.'.','       /%%%%%%%%%\       ','.'.'.'.|
							|.'.'.','        /%%%%%%%%%%%\        ','.'.'.|
							|.'.','         /%%%%%%%%%%%%%\         ','.'.|
							|.','          /%%%%%%%%%%%%%%%\          ','.|
							|;____________/%%%%%%%%%%%%%%%%%\____________;|
                                                          


        ";
        ColorRed(logo1);
    }
    static void Road()
    {
        string logo1 = @"
        
        


                                         			 ___                 
						               _/XXX\
						_             /XXXXXX\_                                    __
						X\__    __   /X XXXX XX\                          _       /XX\__      ___
						    \__/  \_/__       \ \                       _/X\__   /XX XXX\____/XXX\
						  \  ___   \/  \_      \ \               __   _/      \_/  _/  -   __  -  \__/
						 ___/   \__/   \ \__     \\__           /  \_//  _ _ \  \     __  /  \____//
						/  __    \  /     \ \_   _//_\___     _/    //           \___/  \/     __/
						__/_______\________\__\_/________\_ _/_____/_____________/_______\____/_______
						                                  /|\	
						                                 / | \
						                                /  |  \
						                               /   |   \
						                              /    |    \
						                             /     |     \
						                            /      |      \
						                           /       |       \
						                          /        |        \
						                         /         |         \
                                                          


";
        ColorRed(logo1);
    }
    static void LawEnd1()
    {
        string text = "\n\n\t\t\t\tYou chose to investigate the body.  \n\n\t\t\t\tYou help spirit uncover the truth, bringing peace to their troubled spirits.   \n\n\t\t\t\tLeaving the calm cabin, you sense a feeling of success.";
        string text2 = "\n\n\n\t\t\t\tRating: 100/100";
        string text3A = "\n\n\n\n\n\n\n\n\t\t\t\tPress [enter] to exit.";

        Console.Clear();
        ENDsong();
        End();
        Console.WriteLine(text);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(text2);
        Console.ResetColor();


        Console.WriteLine(text3A);


        Console.ReadKey();
        Console.Clear();

        Exit();

    }
    static void LawEnd2()
    {

        string text = "\n\n\t\t\t\tDisappointed.  \n\n\t\t\t\tYou were so close on revealing the truth.   \n\n\t\t\t\tBut you got overwhelmed, you decide to flee, leaving the spirits to face their destiny alone.  \n\n\t\t\t\tThe weight of guilt stays with you, haunting every moment.  ";
        string text2 = "\n\n\n\t\t\t\tRating: 10/100";
        string text3A = "\n\n\n\n\n\n\n\n\t\t\t\tPress [enter] to exit.";

        Console.Clear();
        ENDsong();
        End();
        Console.WriteLine(text);


        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(text2);
        Console.ResetColor();


        Console.WriteLine(text3A);


        Console.ReadKey();
        Console.Clear();

        Exit();

    }
    static void LawEnd4()
    {
        string text = "\n\n\t\t\t\tYou escape the cabin.  \n\n\t\t\t\tThe encounter leaves an enduring mark on your mind.  \n\n\t\t\t\tEven though you're glad you got away.  \n\n\t\t\t\tThe scary memories from the cabin will always haunt your dreams.  ";
        string text2 = "\n\n\n\t\t\t\tRating: 30/100";
        string text3A = "\n\n\n\n\n\n\n\n\t\t\t\tPress [enter] to exit.";

        Console.Clear();
        ENDsong();
        End();
        Console.WriteLine(text);


        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(text2);
        Console.ResetColor();


        Console.WriteLine(text3A);


        Console.ReadKey();
        Console.Clear();

        Exit();

    }
    static void LawEnd3()
    {
        string text = "\n\n\t\t\t\tYou figure out the symbols.  \n\n\t\t\t\tBroke the cabin curse.  \n\n\t\t\t\tYou worked very hard to understand the symbols, just like Indiana Jones. ";
        string text2 = "\n\n\n\t\t\t\tRating: 80/100";
        string text3A = "\n\n\n\n\n\n\n\n\t\t\t\tPress [enter] to exit.";

        Console.Clear();
        ENDsong();
        End();
        Console.WriteLine(text);


        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(text2);
        Console.ResetColor();


        Console.WriteLine(text3A);

        
        Console.ReadKey();
        Console.Clear();

        Exit();
    }
    static void LawEnd5()
    {
        string text = "\n\n\t\t\t\tYou were a coward. \n\n\t\t\t\tBut it was a smart choice.    \n\n\t\t\t\tWhy investigate the body of someone you don't know?  \n\n\t\t\t\tThe scary memories from the cabin will always haunt your dreams.  ";
        string text2 = "\n\n\n\t\t\t\tRating: 50/100";
        string text3A = "\n\n\n\n\n\n\n\n\t\t\t\tPress [enter] to exit.";

        Console.Clear();
        ENDsong();
        End();
        Console.WriteLine(text);


        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(text2);
        Console.ResetColor();


        Console.WriteLine(text3A);


        Console.ReadKey();
        Console.Clear();

        Exit();

    }
    static void HorrorProgram()
    {
        Console.Clear();
        Console.CursorTop = 18; Console.CursorLeft = 49; Console.WriteLine("\t    This action will have consequences...");
        Console.WriteLine();
        int totalProgress = 100;

        for (int i = 0; i <= totalProgress; i++)
        {
            DrawProgressBar(i, totalProgress);
            Thread.Sleep(15); // Simulate some work being done
            Console.SetCursorPosition(0, Console.CursorTop);
        }

        Console.Clear();

        //sounds!!
        SoundPlayer background = new SoundPlayer("background.wav");
        SoundPlayer doorOpen = new SoundPlayer("doorcreak.wav");
        SoundPlayer slam = new SoundPlayer("doorslam.wav");
        SoundPlayer doorClose = new SoundPlayer("doorclose.wav");
        SoundPlayer laugh = new SoundPlayer("evillaugh.wav");
        SoundPlayer ambience = new SoundPlayer("spookyatmosphere.wav");
        SoundPlayer wind = new SoundPlayer("wind.wav");
        SoundPlayer whisper = new SoundPlayer("whisper.wav");
        SoundPlayer ghost = new SoundPlayer("ghost.wav");
        SoundPlayer footstep = new SoundPlayer("footsteps.wav");
        SoundPlayer whisper2 = new SoundPlayer("whisper2.wav");
        SoundPlayer shift = new SoundPlayer("shift.wav");
        SoundPlayer whisper3 = new SoundPlayer("whisper3.wav");
        SoundPlayer breath = new SoundPlayer("breath.wav");

        background.PlayLooping();

        PrintSlow("Then let's play a game..");
        PrintSlow("In this game there will be choices that you can choose through the progress of the story. ");
        Forest();
        PrintSlow2("You find yourself alone on a desolate road, surrounded by dense woods. ");
        Moon();
        PrintSlow2("The moon casts an eerie glow, creating long shadows that seem to dance with the whispers of the wind. ");
        Cabin();
        PrintSlow2("As you continue your journey, you stumble upon an old, abandoned cabin that stands in ominous silence.");
        doorOpen.Play();
        PrintSlow("You slowly open the door ...");
        background.PlayLooping();
        Body();
        PrintSlow2("A lifeless body lay there, its vacant gaze locking with mine in a silent, chilling surprise.");
        int choice1 = MakeChoice("Now choose what will you do?", new string[] { "Investigate the body further", "Leave the room immediately" });

        if (choice1 == 1)
        {
            PrintSlow("Player picked to Investigate the body further.");
            PrintSlow("As you approach the body, you notice a faded photograph clutched in its cold, stiff hand. ");
            FamPic();
            PrintSlow2("The photograph reveals a family - a mother, father, and a child. ");
            PrintSlow("Suddenly, the temperature drops even more, and the room is plunged into darkness.");
            whisper.Play();
            PrintSlow("Faint whispers surround you, and the air is heavy with sorrow.");
            background.PlayLooping();

            int choice2 = MakeChoice("Now choose what will you do?", new string[] { "Summon the spirit and ask about its story.", "Quickly leave the room and ignore the strange occurrences." });
            if (choice2 == 1)
            {
                PrintSlow("Player picked to summon the spirit and ask about its story.");
                Spirit();
                Summon();
                laugh.Play();
                PrintSlow2("You summon the courage to address the spirit.");
                wind.Play();
                PrintSlow("A cold wind sweeps through the room, and the spirit begins to materialize. ");
                background.PlayLooping();
                PrintSlow("It reveals that it was murdered by its own family in a fit of madness, and its soul has been trapped in the cabin ever since. ");
                PrintSlow("The spirit begs for your help to find peace.");

                int choice3 = MakeChoice("Now choose what will you do?", new string[] { "Agree to help the spirit find peace.", "Refuse and try to escape the cabin." });
                if (choice3 == 1)
                {
                    PrintSlow("Player agree to help the spirit find peace.");
                    PrintSlow("The spirit leads you through the cabin, guiding you to uncover the truth behind its tragic demise. ");
                    PrintSlow("As you delve deeper, you encounter paranormal phenomena, but you press on. ");
                    PrintSlow("Eventually, you discover a hidden room containing evidence of the family's dark secrets.");

                    int choice4 = MakeChoice("Now choose what will you do?", new string[] { "Confront the family's spirits and help them find closure.", "Escape the cabin, leaving the spirits to their fate." });
                    if (choice4 == 1)
                    {
                        PrintSlow("You assist the spirits in revealing the truth, bringing closure to their tormented souls.");
                        PrintSlow("Exiting the now serene cabin, you feel a sense of accomplishment.");
                        PrintSlow("The once eerie atmosphere dissipates, and you leave the haunted cabin behind, knowing the spirits are finally at peace.");
                        Thread.Sleep(1300);
                        LawEnd1();
                    }
                    else
                    {
                        PrintSlow("Overwhelmed, you choose to escape, leaving the spirits to their fate.");
                        PrintSlow("The guilt of abandonment lingers, haunting your every moment.");
                        PrintSlow("Nightmares and the memory of the cabin's tormented spirits follow you, a constant reminder of the choice you made.");
                        Thread.Sleep(1300);
                        LawEnd2();
                    }
                }
                else
                {
                    PrintSlow("Player chose to frantically search for an exit within the dark room.");
                    PrintSlow("Panic sets in as you fumble through the darkness.");
                    whisper2.Play();
                    PrintSlow("Strange sounds echo around you, and unseen entities seem to brush against your skin.");
                    Door();
                    slam.Play();
                    PrintSlow2("Suddenly, you find a door and burst through it.");
                    background.PlayLooping();
                    PrintSlow("only to find yourself in a different part of the cabin.");
                    int choice5 = MakeChoice("Now choose what will you do?", new string[] { "Continue exploring the cabin in search of an exit.", "Try to retrace your steps and return to the room with the body." });
                    if (choice5 == 1)
                    {
                        PrintSlow("Player continue exploring the cabin in search of an exit.");
                        Hallway();
                        shift.Play();
                        PrintSlow2("The cabin seems to shift and twist as you navigate its eerie halls.");
                        whisper3.Play();
                        PrintSlow("Shadows dance in your peripheral vision, and unsettling whispers follow you.");
                        background.PlayLooping();
                        Cryptic();
                        PrintSlow2("You stumble upon a series of cryptic symbols on the walls, and a sudden realization strikes you");
                        PrintSlow("the cabin is a labyrinth designed to ensnare lost souls.");
                        int choice6 = MakeChoice("Now choose what will you do?", new string[] { "Attempt to decipher the symbols and break the cabin's curse.", "Continue wandering, hoping to stumble upon an exit by chance." });
                        if (choice6 == 1)
                        {
                            PrintSlow("Player attempt to decipher the symbols and break the cabin's curse.");
                            Symbol();
                            PrintSlow2("You spend agonizing hours unraveling the meaning behind the symbols.");
                            PrintSlow("As you decipher the final mark, the cabin trembles, and a blinding light envelops you.");
                            Road();
                            PrintSlow2("When it fades, you find yourself back on the desolate road, the cabin nowhere in sight. ");
                            Thread.Sleep(1300);
                            LawEnd3();
                        }
                        else
                        {
                            PrintSlow("The player continue to wander the cabin.");
                            Hallway();
                            footstep.Play();
                            PrintSlow2("Driven by fear and the desperate need to escape, you blindly wander the cabin's halls. ");
                            Hallway();
                            ghost.Play();
                            PrintSlow2("Each turn leads you deeper into the labyrinthine structure, the shadows becoming denser and the whispers more insistent.");
                            ghost.Stop();
                            PrintSlow("Hope dwindles as you succumb to exhaustion and despair. You resign yourself to becoming another lost soul trapped within the cabin's walls.");
                            DoorOpen();
                            PrintSlow("Suddenly, a voice cuts through the silence, clear and distinct. It guides you towards a hidden door, previously unseen.");
                            Road();
                            slam.Play();
                            PrintSlow2("You burst through, finding yourself on the familiar, desolate road outside the cabin.");
                            background.Play();
                            PrintSlow("Though physically free, the experience leaves a lasting scar on your psyche.");
                            PrintSlow("The memory of the cabin's horrors will forever haunt your dreams.");
                            Thread.Sleep(1300);
                            LawEnd4();
                        }

                    }
                    else
                    {
                        FootStep();
                        footstep.Play();
                        PrintSlow2("Player picked to retrace the footsteps.");
                        whisper2.Play();
                        PrintSlow("As you walk, the whispers return, growing louder and more menacing.");
                        wind.Play();
                        PrintSlow("A cold air brushes against your skin, sending shivers down your spine.");
                        background.PlayLooping();
                        PrintSlow("You quicken your pace, desperate to escape the unseen entities surrounding you.");
                        Door();
                        PrintSlow2("Finally, you reach the familiar doorway. Relief washes over you as you step back into the room with the body.");
                        Road();
                        PrintSlow2("You push through and find yourself back on the empty road outside the cabin.");
                        PrintSlow("In the end, it was a wise decision.");
                        PrintSlow("Going back over the steps you took, choosing not to keep exploring the cabin.");
                        PrintSlow("Because who knows what might happen if you continue.");
                        Thread.Sleep(1300);
                        LawEnd5();
                    }

                }
            }
            else
            {
                PrintSlow("You decide not to tempt fate and make a hasty exit from the room.");
                doorClose.Play();
                PrintSlow("As you turn to leave, the door slams shut with a thunderous bang.");
                PrintSlow("The room is now plunged into complete darkness, and the temperature drops drastically.");
                whisper.Play();
                PrintSlow("Whispers surround you, growing louder with each passing second");
                background.Play();
                int choice3 = MakeChoice("Now choose what will you do?", new string[] { "Frantically search for an exit within the dark room.", "Stand still and try to calm your racing heart." });
                if (choice3 == 1)
                {
                    PrintSlow("Player chose to frantically search for an exit within the dark room.");
                    PrintSlow("Panic sets in as you fumble through the darkness.");
                    whisper2.Play();
                    PrintSlow("Strange sounds echo around you, and unseen entities seem to brush against your skin.");
                    Door();
                    slam.Play();
                    PrintSlow2("Suddenly, you find a door and burst through it.");
                    background.PlayLooping();
                    PrintSlow("only to find yourself in a different part of the cabin.");
                    int choice4 = MakeChoice("Now choose what will you do?", new string[] { "Continue exploring the cabin in search of an exit.", "Try to retrace your steps and return to the room with the body." });
                    if (choice4 == 1)
                    {
                        PrintSlow("Player continue exploring the cabin in search of an exit.");
                        Hallway();
                        shift.Play();
                        PrintSlow2("The cabin seems to shift and twist as you navigate its eerie halls.");
                        whisper3.Play();
                        PrintSlow("Shadows dance in your peripheral vision, and unsettling whispers follow you.");
                        background.PlayLooping();
                        Cryptic();
                        PrintSlow2("You stumble upon a series of cryptic symbols on the walls, and a sudden realization strikes you");
                        PrintSlow("the cabin is a labyrinth designed to ensnare lost souls.");
                        int choice5 = MakeChoice("Now choose what will you do?", new string[] { "Attempt to decipher the symbols and break the cabin's curse.", "Continue wandering, hoping to stumble upon an exit by chance." });
                        if (choice5 == 1)
                        {
                            PrintSlow("Player attempt to decipher the symbols and break the cabin's curse.");
                            Symbol();
                            PrintSlow2("You spend agonizing hours unraveling the meaning behind the symbols.");
                            PrintSlow("As you decipher the final mark, the cabin trembles, and a blinding light envelops you.");
                            Road();
                            PrintSlow2("When it fades, you find yourself back on the desolate road, the cabin nowhere in sight. ");
                            Thread.Sleep(1300);
                            LawEnd3();
                        }
                        else
                        {
                            PrintSlow("The player continue to wander the cabin.");
                            Hallway();
                            footstep.Play();
                            PrintSlow2("Driven by fear and the desperate need to escape, you blindly wander the cabin's halls. ");
                            Hallway();
                            ghost.Play();
                            PrintSlow2("Each turn leads you deeper into the labyrinthine structure, the shadows becoming denser and the whispers more insistent.");
                            ghost.Stop();
                            PrintSlow("Hope dwindles as you succumb to exhaustion and despair. You resign yourself to becoming another lost soul trapped within the cabin's walls.");
                            DoorOpen();
                            PrintSlow("Suddenly, a voice cuts through the silence, clear and distinct. It guides you towards a hidden door, previously unseen.");
                            Road();
                            slam.Play();
                            PrintSlow2("You burst through, finding yourself on the familiar, desolate road outside the cabin.");
                            background.Play();
                            PrintSlow("Though physically free, the experience leaves a lasting scar on your psyche.");
                            PrintSlow("The memory of the cabin's horrors will forever haunt your dreams.");
                            Thread.Sleep(1300);
                            LawEnd4();
                        }

                    }
                    else
                    {
                        FootStep();
                        footstep.Play();
                        PrintSlow2("Player picked to retrace the footsteps.");
                        whisper2.Play();
                        PrintSlow("As you walk, the whispers return, growing louder and more menacing.");
                        wind.Play();
                        PrintSlow("A cold air brushes against your skin, sending shivers down your spine.");
                        background.PlayLooping();
                        PrintSlow("You quicken your pace, desperate to escape the unseen entities surrounding you.");
                        Door();
                        PrintSlow2("Finally, you reach the familiar doorway. Relief washes over you as you step back into the room with the body.");
                        Road();
                        PrintSlow2("You push through and find yourself back on the empty road outside the cabin.");
                        PrintSlow("In the end, it was a wise decision.");
                        PrintSlow("Going back over the steps you took, choosing not to keep exploring the cabin.");
                        PrintSlow("Because who knows what might happen if you continue.");
                        Thread.Sleep(1300);
                        LawEnd5();
                    }
                }
                else
                {
                    PrintSlow("Player picked to stand still and breath.");
                    breath.Play();
                    Breath();
                    PrintSlow("You stand still, trying to breath and calm your racing heart in the darkness.");
                    PrintSlow("And you continue to search for an exit.");
                    doorOpen.Play();
                    PrintSlow("The room gradually brightens, and the door creaks open.");
                    PrintSlow("Only to find yourself in a different part of the cabin.");
                    int choice4 = MakeChoice("Now choose what will you do?", new string[] { "Continue exploring the cabin in search of an exit.", "Try to retrace your steps and return to the room with the body." });
                    if (choice4 == 1)
                    {
                        PrintSlow("Player continue exploring the cabin in search of an exit.");
                        Hallway();
                        shift.Play();
                        PrintSlow2("The cabin seems to shift and twist as you navigate its eerie halls.");
                        whisper3.Play();
                        PrintSlow("Shadows dance in your peripheral vision, and unsettling whispers follow you.");
                        background.PlayLooping();
                        Cryptic();
                        PrintSlow2("You stumble upon a series of cryptic symbols on the walls, and a sudden realization strikes you");
                        PrintSlow("the cabin is a labyrinth designed to ensnare lost souls.");
                        int choice5 = MakeChoice("Now choose what will you do?", new string[] { "Attempt to decipher the symbols and break the cabin's curse.", "Continue wandering, hoping to stumble upon an exit by chance." });
                        if (choice5 == 1)
                        {
                            PrintSlow("Player attempt to decipher the symbols and break the cabin's curse.");
                            Symbol();
                            PrintSlow2("You spend agonizing hours unraveling the meaning behind the symbols.");
                            PrintSlow("As you decipher the final mark, the cabin trembles, and a blinding light envelops you.");
                            Road();
                            PrintSlow("When it fades, you find yourself back on the desolate road, the cabin nowhere in sight. ");
                            Thread.Sleep(1300);
                            LawEnd3();
                        }
                        else
                        {
                            PrintSlow("The player continue to wander the cabin.");
                            Hallway();
                            footstep.Play();
                            PrintSlow2("Driven by fear and the desperate need to escape, you blindly wander the cabin's halls. ");
                            Hallway();
                            ghost.Play();
                            PrintSlow2("Each turn leads you deeper into the labyrinthine structure, the shadows becoming denser and the whispers more insistent.");
                            ghost.Stop();
                            PrintSlow("Hope dwindles as you succumb to exhaustion and despair. You resign yourself to becoming another lost soul trapped within the cabin's walls.");
                            DoorOpen();
                            PrintSlow("Suddenly, a voice cuts through the silence, clear and distinct. It guides you towards a hidden door, previously unseen.");
                            Road();
                            slam.Play();
                            PrintSlow2("You burst through, finding yourself on the familiar, desolate road outside the cabin.");
                            background.Play();
                            PrintSlow("Though physically free, the experience leaves a lasting scar on your psyche.");
                            PrintSlow("The memory of the cabin's horrors will forever haunt your dreams.");
                            Thread.Sleep(1300);
                            LawEnd4();
                        }

                    }
                    else
                    {
                        FootStep();
                        footstep.Play();
                        PrintSlow2("Player picked to retrace the footsteps.");
                        whisper2.Play();
                        PrintSlow("As you walk, the whispers return, growing louder and more menacing.");
                        wind.Play();
                        PrintSlow("A cold air brushes against your skin, sending shivers down your spine.");
                        background.PlayLooping();
                        PrintSlow("You quicken your pace, desperate to escape the unseen entities surrounding you.");
                        Door();
                        PrintSlow2("Finally, you reach the familiar doorway. Relief washes over you as you step back into the room with the body.");
                        Road();
                        PrintSlow2("You push through and find yourself back on the empty road outside the cabin.");
                        PrintSlow("In the end, it was a wise decision.");
                        PrintSlow("Going back over the steps you took, choosing not to keep exploring the cabin.");
                        PrintSlow("Because who knows what might happen if you continue.");
                        Thread.Sleep(1300);
                        LawEnd5();
                    }
                }
            }

        }
        else
        {
            PrintSlow("You decide not to tempt fate and make a hasty exit from the room.");
            doorClose.Play();
            PrintSlow("As you turn to leave, the door slams shut with a thunderous bang.");
            PrintSlow("The room is now plunged into complete darkness, and the temperature drops drastically.");
            whisper.Play();
            PrintSlow("Whispers surround you, growing louder with each passing second");
            background.Play();
            int choice2 = MakeChoice("Now choose what will you do?", new string[] { "Frantically search for an exit within the dark room.", "Stand still and try to breath and calm your racing heart." });
            if (choice2 == 1)
            {
                PrintSlow("Player chose to frantically search for an exit within the dark room.");
                PrintSlow("Panic sets in as you fumble through the darkness.");
                whisper2.Play();
                PrintSlow("Strange sounds echo around you, and unseen entities seem to brush against your skin.");
                Door();
                slam.Play();
                PrintSlow2("Suddenly, you find a door and burst through it.");
                background.PlayLooping();
                PrintSlow("only to find yourself in a different part of the cabin.");
                int choice3 = MakeChoice("Now choose what will you do?", new string[] { "Continue exploring the cabin in search of an exit.", "Try to retrace your steps and return to the room with the body." });
                if (choice3 == 1)
                {
                    PrintSlow("Player continue exploring the cabin in search of an exit.");
                    Hallway();
                    shift.Play();
                    PrintSlow2("The cabin seems to shift and twist as you navigate its eerie halls.");
                    whisper3.Play();
                    PrintSlow("Shadows dance in your peripheral vision, and unsettling whispers follow you.");
                    background.PlayLooping();
                    Cryptic();
                    PrintSlow2("You stumble upon a series of cryptic symbols on the walls, and a sudden realization strikes you");
                    PrintSlow("the cabin is a labyrinth designed to ensnare lost souls.");
                    int choice4 = MakeChoice("Now choose what will you do?", new string[] { "Attempt to decipher the symbols and break the cabin's curse.", "Continue wandering, hoping to stumble upon an exit by chance." });
                    if (choice4 == 1)
                    {
                        PrintSlow("Player attempt to decipher the symbols and break the cabin's curse.");
                        Symbol();
                        PrintSlow2("You spend agonizing hours unraveling the meaning behind the symbols.");
                        PrintSlow("As you decipher the final mark, the cabin trembles, and a blinding light envelops you.");
                        Road();
                        PrintSlow2("When it fades, you find yourself back on the desolate road, the cabin nowhere in sight. ");
                        Thread.Sleep(1300);
                        LawEnd3();
                    }
                    else
                    {
                        PrintSlow("The player continue to wander the cabin.");
                        Hallway();
                        footstep.Play();
                        PrintSlow2("Driven by fear and the desperate need to escape, you blindly wander the cabin's halls. ");
                        Hallway();
                        ghost.Play();
                        PrintSlow2("Each turn leads you deeper into the labyrinthine structure, the shadows becoming denser and the whispers more insistent.");
                        ghost.Stop();
                        PrintSlow("Hope dwindles as you succumb to exhaustion and despair. You resign yourself to becoming another lost soul trapped within the cabin's walls.");
                        DoorOpen();
                        PrintSlow("Suddenly, a voice cuts through the silence, clear and distinct. It guides you towards a hidden door, previously unseen.");
                        Road();
                        slam.Play();
                        PrintSlow2("You burst through, finding yourself on the familiar, desolate road outside the cabin.");
                        background.Play();
                        PrintSlow("Though physically free, the experience leaves a lasting scar on your psyche.");
                        PrintSlow("The memory of the cabin's horrors will forever haunt your dreams.");
                        Thread.Sleep(1300);
                        LawEnd4();
                    }

                }
                else
                {
                    FootStep();
                    footstep.Play();
                    PrintSlow2("Player picked to retrace the footsteps.");
                    whisper2.Play();
                    PrintSlow("As you walk, the whispers return, growing louder and more menacing.");
                    wind.Play();
                    PrintSlow("A cold air brushes against your skin, sending shivers down your spine.");
                    background.PlayLooping();
                    PrintSlow("You quicken your pace, desperate to escape the unseen entities surrounding you.");
                    Door();
                    PrintSlow2("Finally, you reach the familiar doorway. Relief washes over you as you step back into the room with the body.");
                    Road();
                    PrintSlow2("You push through and find yourself back on the empty road outside the cabin.");
                    PrintSlow("In the end, it was a wise decision.");
                    PrintSlow("Going back over the steps you took, choosing not to keep exploring the cabin.");
                    PrintSlow("Because who knows what might happen if you continue.");
                    Thread.Sleep(1300);
                    LawEnd5();
                }
            }
            else
            {
                PrintSlow("Player picked to stand still and breath.");
                breath.Play();
                Breath();
                PrintSlow("You stand still, trying to breath and calm your racing heart in the darkness.");
                PrintSlow("And you continue to search for an exit.");
                doorOpen.Play();
                PrintSlow("The room gradually brightens, and the door creaks open.");
                PrintSlow("Only to find yourself in a different part of the cabin.");
                int choice3 = MakeChoice("Now choose what will you do?", new string[] { "Continue exploring the cabin in search of an exit.", "Try to retrace your steps and return to the room with the body." });
                if (choice3 == 1)
                {
                    PrintSlow("Player continue exploring the cabin in search of an exit.");
                    Hallway();
                    shift.Play();
                    PrintSlow2("The cabin seems to shift and twist as you navigate its eerie halls.");
                    whisper3.Play();
                    PrintSlow("Shadows dance in your peripheral vision, and unsettling whispers follow you.");
                    background.PlayLooping();
                    Cryptic();
                    PrintSlow2("You stumble upon a series of cryptic symbols on the walls, and a sudden realization strikes you");
                    PrintSlow("the cabin is a labyrinth designed to ensnare lost souls.");
                    int choice4 = MakeChoice("Now choose what will you do?", new string[] { "Attempt to decipher the symbols and break the cabin's curse.", "Continue wandering, hoping to stumble upon an exit by chance." });
                    if (choice4 == 1)
                    {
                        PrintSlow("Player attempt to decipher the symbols and break the cabin's curse.");
                        Symbol();
                        PrintSlow2("You spend agonizing hours unraveling the meaning behind the symbols.");
                        PrintSlow("As you decipher the final mark, the cabin trembles, and a blinding light envelops you.");
                        Road();
                        PrintSlow("When it fades, you find yourself back on the desolate road, the cabin nowhere in sight. ");
                        Thread.Sleep(1300);
                        LawEnd3();
                    }
                    else
                    {
                        PrintSlow("The player continue to wander the cabin.");
                        Hallway();
                        footstep.Play();
                        PrintSlow2("Driven by fear and the desperate need to escape, you blindly wander the cabin's halls. ");
                        Hallway();
                        ghost.Play();
                        PrintSlow2("Each turn leads you deeper into the labyrinthine structure, the shadows becoming denser and the whispers more insistent.");
                        ghost.Stop();
                        PrintSlow("Hope dwindles as you succumb to exhaustion and despair. You resign yourself to becoming another lost soul trapped within the cabin's walls.");
                        DoorOpen();
                        PrintSlow("Suddenly, a voice cuts through the silence, clear and distinct. It guides you towards a hidden door, previously unseen.");
                        Road();
                        slam.Play();
                        PrintSlow2("You burst through, finding yourself on the familiar, desolate road outside the cabin.");
                        background.Play();
                        PrintSlow("Though physically free, the experience leaves a lasting scar on your psyche.");
                        PrintSlow("The memory of the cabin's horrors will forever haunt your dreams.");
                        Thread.Sleep(1300);
                        LawEnd4();
                    }

                }
                else
                {
                    FootStep();
                    footstep.Play();
                    PrintSlow2("Player picked to retrace the footsteps.");
                    whisper2.Play();
                    PrintSlow("As you walk, the whispers return, growing louder and more menacing.");
                    wind.Play();
                    PrintSlow("A cold air brushes against your skin, sending shivers down your spine.");
                    background.PlayLooping();
                    PrintSlow("You quicken your pace, desperate to escape the unseen entities surrounding you.");
                    Door();
                    PrintSlow2("Finally, you reach the familiar doorway. Relief washes over you as you step back into the room with the body.");
                    Road();
                    PrintSlow2("You push through and find yourself back on the empty road outside the cabin.");
                    PrintSlow("In the end, it was a wise decision.");
                    PrintSlow("Going back over the steps you took, choosing not to keep exploring the cabin.");
                    PrintSlow("Because who knows what might happen if you continue.");
                    Thread.Sleep(1300);
                    LawEnd5();
                }
            }
        }
    }

    //mimoy ass
    static void PrintColoredText(string text)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        PrintCenter(text);
        Console.ResetColor();
    }
    static void clear()
    {
        Console.ReadLine(); Console.Clear();
    }
    int lives = 3;
    int score = 0;
    static void mimoy()
    {
        Console.Clear();
        Console.CursorTop = 18; Console.CursorLeft = 49; Console.WriteLine("\t    This action will have consequences...");
        Console.WriteLine();
        int totalProgress = 100;

        for (int i = 0; i <= totalProgress; i++)
        {
            DrawProgressBar(i, totalProgress);
            Thread.Sleep(15); // Simulate some work being done
            Console.SetCursorPosition(0, Console.CursorTop);
        }

        Console.Clear();

        string textToAlign = "1 of 3";
        string textToAlign2 = "█ - -";

        Console.ForegroundColor = ConsoleColor.DarkRed;
        AlignTextRight(textToAlign);
        AlignTextRight(textToAlign2);
        Console.ResetColor();

        PrintCenter("Interesting choice..."); clear();

        Abyss();
        PrintCenter("You know, in life, we often encounter moments that force us to look into the abyss. Today, you faced such a moment, didn't you? ");
        clear();

        Skull();
        PrintCenter("It was there, right in front of you—an undeniable truth wrapped in the stillness of ");
        PrintColoredText("death.");
        PrintCenter(" And what did you do? You turned away, let fear be your guide."); clear();
        PrintCenter("Avoiding a"); PrintColoredText("dead");
        PrintCenter("body out of fear might be viewed as morally questionable, an act of turning away from responsibility and empathy, earning the label of ");
        PrintColoredText("evil "); PrintCenter("in some perspective."); clear();

        illuminati();
        PrintCenter("Hmmm... how about we play a game?"); clear();
        PrintCenter("I want to test how much you know about the difference between ");
        PrintColoredText("FEAR "); PrintCenter("and"); PrintColoredText("EVIL."); clear();

        string textToAlign3a = "2 of 3";
        string textToAlign3 = "█ █ -";
        PrintCenter("The mechanics are simple, i'll give you 8 riddles, and you'll guess whether it's ");
        PrintColoredText("FEAR "); PrintCenter("or "); PrintColoredText("EVIL.");
        PrintCenter("You only have four lives.");
        PrintCenter("Let's begin.");
        PrintCenter("");


        Console.ForegroundColor = ConsoleColor.DarkRed;
        AlignTextRight(textToAlign3a);
        AlignTextRight(textToAlign3);
        Console.ResetColor();

        int lives = 3;
        int score = 0;

        for (int i = 0; i < 8; i++)
        {


            Console.WriteLine($"\nRiddle {i + 1}: {riddles[i]}");
            Console.Write("Your answer: ");
            string userAnswer = Console.ReadLine();

            if (CheckAnswer(i, userAnswer))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\tCorrect! Well done!");
                Console.ResetColor();
                score++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\t\tIncorrect. You lose a life.");
                Console.ResetColor();
                lives--;

                if (lives == 0)
                {
                    string logo1 = @"
                        █████████   ███  █  █████████████████████                                ███████████████████████████
                        ██████████ █████████████████████████                                      ██████████████████████████
                        ███████████████████ ████████████████                                         ███████████████████████
                        ███████████████████ █ ███████████                                            ███████████████████████
                        █████████████████ ██   ████████                                            ██ ██████████████████████
                        ████████████ ██ ██████████████                                              ██ █████████████████████
                        ██████████████ █   ██████████                                                    ███████████████████
                        ██████████████  ████████████                                                       █████████████████
                         ██████████████████ █████████                                                        ██████ ████████
                        █████████████████  ██████████                                     █   ██████          ██████ ███████
                        █████████████████████████████                                      ███   █████          ████ █ █████
                        ████████████████████████████                                      ██   ██   ██            ███ ██████
                         ███████████████████████████           ███████                    ██        █             ███ ██████
                         ███████████████████████████       █ ████    ██                   █████  ███               █████████
                        █████████████████████████████       ███   ██  █                      ████                  █████████
                        █████████████████████████████        ███     ██                                              ███████
                        █████████████████████████████         ████████                                               ███████
                        █████████████████████████████                                                                ███████
                        █████████████████████████████                                                                 ██████
                        █████████████████████████████                                                                 ██████
                        ████████████████████████████                                                                   █████
                        ████████████████████████████                                                                    ████
                        ████████████████████████████                                                         █          ████
                        █████████████████████████████                                                     ███           ████
                        █████████  ███████████████████                                                 █████            ████
                        ██████████████████████████████                                              ███████             ████
                        ██ █████████████████████████████         ███                             █████████             █████
                        █████████████████████████████████           ████                █      █   █████              ██████
                        ███████████████████████████████████           █████  ████                 ████               ███████
                        █ ██████ ███████████████████████████          ██████                    ████ █               ███████
                        ██████████████████████████████████████          █████                ████ █                 ████████
                        ███████████████████████████████████ ████          ████  █      ███  ██  ██                 ████  ███
                        ████████████████████████████████ ██  ██ ███        ████   █████        █ ██               ████  █ ██
                        ███████████████████████████████   ██ ██    ██        ████          ████ ██  █         ████████  █ ██
                        ███████████████████████████████   ███ ██     ███      ████████████    ███ ███       █████████   █ ██
                        ███████████           ████████     ██ ██        ████   ████████████████ ███        ████████       █ ";
                    Console.WriteLine("");
                    clear();
                    jump();
                    Console.WriteLine(logo1);
                    

                    break;

                }
            }
        }
        string textToAlign4a = "3 of 3";
        string textToAlign4 = "█ █ █";

        Console.ForegroundColor = ConsoleColor.DarkRed;
        AlignTextRight(textToAlign4a);
        AlignTextRight(textToAlign4);
        Console.ResetColor();

        if (score == 8)
        {
            Console.WriteLine("\n\t\tCongratulations! You answered all riddles correctly and won the game!");
            Thread.Sleep(2000);
            EndofPathMimoy();
        }
        else
        {
            Console.WriteLine($"\n\t\tYour final score: {score} out of 8. Better luck next time!");
            Thread.Sleep(2000);
            EndofPathMimoy();
        }

    }
    static bool CheckAnswer(int number, string answer)
    {
        return answer.ToLower() == answers[number].ToLower();
    }
    static string[] riddles =
    {
        "In moonlit nights where shadows blend,\r\nI whisper dread that refuses to end.\r\nWhat am I?",
        "A cold breeze, a haunting sound,\r\nIn the dark, where my whispers abound.\r\nWhat am I?",
        "Through alleys where shadows whisper sin,\r\nI weave a tale where the devil begins.\r\nWhat am I?",
        "A rustle in the leaves, a ghostly trace,\r\nI manifest in the loneliest space.\r\nWhat am I?",
        "Behind the curtain of power and might,\r\nI pull the strings, hidden from sight.\r\nWhat am I?",
        "I wear a mask of charm and grace,\r\nIn hidden motives, I find my place.\r\nWhat am I?",
        "When daylight fades, and darkness prevails,\r\nI creep, silent, where courage fails.\r\nWhat am I?",
        "In the shadows where wickedness breeds,\r\nI thrive on chaos, plant poisonous seeds.\r\nWhat am I?",

    };
    static string[] answers =
    {
        "fear",
        "fear",
        "evil",
        "fear",
        "evil",
        "evil",
        "fear",
        "evil",

    };
    static void Abyss()
    {
        string logo1 = @"                                                                                                    
                                                                
                                                      ███        █  █  █         ██     ██   █    █    
                                               █                     ██████   █      █ ██  ██  ██      
                                                 ██        █████ ███           █    █ █  ██████  ██    
                                                        ██                         ██  ███ ██ ███  █   
                                                          ██                      █  █ ████ █████ █ ██ 
                                                                                  █   ████    ████  █  
                                                   ██               █        ██     ██  ████████  ███  
                                                               █                      ██  ████  ██     
                                                                              █         ██ ██ ██       
                                                                          ██     ██        ███       █ 
                                                  █         █           █    ███     █     ██     ██   
                                             ██  █    ██      █            ███         █               
                                               █              █     █   ██                █  ██   █    
                                                 █                                               █     
                                                           
                                                  █                  ██████                    █       
                                                  █        ██  █    █    ██ █                          
                                              ████ █          ██    █████                              
                                             █████████████████████████                                 
                                             ████████████████████                      ████████████    
                                                ███ ██████████          ███        ███████████████████ 
                                                 ██████████             ██████████████████████████████ 
                                                  ███████              ███████████████████████████████ 
                                                                     █ ██ ███████████ ███████ █  █████ 
                                                                     █████████ ███████████████████████ 
                                                                    ████ ██████████████████ ██   █████ 
                                                                █  ███████████████████████████████████ 
                                                           ███  █████████ ████████████████████████████ 
                                                          █████████████████████ ██████████████████████ 
                                                         █████████████████████████████████████████████ 
                                                                                                                                                             
";
        PrintColoredText(logo1);
    }
    static void Skull()
    {
        string logo1 = @"
                                                        █                                           ██
                                                        ██                                          ██
                                                        ██             ████████████████             ██
                                                        ██         ██████            ██████         ██
                                                        ██       ████                    ████       ██
                                                        ██     ███                         ████     ██
                                                        ██    ███                            ███    ██
                                                        ██   ██                               ██    ██
                                                        ██   █████                         ██████   ██
                                                        ██  ██ ████  █                 █   ███  ██  ██
                                                        ██ █ █  ███   ███           ████   ███ ██ █ ██
                                                        ██   ██ ██      █ ██      ██        ██ ██   ██
                                                        ██    ██  ██     ████    ███      ██  ██    ██
                                                        ██   ██ ████████ █  ██  ██  █ ████████ ██   ██
                                                        ██    █████████████  ███   █████████████    ██
                                                        ██  ███ ██████████████████████████████ ███  ██
                                                        █   █     █ █████████    ████████  █     █  ██
                                                        █ ████       ███     ███      ██       ████ ██
                                                        █  ████████████████ ██████ █ ██████████████ ██
                                                        ██   █████████   █ ███████ ██  ███ ██████   ██
                                                        ██      ██  █████  ███████   ██████ ██      ██
                                                        ██       ██ ██████         ██████  ██       ██
                                                        ██        █████████████████████ ███         ██
                                                        ██         ████ █████████████  ██ █         ██
                                                        █      ████  ████  ███████  █████ ██████    ██
                                                        ███████████  ████████ ██ ███████   ███████████
                                                        ████████████  ██ ██████████████   ████████████
                                                        ██████████████   ████████████  ███████████████
                                                        ████████████████    ██████    ████████████████
                                                        █████████████████ █        █ █████████████████
                                                        █████████████████           ██████████████████
                                                        ██████████████████         ███████████████████
                                                        ███████████████████████████████████████████ ██

";
        PrintColoredText(logo1);
    }
    static void illuminati()
    {
        string logo1 = @"                                                                
                                                                
                                                                          ████                              
                                                                          ████                              
                                                                        ████████                            
                                                                         ██████                             
                                                                       ██████████                           
                                                                     ███  █████████                         
                                                                      ████      ██                          
                                                                    ███  ███████████                        
                                                                  ████████████████████                      
                                                                   ██████      ██████                       
                                                                 ███  ████████      ███                     
                                                                 ███████    ███████   █                     
                                                                ███    ███████   ████████                   
                                                              ███ ██████████████   ███████                  
                                                              ██████████     █████████ ███                  
                                                             ████   █████████████   ███████                 
                                                           ██████     █████████     █████████               
                                                           ███ ███     ███████      █████████               
                                                          ████  ████              ████   █████              
                                                        ██████ ██  █████████████████   ██ ██████            
                                                        █████ ██ ██   ███████████    ██  ███████            
                                                      ████████████████████████████████████████████          
                                                                       █████████                            
                                                                                
";
        PrintColoredText(logo1);
    }
    private static void CallAnotherMethod()
    {
        BackInstructions();
        // Add your logic here...
    }
    static void BackInstructions()
    {
        Console.Clear();
        string text = "\t\t\t\t\t\t   ?are you sure you want to go back? press anything to continue";

        Console.ForegroundColor = ConsoleColor.DarkRed;
        PrintCentered(text);
        Console.ResetColor();
        Console.ReadKey();

        StartingScene();
    }
}
