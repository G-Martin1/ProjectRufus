using System;
using System.Drawing;
using System.Security.Cryptography;

Menu();
string playerName;
bool isMiloWithUs;
int playerHealth = 100;
string[] enemyNames = { "Gorlock", "Maru", "Bober", "Pingwin", "Bob", "József", "Ferenc", "Vojtech", "Togepi", "Kirby" };

/*👀👀👀👀👀👀👀👀👀👀👀👀 LOOK AT THAT CODE 🥵🥵🥵🥵🥵🥵🥵🥵🥵🥵🥵🥵🥵🥵🥵😱😱😱🔥🔥🔥🔥🔥🔥🔥*/
void Menu()
{

    Console.WriteLine("\r\n ('-. .-.   ('-.                      .-') _  .-') _                                        .-') _    ('-. .-.   ('-.         _ .-') _     ('-.     _  .-')  .-. .-')           ('-.                   ('-.    .-')    \r\n( OO )  /  ( OO ).-.                 ( OO ) )(  OO) )                                      (  OO) )  ( OO )  / _(  OO)       ( (  OO) )   ( OO ).-.( \\( -O ) \\  ( OO )         ( OO ).-.             _(  OO)  ( OO ).  \r\n,--. ,--.  / . --. / ,--. ,--.   ,--./ ,--,' /     '._        .-'),-----.    ,------.      /     '._ ,--. ,--.(,------.       \\     .'_   / . --. / ,------. ,--. ,--.         / . --. /  ,----.    (,------.(_)---\\_) \r\n|  | |  |  | \\-.  \\  |  | |  |   |   \\ |  |\\ |'--...__)      ( OO'  .-.  '('-| _.---'      |'--...__)|  | |  | |  .---'       ,`'--..._)  | \\-.  \\  |   /`. '|  .'   /         | \\-.  \\  '  .-./-')  |  .---'/    _ |  \r\n|   .|  |.-'-'  |  | |  | | .-') |    \\|  | )'--.  .--'      /   |  | |  |(OO|(_\\          '--.  .--'|   .|  | |  |           |  |  \\  '.-'-'  |  | |  /  | ||      /,       .-'-'  |  | |  |_( O- ) |  |    \\  :` `.  \r\n|       | \\| |_.'  | |  |_|( OO )|  .     |/    |  |         \\_) |  |\\|  |/  |  '--.          |  |   |       |(|  '--.        |  |   ' | \\| |_.'  | |  |_.' ||     ' _)       \\| |_.'  | |  | .--, \\(|  '--.  '..`''.) \r\n|  .-.  |  |  .-.  | |  | | `-' /|  |\\    |     |  |           \\ |  | |  |\\_)|  .--'          |  |   |  .-.  | |  .--'        |  |   / :  |  .-.  | |  .  '.'|  .   \\          |  .-.  |(|  | '. (_/ |  .--' .-._)   \\ \r\n|  | |  |  |  | |  |('  '-'(_.-' |  | \\   |     |  |            `'  '-'  '  \\|  |_)           |  |   |  | |  | |  `---.       |  '--'  /  |  | |  | |  |\\  \\ |  |\\   \\         |  | |  | |  '--'  |  |  `---.\\       / \r\n`--' `--'  `--' `--'  `-----'    `--'  `--'     `--'              `-----'    `--'             `--'   `--' `--' `------'       `-------'   `--' `--' `--' '--'`--' '--'         `--' `--'  `------'   `------' `-----'  \r\n");

    Console.WriteLine("\r\n  __              _____            _   _                                   \r\n /_ |            / ____|          | | (_)                                  \r\n  | |  ______   | |     ___  _ __ | |_ _ _ __  _   _  ___                  \r\n  | | |______|  | |    / _ \\| '_ \\| __| | '_ \\| | | |/ _ \\                 \r\n  | |           | |___| (_) | | | | |_| | | | | |_| |  __/                 \r\n  |_|            \\_____\\___/|_| |_|\\__|_|_| |_|\\__,_|\\___|                 \r\n |__ \\            | \\ | |                                                  \r\n    ) |  ______   |  \\| | _____      __   __ _  __ _ _ __ ___   ___        \r\n   / /  |______|  | . ` |/ _ \\ \\ /\\ / /  / _` |/ _` | '_ ` _ \\ / _ \\       \r\n  / /_            | |\\  |  __/\\ V  V /  | (_| | (_| | | | | | |  __/       \r\n |____|           |_| \\_|\\___| \\_/\\_/    \\__, |\\__,_|_| |_| |_|\\___|       \r\n |___ \\            | \\ | |                __/ |                        _   \r\n   __) |  ______   |  \\| | _____      __ |___/_  __ _ _ __ ___   ___ _| |_ \r\n  |__ <  |______|  | . ` |/ _ \\ \\ /\\ / /  / _` |/ _` | '_ ` _ \\ / _ \\_   _|\r\n  ___) |           | |\\  |  __/\\ V  V /  | (_| | (_| | | | | | |  __/ |_|  \r\n |____/            |_| \\_|\\___| \\_/\\_/    \\__, |\\__,_|_| |_| |_|\\___|      \r\n  _  _                _____      _   _   _ __/ |                           \r\n | || |              / ____|    | | | | (_)___/                            \r\n | || |_   ______   | (___   ___| |_| |_ _ _ __   __ _ ___                 \r\n |__   _| |______|   \\___ \\ / _ \\ __| __| | '_ \\ / _` / __|                \r\n    | |              ____) |  __/ |_| |_| | | | | (_| \\__ \\                \r\n  __|_|             |_____/ \\___|\\__|\\__|_|_| |_|\\__, |___/                \r\n | ____|            / ____|            | (_) |    __/ |                    \r\n | |__    ______   | |     _ __ ___  __| |_| |_ _|___/                     \r\n |___ \\  |______|  | |    | '__/ _ \\/ _` | | __/ __|                       \r\n  ___) |           | |____| | |  __/ (_| | | |_\\__ \\                       \r\n |____/             \\_____|_|  \\___|\\__,_|_|\\__|___/                       \r\n   / /             |  ____|    (_) |                                       \r\n  / /_    ______   | |__  __  ___| |_                                      \r\n | '_ \\  |______|  |  __| \\ \\/ / | __|                                     \r\n | (_) |           | |____ >  <| | |_                                      \r\n  \\___/            |______/_/\\_\\_|\\__|                                     \r\n                                                                           \r\n                                                                           \r\n");

int menu_opt = Convert.ToInt32(Console.ReadLine());

switch (menu_opt)
{
    case 2:
        NewGameStart();
        break;
    case 6:
        System.Environment.Exit(0);
        break;
}

}

 void NewGameStart()
{
    Console.Clear();
    Print("What's your name");
    playerName = Console.ReadLine();
    Print("You woke up in your mother's house.\r\nIt was a strangely quiet morning in Berlin. A few days ago the doctor took your mom to the hospital, you should pay her a visit soon.");
    Print("Doc told us not to go but who is he to tell us what to do");
    Tutorial();
}
void Tutorial()
{
    Console.Clear();
    Print("Get bro to come w u?");
    Print("Y/N");
    string choice = Console.ReadLine();

        Print("Friend (tutorial npc(milo)) offers to come with you if you help him get some mushrooms from the forest");
        Print("Will you help? Y/N");
        choice = Console.ReadLine();
        if (choice.ToLower() == "y")
        {
            MushroomsMiniGame();
        }
        else
        {
            Console.WriteLine();
        }
        Console.WriteLine();
    
}

void MushroomsMiniGame()
{

}
void Print(string text, int speed=60)
{
    Console.Write(" ");
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(speed);
    }
}
void Battle(string type)
{
    Print("Our homeland is in danger. Everything is awful.");
    Print("Player turn");
    Console.WriteLine("[1] - Attack \n [2] - Items \n [3] - Talk \n [4] - Flee");
    string choice = Console.ReadLine();
    
    var rng = new Random();
    int enemyHealth = rng.Next(1, 200);
    string enemyName = enemyNames[rng.Next(10)];

    switch (choice)
    {
        case "1":
            Console.WriteLine("");
            break; 
        case "2":
            break;
        case "3":
            break;
        case "4":
            Console.WriteLine("Good Bye!");
            Console.WriteLine("And you ran away like a coward");
            break;
    }
     
}