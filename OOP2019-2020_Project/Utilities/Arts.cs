﻿

using System;
using System.Threading;

namespace Utilities
{
    public static class Arts
    {
        public static void StartMenu()
        {
            Tools.ColorfulWriteLine("                   )    (      (         )    (                      *                            (      (     \n" +
                                        "          (     ( /(    )\\ )   )\\ )   ( /(    )\\ )                 (  `       (  (        (       )\\ )   )\\ )  \n" +
                                        "          )\\    )\\())  (()/(  (()/(   )\\())  (()/(   (        (    )\\))(      )\\))(   '   )\\     (()/(  (()/(  \n" +
                                        "        (((_)  ((_)\\    /(_))  /(_)) ((_)\\    /(_))  )\\       )\\  ((_)()\\    ((_)()\\ ) ((((_)(    /(_))  /(_)) \n" +
                                        "        )\\___    ((_)  (_))   (_))     ((_)  (_))   ((_)   _ ((_) (_()((_)   _(())\\_)() )\\ _ )\\  (_))   (_))   \n" +
                                        "       ((/ __|  / _ \\  | |    | |     / _ \\  / __|  | __| | | | | |  \\/  |   \\ \\((_)/ / (_)_\\(_) | _ \\  / __|  \n" +
                                        "        | (__  | (_) | | |__  | |__  | (_) | \\__ \\  | _|  | |_| | | |\\/| |    \\ \\/\\/ /   / _ \\   |   /  \\__ \\  \n" +
                                        "         \\___|  \\___/  |____| |____|  \\___/  |___/  |___|  \\___/  |_|  |_|     \\_/\\_/   /_/ \\_\\  |_|_\\  |___/  ", ConsoleColor.DarkRed);

            Tools.ColorfulWriteLine("\n\n\n\n\n\n\n\n\n\n\n\n" +
                                    "                                               1: START GAME\n" +
                                    "                                               2: CHECK AUTHOR INFO\n" +
                                    "                                               0: CLOSE THE GAME", ConsoleColor.White);
        }

        public static void GladiatorName()
        {
            Tools.ColorfulWriteLine("  _  _   _     ___ _        _       _     __          _  ___     ___ _   _  \n" +
                                        " /  |_) |_  /\\  | |_   \\_/ / \\ | | |_)   /__ |   /\\  | \\  |   /\\  | / \\ |_) \n" +
                                        " \\_ | \\ |_ /--\\ | |_    |  \\_/ |_| | \\   \\_| |_ /--\\ |_/ _|_ /--\\ | \\_/ | \\ ", ConsoleColor.DarkRed);

            Tools.ColorfulWriteLine("\n\n\n\n" +
                                    "  __                                              \n" +
                                    " /__ o     _    _|_ |_   _    ._   _. ._ _   _  o \n" +
                                    " \\_| | \\/ (/_    |_ | | (/_   | | (_| | | | (/_ o \n", ConsoleColor.White);
        }

        public static void ArmYourGladiator()
        {
            Tools.ColorfulWriteLine("                                  __          _  ___     ___ _   _    \n" +
                                        "  /\\  ._ ._ _        _      ._   /__ |   /\\  | \\  |   /\\  | / \\ |_)  \n" +
                                        " /--\\ |  | | |   \\/ (_) |_| |    \\_| |_ /--\\ |_/ _|_ /--\\ | \\_/ | \\  \n" +
                                        "                 /                                                    ", ConsoleColor.DarkRed);
        }

        public static void ChoseYourWeapon()
        {
            Tools.ColorfulWriteLine("  _                                                       \n" +
                                            " /  |_   _   _   _  _        _      ._    _   _   _. ._ o \n" +
                                            " \\_ | | (_) (_) _> (/_   \\/ (_) |_| |    (_| (/_ (_| |  o \n" +
                                            "                         /                _|              \n" +
                                            "\n\n\n" +
                                            " \\    / _   _. ._   _  ._   _ o \n" +
                                            "  \\/\\/ (/_ (_| |_) (_) | | _> o \n" +
                                            "               |                \n" +
                                            "\n\n\n\n" +
                                            "  _. \\    |   _  ._   _    (_        _  ._ _| \n" +
                                            " (_|  |   |_ (_) | | (_|   __) \\/\\/ (_) | (_| \n" +
                                            "     /                _|                      \n\n" +
                                            "" +
                                            " |_ \\    |_|  _. _|_  _ |_   _ _|_ \n" +
                                            " |_) |   | | (_|  |_ (_ | | (/_ |_ \n" +
                                            "    /                              \n\n" +
                                            "  _ \\    |_|  _. ._ _  ._ _   _  ._ \n" +
                                            " (_  |   | | (_| | | | | | | (/_ |  \n" +
                                            "    /                               \n\n\n\n\n", ConsoleColor.White);
        }

