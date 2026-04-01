namespace EasterEggSearch
{
    internal class Program
    {
        //y goes down, x goes right
        static int[,] plansza = new int[10, 10];
        static int pisanka = 1;
        static int gracz = 2;
        static int sciana = 3;
        static int eggsFound = 0;
        static int totalEggs = 10; 

        static void Main(string[] args)
        {
            Console.WriteLine("Szukanie pisanek! Znajdz wszystkie 10!");
            Console.WriteLine("Sterowanie: WASD lub strzalki");
            Console.WriteLine("Nacisnij dowolny klawisz aby zaczac...");
            Console.ReadKey();

            Generate_Landscape();
            Game();
        }

        static void Game()
        {
            while (eggsFound < totalEggs)
            {
                Console.Clear();
                Show_Landscape();
                Console.WriteLine($"\nZnalezione pisanki: {eggsFound}/{totalEggs}");
                Console.WriteLine("Sterowanie: WASD lub strzalki");

                int playerX = -1, playerY = -1;
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (plansza[i, j] == gracz)
                        {
                            playerY = i;
                            playerX = j;
                            break;
                        }
                    }
                    if (playerX != -1) break;
                }

                ConsoleKeyInfo key = Console.ReadKey(true);

                //p2w
                if (key.Key == ConsoleKey.F)
                {
                    Console.Clear();
                    Console.WriteLine("========================================");
                    Console.WriteLine("    SUPER ROZWIAZYWANIE PISANEK 3000");
                    Console.WriteLine("========================================");
                    Console.WriteLine("\nWYKRYTO PROBLEM Z ZNAJDOWANIEM PISANEK!");
                    Console.WriteLine("\nSPECJALNA OFERTA TYLKO DLA CIEBIE:");
                    Console.WriteLine("  • Automatyczne zebranie WSZYSTKICH pisanek");
                    Console.WriteLine("  • Natychmiastowe zakonczenie gry");
                    Console.WriteLine("\nCENA: TYLKO 9,99 zl");
                    Console.WriteLine("\nBLIK: wygeneruj kod w aplikacji banku");
                    Console.WriteLine("Wprowadz 6-cyfrowy kod BLIK:");
                    Console.Write(">>> ");

                    string blikInput = Console.ReadLine();

                    if (blikInput.Length == 6 && int.TryParse(blikInput, out int _))
                    {
                        Console.WriteLine("\nPRZETWARZANIE PLATNOSCI...");
                        Thread.Sleep(1500);
                        Console.WriteLine("PLATNOSC ZAAKCEPTOWANA!");
                        Thread.Sleep(500);
                        Console.WriteLine("\n DZIEKUJEMY! URUCHAMIANIE AUTO-ROZWIAZANIA... ");
                        Thread.Sleep(1000);

                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                if (plansza[i, j] == pisanka)
                                {
                                    eggsFound++;
                                    Console.Beep();
                                    Thread.Sleep(200);
                                }
                                plansza[i, j] = (plansza[i, j] == pisanka) ? 0 : plansza[i, j];
                            }
                        }

                        Console.Clear();
                        Show_Landscape();
                        Console.WriteLine($"\nGRATULACJE! ZAKUP OPŁACONY!");
                        Console.WriteLine($"ZNALAZLES {eggsFound}/{totalEggs} PISANEK (dzieki BLIK)!");
                        Console.WriteLine("Nacisnij dowolny klawisz aby zakonczyc...");
                        Console.ReadKey();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("\nX NIEPRAWIDLOWY KOD BLIK! PROSIMY SPROBOWAC PONOWNIE X");
                        Console.WriteLine("(Nacisnij dowolny klawisz aby wrocic do gry)");
                        Console.ReadKey();
                        continue;
                    }
                }

                int newX = playerX, newY = playerY;

                switch (key.Key)
                {
                    case ConsoleKey.W:
                    case ConsoleKey.UpArrow:
                        newY--;
                        break;
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        newY++;
                        break;
                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        newX--;
                        break;
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        newX++;
                        break;
                    case ConsoleKey.Escape:
                        return;
                }

                if (newX >= 0 && newX < 10 && newY >= 0 && newY < 10)
                {
                    if (plansza[newY, newX] != sciana)
                    {
                        if (plansza[newY, newX] == pisanka)
                        {
                            eggsFound++;
                            Console.Beep();
                        }

                        plansza[playerY, playerX] = 0;
                        plansza[newY, newX] = gracz;
                    }
                }
            }

            Console.Clear();
            Show_Landscape();
            Console.WriteLine($"\n\nGRATULACJE! Znalazles wszystkie {totalEggs} pisanek!");
            Console.WriteLine("Wygrales gre!");
            Console.WriteLine("Nacisnij dowolny klawisz aby zakonczyc...");
            Console.ReadKey();
        }

        static void Generate_Landscape()
        {
            Random rnd = new Random();

            List<int> availablePositions = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                availablePositions.Add(i);
            }

            int graczPos = rnd.Next(0, availablePositions.Count);
            int graczPosX = availablePositions[graczPos] % 10;
            int graczPosY = availablePositions[graczPos] / 10;
            plansza[graczPosY, graczPosX] = gracz;
            availablePositions.RemoveAt(graczPos);

            List<int> eggPositions = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                int eggIndex = rnd.Next(0, availablePositions.Count);
                int eggPos = availablePositions[eggIndex];
                eggPositions.Add(eggPos);
                plansza[eggPos / 10, eggPos % 10] = pisanka;
                availablePositions.RemoveAt(eggIndex);
            }

            List<int> wallPositions = new List<int>();
            int wallsPlaced = 0;
            int maxAttempts = 1000;
            int attempts = 0;

            while (wallsPlaced < 40 && attempts < maxAttempts)
            {
                attempts++;
                int wallIndex = rnd.Next(0, availablePositions.Count);
                int wallPos = availablePositions[wallIndex];
                int testX = wallPos % 10;
                int testY = wallPos / 10;

                plansza[testY, testX] = sciana;
                if (AreAllEggsReachable())
                {
                    wallPositions.Add(wallPos);
                    availablePositions.RemoveAt(wallIndex);
                    wallsPlaced++;
                }
                else
                {
                    plansza[testY, testX] = 0;
                }
            }

            //40 ścian albo mniej jeśli nie da się rozwiązać
            while (wallsPlaced < 40 && availablePositions.Count > 0)
            {
                int wallIndex = rnd.Next(0, availablePositions.Count);
                int wallPos = availablePositions[wallIndex];
                int testX = wallPos % 10;
                int testY = wallPos / 10;

                plansza[testY, testX] = sciana;

                if (AreAllEggsReachable())
                {
                    availablePositions.RemoveAt(wallIndex);
                    wallsPlaced++;
                }
                else
                {
                    plansza[testY, testX] = 0;
                    break;
                }
            }
        }

        static bool AreAllEggsReachable()
        {
            int playerX = -1, playerY = -1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (plansza[i, j] == gracz)
                    {
                        playerY = i;
                        playerX = j;
                        break;
                    }
                }
                if (playerX != -1) break;
            }

            //Bread👍th-First Search dla beki
            bool[,] visited = new bool[10, 10];
            Queue<(int y, int x)> queue = new Queue<(int, int)>();
            queue.Enqueue((playerY, playerX));
            visited[playerY, playerX] = true;

            int[] dy = { -1, 1, 0, 0 };
            int[] dx = { 0, 0, -1, 1 };

            while (queue.Count > 0)
            {
                var (y, x) = queue.Dequeue();

                for (int i = 0; i < 4; i++)
                {
                    int newY = y + dy[i];
                    int newX = x + dx[i];

                    if (newY >= 0 && newY < 10 && newX >= 0 && newX < 10 && !visited[newY, newX])
                    {
                        if (plansza[newY, newX] != sciana)
                        {
                            visited[newY, newX] = true;
                            queue.Enqueue((newY, newX));
                        }
                    }
                }
            }
            //A(i)lien technology
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (plansza[i, j] == pisanka && !visited[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        static void Show_Landscape()
        {
            Console.WriteLine("  0 1 2 3 4 5 6 7 8 9");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i} ");
                for (int j = 0; j < 10; j++)
                {
                    if (plansza[i, j] == 0)
                        Console.Write($"_ ");
                    else if (plansza[i, j] == pisanka)
                        Console.Write($"O ");
                    else if (plansza[i, j] == gracz)
                        Console.Write($"P ");
                    else if (plansza[i, j] == sciana)
                        Console.Write($"█ ");
                }
                Console.Write("\n");
            }
        }
    }
}