        public static void ChoseYourArmor()
        {
            Tools.ColorfulWriteLine("  /\\  ._ ._ _   _  ._ _ o \n" +
                                    " /--\\ |  | | | (_) | _> o \n" +
                                    "\n\n\n\n" +
                                    "           _         _                 \n" +
                                    "  _. \\    |_    | | |_) |   _. _|_  _  \n" +
                                    " (_|  |   | |_| | | |   |_ (_|  |_ (/_ \n" +
                                    "    /                                 \n\n" +
                                    "          _                    _                \n" +
                                    " |_ \\    |_) ._ _   _.  _ _|_ |_) |  _. _|_  _  \n" +
                                    " |_) |   |_) | (/_ (_| _>  |_ |   | (_|  |_ (/_ \n" +
                                    "    /                                           \n\n" +
                                    "  _ \\    |   _   _. _|_ |_   _  ._ \n" +
                                    " (_  |   |_ (/_ (_|  |_ | | (/_ |  \n" +
                                    "    /                              \n", ConsoleColor.White);
        }

        public static void Intro()
        {
            Tools.ColorfulWriteLine("                            @@@  @@@  @@@ @@@@@@@@ @@@       @@@@@@@  @@@@@@  @@@@@@@@@@  @@@@@@@@\n" +
                                        "                            @@!  @@!  @@! @@!      @@!      !@@      @@!  @@@ @@! @@! @@! @@!     \n" +
                                        "                            @!!  !!@  @!@ @!!!:!   @!!      !@!      @!@  !@! @!! !!@ @!@ @!!!:!  \n" +
                                        "                             !:  !!:  !!  !!:      !!:      :!!      !!:  !!! !!:     !!: !!:     \n" +
                                        "                              ::.:  :::   : :: ::: : ::.: :  :: :: :  : :. :   :      :   : :: :::\n\n\n\n", ConsoleColor.Red);

            Tools.ColorfulWriteLine("                        , .  .   ,---. .  . ,--.    ,-.  ,-.  ,    ,     ,-.   ,-.  .  . ,--. .   , \n" +
                                    "                        | |\\ |     |   |  | |      /    /   \\ |    |    /   \\ (   ` |  | |    |\\ /| \n" +
                                    "                        | | \\|     |   |--| |-     |    |   | |    |    |   |  `-.  |  | |-   | V | \n" +
                                    "                        | |  |     |   |  | |      \\    \\   / |    |    \\   / .   ) |  | |    |   | \n" +
                                    "                        ' '  '     '   '  ' `--'    `-'  `-'  `--' `--'  `-'   `-'  `--` `--' '   ' \n\n\n\n", ConsoleColor.DarkYellow);

            Tools.ColorfulWriteLine("                                               PREPARE FOR THE BATTLE\n\n\n\n", ConsoleColor.Blue);

            Tools.ColorfulWriteLine("           _   _ ____ _  _ ____    ____ _ ____ ____ ___    ____ ___  ___  ____ _  _ ____ _  _ ___    _ ____    \n" +
                                    "            \\_/  |  | |  | |__/    |___ | |__/ [__   |     |  | |__] |__] |  | |\\ | |___ |\\ |  |     | [__     \n" +
                                    "             |   |__| |__| |  \\    |    | |  \\ ___]  |     |__| |    |    |__| | \\| |___ | \\|  |     | ___] ...\n", ConsoleColor.Cyan);
            Thread.Sleep(2000);
            Console.Clear();

            Tools.ColorfulWriteLine("\n\n                                            ▄▀▀▄    ▄▀▀▄  ▄▀▀▀▀▄   ▄▀▀▀▀▄     ▄▀▀▀█▄   \n" +
                                    "                                           █   █      █ █      █ █    █     █  ▄▀  ▀▄ \n" +
                                    "                                             █        █ █      █     █      █▄▄▄▄   \n" +
                                    "                                             █   ▄    █  ▀▄    ▄▀     █       █       \n" +
                                    "                                              ▀▄▀ ▀▄ ▄▀    ▀▀▀▀     ▄▀▄▄▄▄▄▄▀ █        \n" +
                                    "                                                    ▀               █        █         \n" +
                                    "                                                                                     \n" +
                                    "                            .d$$b      \n" +
                                    "                          .' TO$;\\     \n" +
                                    "                         /  : TP._;    \n" +
                                    "                        / _.;  :Tb|    \n" +
                                    "                       /   /   ;j$j    \n" +
                                    "                   _.-'       d$$$$    \n" +
                                    "                 .' ..       d$$$$;    \n" +
                                    "                /  /P'      d$$$$P. |\\ \n" +
                                    "               /   '      .d$$$P' |\\^'l                                           \n" +
                                    "             .'           `T$P^'''''  :\n" +
                                    "         ._.'      _.'                ;\n" +
                                    "      `-.-'.-'-' ._.       _.-'    .-' \n" +
                                    "    `.-' _____  ._              .-'    \n" +
                                    "   -(.g$$$$$$$b.              .'       \n" +
                                    "     ''^^T$$$P^)            .(:        \n" +
                                    "       _/  -'  /.'         /:/;        \n" +
                                    "    ._.'-'`-'  ')/         /;/;        \n" +
                                    " `-.-'..--''   ' /         /  ;        \n" +
                                    ".-' ..--''        -'          :        \n" +
                                    "..--''--.-'         (\\      .-(\\       \n" +
                                    "  ..--''              `-\\(\\/;`         \n", ConsoleColor.DarkGray);



            Thread.Sleep(2000);
            Console.Clear();
        }

        public static void Bleed()
        {
            Tools.ColorfulWriteLine("                    _    _       _  __   _     _               _    __             _____   _           \n" +
                                                "                   | |  | |     | |/ _| | |   | |             | |  / _|           |  ___| | |          \n" +
                                                "                   | |  | | ___ | | |_  | |__ | | ___  ___  __| | | |_ ___  _ __  |___ \\  | |__  _ __  \n" +
                                                "                   | |/\\| |/ _ \\| |  _| | '_ \\| |/ _ \\/ _ \\/ _` | |  _/ _ \\| '__|     \\ \\ | '_ \\| '_ \\ \n" +
                                                "                   \\  /\\  / (_) | | |   | |_) | |  __/  __/ (_| | | || (_) | |    /\\__/ / | | | | |_) |\n" +
                                                "                    \\/  \\/ \\___/|_|_|   |_.__/|_|\\___|\\___|\\__,_| |_| \\___/|_|    \\____/  |_| |_| .__/ \n" +
                                                "                                                                                                | |    \n" +
                                                "                                                                                                |_|    ", ConsoleColor.DarkRed);
        }

        public static void DemoArt()
        {
            Tools.ColorfulWriteLine(" ____  _  _   __   __ _  __ _  ____    ____  __  ____    ____  ____  ____  ____  __  __ _   ___ \n" +
                                        "(_  _)/ )( \\ / _\\ (  ( \\(  / )/ ___)  (  __)/  \\(  _ \\  (_  _)(  __)/ ___)(_  _)(  )(  ( \\ / __)\n" +
                                        "  )(  ) __ (/    \\/    / )  ( \\___ \\   ) _)(  O ))   /    )(   ) _) \\___ \\  )(   )( /    /( (_ \\\n" +
                                        " (__) \\_)(_/\\_/\\_/\\_)__)(__\\_)(____/  (__)  \\__/(__\\_)   (__) (____)(____/ (__) (__)\\_)__) \\___/\n" +
                                        "   ____  _  _  ____    ____  ____  _  _   __                                                    \n" +
                                        "  (_  _)/ )( \\(  __)  (    \\(  __)( \\/ ) /  \\                                                   \n" +
                                        "    )(  ) __ ( ) _)    ) D ( ) _) / \\/ \\(  O )                                                  \n" +
                                        "   (__) \\_)(_/(____)  (____/(____)\\_)(_/ \\__/                                                   \n", ConsoleColor.Green);
        }
            

    }
}
