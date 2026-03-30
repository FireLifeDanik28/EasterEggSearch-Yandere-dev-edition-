namespace EasterEggSearch
{
    internal class Program
    {
        //y goes down, x goes right
        static int[,] plansza = new int[10, 10];
        static int pisanka = 1;
        static int gracz = 2;
        static int sciana = 3;
        static bool winCondition = false;

        static void Main(string[] args)
        {
            Generate_Landscape();
            Show_Landscape();
            Console.WriteLine("Przesuwania nie masz, powodzenia");
            Game();
        }

        static void Game()
        {
            while (true)
            {
                if (winCondition)
                {
                    break;
                }
                
            }
        }

        static void Generate_Landscape()
        {
            Random rnd = new Random();
            int graczPos = rnd.Next(0, 100);//0 - 39 0 = 0,0 1 = 0,1 9 = 0,9 10 = 1,0 20 = 2,0
            int graczPosX = graczPos % 10;
            int graczPosY = graczPos / 10;
            plansza[graczPosY, graczPosX] = gracz;
            int pis1;
            int pis2;
            int pis3;
            int pis4;
            int pis5;
            int pis6;
            int pis7;
            int pis8;
            int pis9;
            int pis10;
            while (true)
            {
                pis1 = rnd.Next(0, 100);
                if (pis1 != graczPos)
                    break;
            }
            plansza[pis1 / 10, pis1 % 10] = pisanka;
            while (true)
            {
                pis2 = rnd.Next(0, 100);
                if (pis2 != graczPos && pis2 != pis1)
                    break;
            }
            plansza[pis2 / 10, pis2 % 10] = pisanka;
            while (true)
            {
                pis3 = rnd.Next(0, 100);
                if (pis3 != graczPos && pis2 != pis3 && pis3 != pis1)
                    break;
            }
            plansza[pis3 / 10, pis3 % 10] = pisanka;
            while (true)
            {
                pis4 = rnd.Next(0, 100);
                if (pis4 != graczPos && pis1 != pis4 && pis2 != pis4 && pis3 != pis4)
                    break;
            }
            plansza[pis4 / 10, pis4 % 10] = pisanka;
            while (true)
            {
                pis5 = rnd.Next(0, 100);
                if (pis5 != graczPos && pis1 != pis5 && pis2 != pis5 && pis3 != pis5 && pis4 != pis5)
                    break;
            }
            plansza[pis5 / 10, pis5 % 10] = pisanka;
            while (true)
            {
                pis6 = rnd.Next(0, 100);
                if (pis6 != graczPos && pis1 != pis6 && pis2 != pis6 && pis3 != pis6 && pis4 != pis6 && pis5 != pis6)
                    break;
            }
            plansza[pis6 / 10, pis6 % 10] = pisanka;
            while (true)
            {
                pis7 = rnd.Next(0, 100);
                if (pis7 != graczPos && pis1 != pis7 && pis2 != pis7 && pis3 != pis7 && pis4 != pis7 && pis5 != pis7 && pis6 != pis7)
                    break;
            }
            plansza[pis7 / 10, pis7 % 10] = pisanka;
            while (true)
            {
                pis8 = rnd.Next(0, 100);
                if (pis8 != graczPos && pis1 != pis8 && pis2 != pis8 && pis3 != pis8 && pis4 != pis8 && pis5 != pis8 && pis6 != pis8 && pis7 != pis8)
                    break;
            }
            plansza[pis8 / 10, pis8 % 10] = pisanka;
            while (true)
            {
                pis9 = rnd.Next(0, 100);
                if (pis9 != graczPos && pis1 != pis9 && pis2 != pis9 && pis3 != pis9 && pis4 != pis9 && pis5 != pis9 && pis6 != pis9 && pis7 != pis9 && pis8 != pis9)
                    break;
            }
            plansza[pis9 / 10, pis9 % 10] = pisanka;
            while (true)
            {
                pis10 = rnd.Next(0, 100);
                if (pis10 != graczPos && pis1 != pis10 && pis2 != pis10 && pis3 != pis10 && pis4 != pis10 && pis5 != pis10 && pis6 != pis10 && pis7 != pis10 && pis8 != pis10 && pis9 != pis10)
                    break;
            }
            plansza[pis10 / 10, pis10 % 10] = pisanka;
            //Biedny DeepSeek
            // 40 WALLS IN THE MOST UNOPTIMISED WAY POSSIBLE
            int sciana1, sciana2, sciana3, sciana4, sciana5, sciana6, sciana7, sciana8, sciana9, sciana10;
            int sciana11, sciana12, sciana13, sciana14, sciana15, sciana16, sciana17, sciana18, sciana19, sciana20;
            int sciana21, sciana22, sciana23, sciana24, sciana25, sciana26, sciana27, sciana28, sciana29, sciana30;
            int sciana31, sciana32, sciana33, sciana34, sciana35, sciana36, sciana37, sciana38, sciana39, sciana40;

            // Wall 1
            while (true)
            {
                sciana1 = rnd.Next(0, 100);
                if (sciana1 != graczPos && sciana1 != pis1 && sciana1 != pis2 && sciana1 != pis3 && sciana1 != pis4 &&
                    sciana1 != pis5 && sciana1 != pis6 && sciana1 != pis7 && sciana1 != pis8 && sciana1 != pis9 && sciana1 != pis10)
                    break;
            }
            plansza[sciana1 / 10, sciana1 % 10] = sciana;

            // Wall 2
            while (true)
            {
                sciana2 = rnd.Next(0, 100);
                if (sciana2 != graczPos && sciana2 != pis1 && sciana2 != pis2 && sciana2 != pis3 && sciana2 != pis4 &&
                    sciana2 != pis5 && sciana2 != pis6 && sciana2 != pis7 && sciana2 != pis8 && sciana2 != pis9 && sciana2 != pis10 && sciana2 != sciana1)
                    break;
            }
            plansza[sciana2 / 10, sciana2 % 10] = sciana;

            // Wall 3
            while (true)
            {
                sciana3 = rnd.Next(0, 100);
                if (sciana3 != graczPos && sciana3 != pis1 && sciana3 != pis2 && sciana3 != pis3 && sciana3 != pis4 &&
                    sciana3 != pis5 && sciana3 != pis6 && sciana3 != pis7 && sciana3 != pis8 && sciana3 != pis9 && sciana3 != pis10 &&
                    sciana3 != sciana1 && sciana3 != sciana2)
                    break;
            }
            plansza[sciana3 / 10, sciana3 % 10] = sciana;

            // Wall 4
            while (true)
            {
                sciana4 = rnd.Next(0, 100);
                if (sciana4 != graczPos && sciana4 != pis1 && sciana4 != pis2 && sciana4 != pis3 && sciana4 != pis4 &&
                    sciana4 != pis5 && sciana4 != pis6 && sciana4 != pis7 && sciana4 != pis8 && sciana4 != pis9 && sciana4 != pis10 &&
                    sciana4 != sciana1 && sciana4 != sciana2 && sciana4 != sciana3)
                    break;
            }
            plansza[sciana4 / 10, sciana4 % 10] = sciana;

            // Wall 5
            while (true)
            {
                sciana5 = rnd.Next(0, 100);
                if (sciana5 != graczPos && sciana5 != pis1 && sciana5 != pis2 && sciana5 != pis3 && sciana5 != pis4 &&
                    sciana5 != pis5 && sciana5 != pis6 && sciana5 != pis7 && sciana5 != pis8 && sciana5 != pis9 && sciana5 != pis10 &&
                    sciana5 != sciana1 && sciana5 != sciana2 && sciana5 != sciana3 && sciana5 != sciana4)
                    break;
            }
            plansza[sciana5 / 10, sciana5 % 10] = sciana;

            // Wall 6
            while (true)
            {
                sciana6 = rnd.Next(0, 100);
                if (sciana6 != graczPos && sciana6 != pis1 && sciana6 != pis2 && sciana6 != pis3 && sciana6 != pis4 &&
                    sciana6 != pis5 && sciana6 != pis6 && sciana6 != pis7 && sciana6 != pis8 && sciana6 != pis9 && sciana6 != pis10 &&
                    sciana6 != sciana1 && sciana6 != sciana2 && sciana6 != sciana3 && sciana6 != sciana4 && sciana6 != sciana5)
                    break;
            }
            plansza[sciana6 / 10, sciana6 % 10] = sciana;

            // Wall 7
            while (true)
            {
                sciana7 = rnd.Next(0, 100);
                if (sciana7 != graczPos && sciana7 != pis1 && sciana7 != pis2 && sciana7 != pis3 && sciana7 != pis4 &&
                    sciana7 != pis5 && sciana7 != pis6 && sciana7 != pis7 && sciana7 != pis8 && sciana7 != pis9 && sciana7 != pis10 &&
                    sciana7 != sciana1 && sciana7 != sciana2 && sciana7 != sciana3 && sciana7 != sciana4 && sciana7 != sciana5 && sciana7 != sciana6)
                    break;
            }
            plansza[sciana7 / 10, sciana7 % 10] = sciana;

            // Wall 8
            while (true)
            {
                sciana8 = rnd.Next(0, 100);
                if (sciana8 != graczPos && sciana8 != pis1 && sciana8 != pis2 && sciana8 != pis3 && sciana8 != pis4 &&
                    sciana8 != pis5 && sciana8 != pis6 && sciana8 != pis7 && sciana8 != pis8 && sciana8 != pis9 && sciana8 != pis10 &&
                    sciana8 != sciana1 && sciana8 != sciana2 && sciana8 != sciana3 && sciana8 != sciana4 && sciana8 != sciana5 &&
                    sciana8 != sciana6 && sciana8 != sciana7)
                    break;
            }
            plansza[sciana8 / 10, sciana8 % 10] = sciana;

            // Wall 9
            while (true)
            {
                sciana9 = rnd.Next(0, 100);
                if (sciana9 != graczPos && sciana9 != pis1 && sciana9 != pis2 && sciana9 != pis3 && sciana9 != pis4 &&
                    sciana9 != pis5 && sciana9 != pis6 && sciana9 != pis7 && sciana9 != pis8 && sciana9 != pis9 && sciana9 != pis10 &&
                    sciana9 != sciana1 && sciana9 != sciana2 && sciana9 != sciana3 && sciana9 != sciana4 && sciana9 != sciana5 &&
                    sciana9 != sciana6 && sciana9 != sciana7 && sciana9 != sciana8)
                    break;
            }
            plansza[sciana9 / 10, sciana9 % 10] = sciana;

            // Wall 10
            while (true)
            {
                sciana10 = rnd.Next(0, 100);
                if (sciana10 != graczPos && sciana10 != pis1 && sciana10 != pis2 && sciana10 != pis3 && sciana10 != pis4 &&
                    sciana10 != pis5 && sciana10 != pis6 && sciana10 != pis7 && sciana10 != pis8 && sciana10 != pis9 && sciana10 != pis10 &&
                    sciana10 != sciana1 && sciana10 != sciana2 && sciana10 != sciana3 && sciana10 != sciana4 && sciana10 != sciana5 &&
                    sciana10 != sciana6 && sciana10 != sciana7 && sciana10 != sciana8 && sciana10 != sciana9)
                    break;
            }
            plansza[sciana10 / 10, sciana10 % 10] = sciana;

            // Wall 11
            while (true)
            {
                sciana11 = rnd.Next(0, 100);
                if (sciana11 != graczPos && sciana11 != pis1 && sciana11 != pis2 && sciana11 != pis3 && sciana11 != pis4 &&
                    sciana11 != pis5 && sciana11 != pis6 && sciana11 != pis7 && sciana11 != pis8 && sciana11 != pis9 && sciana11 != pis10 &&
                    sciana11 != sciana1 && sciana11 != sciana2 && sciana11 != sciana3 && sciana11 != sciana4 && sciana11 != sciana5 &&
                    sciana11 != sciana6 && sciana11 != sciana7 && sciana11 != sciana8 && sciana11 != sciana9 && sciana11 != sciana10)
                    break;
            }
            plansza[sciana11 / 10, sciana11 % 10] = sciana;

            // Wall 12
            while (true)
            {
                sciana12 = rnd.Next(0, 100);
                if (sciana12 != graczPos && sciana12 != pis1 && sciana12 != pis2 && sciana12 != pis3 && sciana12 != pis4 &&
                    sciana12 != pis5 && sciana12 != pis6 && sciana12 != pis7 && sciana12 != pis8 && sciana12 != pis9 && sciana12 != pis10 &&
                    sciana12 != sciana1 && sciana12 != sciana2 && sciana12 != sciana3 && sciana12 != sciana4 && sciana12 != sciana5 &&
                    sciana12 != sciana6 && sciana12 != sciana7 && sciana12 != sciana8 && sciana12 != sciana9 && sciana12 != sciana10 && sciana12 != sciana11)
                    break;
            }
            plansza[sciana12 / 10, sciana12 % 10] = sciana;

            // Wall 13
            while (true)
            {
                sciana13 = rnd.Next(0, 100);
                if (sciana13 != graczPos && sciana13 != pis1 && sciana13 != pis2 && sciana13 != pis3 && sciana13 != pis4 &&
                    sciana13 != pis5 && sciana13 != pis6 && sciana13 != pis7 && sciana13 != pis8 && sciana13 != pis9 && sciana13 != pis10 &&
                    sciana13 != sciana1 && sciana13 != sciana2 && sciana13 != sciana3 && sciana13 != sciana4 && sciana13 != sciana5 &&
                    sciana13 != sciana6 && sciana13 != sciana7 && sciana13 != sciana8 && sciana13 != sciana9 && sciana13 != sciana10 &&
                    sciana13 != sciana11 && sciana13 != sciana12)
                    break;
            }
            plansza[sciana13 / 10, sciana13 % 10] = sciana;

            // Wall 14
            while (true)
            {
                sciana14 = rnd.Next(0, 100);
                if (sciana14 != graczPos && sciana14 != pis1 && sciana14 != pis2 && sciana14 != pis3 && sciana14 != pis4 &&
                    sciana14 != pis5 && sciana14 != pis6 && sciana14 != pis7 && sciana14 != pis8 && sciana14 != pis9 && sciana14 != pis10 &&
                    sciana14 != sciana1 && sciana14 != sciana2 && sciana14 != sciana3 && sciana14 != sciana4 && sciana14 != sciana5 &&
                    sciana14 != sciana6 && sciana14 != sciana7 && sciana14 != sciana8 && sciana14 != sciana9 && sciana14 != sciana10 &&
                    sciana14 != sciana11 && sciana14 != sciana12 && sciana14 != sciana13)
                    break;
            }
            plansza[sciana14 / 10, sciana14 % 10] = sciana;

            // Wall 15
            while (true)
            {
                sciana15 = rnd.Next(0, 100);
                if (sciana15 != graczPos && sciana15 != pis1 && sciana15 != pis2 && sciana15 != pis3 && sciana15 != pis4 &&
                    sciana15 != pis5 && sciana15 != pis6 && sciana15 != pis7 && sciana15 != pis8 && sciana15 != pis9 && sciana15 != pis10 &&
                    sciana15 != sciana1 && sciana15 != sciana2 && sciana15 != sciana3 && sciana15 != sciana4 && sciana15 != sciana5 &&
                    sciana15 != sciana6 && sciana15 != sciana7 && sciana15 != sciana8 && sciana15 != sciana9 && sciana15 != sciana10 &&
                    sciana15 != sciana11 && sciana15 != sciana12 && sciana15 != sciana13 && sciana15 != sciana14)
                    break;
            }
            plansza[sciana15 / 10, sciana15 % 10] = sciana;

            // Wall 16
            while (true)
            {
                sciana16 = rnd.Next(0, 100);
                if (sciana16 != graczPos && sciana16 != pis1 && sciana16 != pis2 && sciana16 != pis3 && sciana16 != pis4 &&
                    sciana16 != pis5 && sciana16 != pis6 && sciana16 != pis7 && sciana16 != pis8 && sciana16 != pis9 && sciana16 != pis10 &&
                    sciana16 != sciana1 && sciana16 != sciana2 && sciana16 != sciana3 && sciana16 != sciana4 && sciana16 != sciana5 &&
                    sciana16 != sciana6 && sciana16 != sciana7 && sciana16 != sciana8 && sciana16 != sciana9 && sciana16 != sciana10 &&
                    sciana16 != sciana11 && sciana16 != sciana12 && sciana16 != sciana13 && sciana16 != sciana14 && sciana16 != sciana15)
                    break;
            }
            plansza[sciana16 / 10, sciana16 % 10] = sciana;

            // Wall 17
            while (true)
            {
                sciana17 = rnd.Next(0, 100);
                if (sciana17 != graczPos && sciana17 != pis1 && sciana17 != pis2 && sciana17 != pis3 && sciana17 != pis4 &&
                    sciana17 != pis5 && sciana17 != pis6 && sciana17 != pis7 && sciana17 != pis8 && sciana17 != pis9 && sciana17 != pis10 &&
                    sciana17 != sciana1 && sciana17 != sciana2 && sciana17 != sciana3 && sciana17 != sciana4 && sciana17 != sciana5 &&
                    sciana17 != sciana6 && sciana17 != sciana7 && sciana17 != sciana8 && sciana17 != sciana9 && sciana17 != sciana10 &&
                    sciana17 != sciana11 && sciana17 != sciana12 && sciana17 != sciana13 && sciana17 != sciana14 && sciana17 != sciana15 && sciana17 != sciana16)
                    break;
            }
            plansza[sciana17 / 10, sciana17 % 10] = sciana;

            // Wall 18
            while (true)
            {
                sciana18 = rnd.Next(0, 100);
                if (sciana18 != graczPos && sciana18 != pis1 && sciana18 != pis2 && sciana18 != pis3 && sciana18 != pis4 &&
                    sciana18 != pis5 && sciana18 != pis6 && sciana18 != pis7 && sciana18 != pis8 && sciana18 != pis9 && sciana18 != pis10 &&
                    sciana18 != sciana1 && sciana18 != sciana2 && sciana18 != sciana3 && sciana18 != sciana4 && sciana18 != sciana5 &&
                    sciana18 != sciana6 && sciana18 != sciana7 && sciana18 != sciana8 && sciana18 != sciana9 && sciana18 != sciana10 &&
                    sciana18 != sciana11 && sciana18 != sciana12 && sciana18 != sciana13 && sciana18 != sciana14 && sciana18 != sciana15 &&
                    sciana18 != sciana16 && sciana18 != sciana17)
                    break;
            }
            plansza[sciana18 / 10, sciana18 % 10] = sciana;

            // Wall 19
            while (true)
            {
                sciana19 = rnd.Next(0, 100);
                if (sciana19 != graczPos && sciana19 != pis1 && sciana19 != pis2 && sciana19 != pis3 && sciana19 != pis4 &&
                    sciana19 != pis5 && sciana19 != pis6 && sciana19 != pis7 && sciana19 != pis8 && sciana19 != pis9 && sciana19 != pis10 &&
                    sciana19 != sciana1 && sciana19 != sciana2 && sciana19 != sciana3 && sciana19 != sciana4 && sciana19 != sciana5 &&
                    sciana19 != sciana6 && sciana19 != sciana7 && sciana19 != sciana8 && sciana19 != sciana9 && sciana19 != sciana10 &&
                    sciana19 != sciana11 && sciana19 != sciana12 && sciana19 != sciana13 && sciana19 != sciana14 && sciana19 != sciana15 &&
                    sciana19 != sciana16 && sciana19 != sciana17 && sciana19 != sciana18)
                    break;
            }
            plansza[sciana19 / 10, sciana19 % 10] = sciana;

            // Wall 20
            while (true)
            {
                sciana20 = rnd.Next(0, 100);
                if (sciana20 != graczPos && sciana20 != pis1 && sciana20 != pis2 && sciana20 != pis3 && sciana20 != pis4 &&
                    sciana20 != pis5 && sciana20 != pis6 && sciana20 != pis7 && sciana20 != pis8 && sciana20 != pis9 && sciana20 != pis10 &&
                    sciana20 != sciana1 && sciana20 != sciana2 && sciana20 != sciana3 && sciana20 != sciana4 && sciana20 != sciana5 &&
                    sciana20 != sciana6 && sciana20 != sciana7 && sciana20 != sciana8 && sciana20 != sciana9 && sciana20 != sciana10 &&
                    sciana20 != sciana11 && sciana20 != sciana12 && sciana20 != sciana13 && sciana20 != sciana14 && sciana20 != sciana15 &&
                    sciana20 != sciana16 && sciana20 != sciana17 && sciana20 != sciana18 && sciana20 != sciana19)
                    break;
            }
            plansza[sciana20 / 10, sciana20 % 10] = sciana;

            // Wall 21
            while (true)
            {
                sciana21 = rnd.Next(0, 100);
                if (sciana21 != graczPos && sciana21 != pis1 && sciana21 != pis2 && sciana21 != pis3 && sciana21 != pis4 &&
                    sciana21 != pis5 && sciana21 != pis6 && sciana21 != pis7 && sciana21 != pis8 && sciana21 != pis9 && sciana21 != pis10 &&
                    sciana21 != sciana1 && sciana21 != sciana2 && sciana21 != sciana3 && sciana21 != sciana4 && sciana21 != sciana5 &&
                    sciana21 != sciana6 && sciana21 != sciana7 && sciana21 != sciana8 && sciana21 != sciana9 && sciana21 != sciana10 &&
                    sciana21 != sciana11 && sciana21 != sciana12 && sciana21 != sciana13 && sciana21 != sciana14 && sciana21 != sciana15 &&
                    sciana21 != sciana16 && sciana21 != sciana17 && sciana21 != sciana18 && sciana21 != sciana19 && sciana21 != sciana20)
                    break;
            }
            plansza[sciana21 / 10, sciana21 % 10] = sciana;

            // Wall 22
            while (true)
            {
                sciana22 = rnd.Next(0, 100);
                if (sciana22 != graczPos && sciana22 != pis1 && sciana22 != pis2 && sciana22 != pis3 && sciana22 != pis4 &&
                    sciana22 != pis5 && sciana22 != pis6 && sciana22 != pis7 && sciana22 != pis8 && sciana22 != pis9 && sciana22 != pis10 &&
                    sciana22 != sciana1 && sciana22 != sciana2 && sciana22 != sciana3 && sciana22 != sciana4 && sciana22 != sciana5 &&
                    sciana22 != sciana6 && sciana22 != sciana7 && sciana22 != sciana8 && sciana22 != sciana9 && sciana22 != sciana10 &&
                    sciana22 != sciana11 && sciana22 != sciana12 && sciana22 != sciana13 && sciana22 != sciana14 && sciana22 != sciana15 &&
                    sciana22 != sciana16 && sciana22 != sciana17 && sciana22 != sciana18 && sciana22 != sciana19 && sciana22 != sciana20 && sciana22 != sciana21)
                    break;
            }
            plansza[sciana22 / 10, sciana22 % 10] = sciana;

            // Wall 23
            while (true)
            {
                sciana23 = rnd.Next(0, 100);
                if (sciana23 != graczPos && sciana23 != pis1 && sciana23 != pis2 && sciana23 != pis3 && sciana23 != pis4 &&
                    sciana23 != pis5 && sciana23 != pis6 && sciana23 != pis7 && sciana23 != pis8 && sciana23 != pis9 && sciana23 != pis10 &&
                    sciana23 != sciana1 && sciana23 != sciana2 && sciana23 != sciana3 && sciana23 != sciana4 && sciana23 != sciana5 &&
                    sciana23 != sciana6 && sciana23 != sciana7 && sciana23 != sciana8 && sciana23 != sciana9 && sciana23 != sciana10 &&
                    sciana23 != sciana11 && sciana23 != sciana12 && sciana23 != sciana13 && sciana23 != sciana14 && sciana23 != sciana15 &&
                    sciana23 != sciana16 && sciana23 != sciana17 && sciana23 != sciana18 && sciana23 != sciana19 && sciana23 != sciana20 &&
                    sciana23 != sciana21 && sciana23 != sciana22)
                    break;
            }
            plansza[sciana23 / 10, sciana23 % 10] = sciana;

            // Wall 24
            while (true)
            {
                sciana24 = rnd.Next(0, 100);
                if (sciana24 != graczPos && sciana24 != pis1 && sciana24 != pis2 && sciana24 != pis3 && sciana24 != pis4 &&
                    sciana24 != pis5 && sciana24 != pis6 && sciana24 != pis7 && sciana24 != pis8 && sciana24 != pis9 && sciana24 != pis10 &&
                    sciana24 != sciana1 && sciana24 != sciana2 && sciana24 != sciana3 && sciana24 != sciana4 && sciana24 != sciana5 &&
                    sciana24 != sciana6 && sciana24 != sciana7 && sciana24 != sciana8 && sciana24 != sciana9 && sciana24 != sciana10 &&
                    sciana24 != sciana11 && sciana24 != sciana12 && sciana24 != sciana13 && sciana24 != sciana14 && sciana24 != sciana15 &&
                    sciana24 != sciana16 && sciana24 != sciana17 && sciana24 != sciana18 && sciana24 != sciana19 && sciana24 != sciana20 &&
                    sciana24 != sciana21 && sciana24 != sciana22 && sciana24 != sciana23)
                    break;
            }
            plansza[sciana24 / 10, sciana24 % 10] = sciana;

            // Wall 25
            while (true)
            {
                sciana25 = rnd.Next(0, 100);
                if (sciana25 != graczPos && sciana25 != pis1 && sciana25 != pis2 && sciana25 != pis3 && sciana25 != pis4 &&
                    sciana25 != pis5 && sciana25 != pis6 && sciana25 != pis7 && sciana25 != pis8 && sciana25 != pis9 && sciana25 != pis10 &&
                    sciana25 != sciana1 && sciana25 != sciana2 && sciana25 != sciana3 && sciana25 != sciana4 && sciana25 != sciana5 &&
                    sciana25 != sciana6 && sciana25 != sciana7 && sciana25 != sciana8 && sciana25 != sciana9 && sciana25 != sciana10 &&
                    sciana25 != sciana11 && sciana25 != sciana12 && sciana25 != sciana13 && sciana25 != sciana14 && sciana25 != sciana15 &&
                    sciana25 != sciana16 && sciana25 != sciana17 && sciana25 != sciana18 && sciana25 != sciana19 && sciana25 != sciana20 &&
                    sciana25 != sciana21 && sciana25 != sciana22 && sciana25 != sciana23 && sciana25 != sciana24)
                    break;
            }
            plansza[sciana25 / 10, sciana25 % 10] = sciana;

            // Wall 26
            while (true)
            {
                sciana26 = rnd.Next(0, 100);
                if (sciana26 != graczPos && sciana26 != pis1 && sciana26 != pis2 && sciana26 != pis3 && sciana26 != pis4 &&
                    sciana26 != pis5 && sciana26 != pis6 && sciana26 != pis7 && sciana26 != pis8 && sciana26 != pis9 && sciana26 != pis10 &&
                    sciana26 != sciana1 && sciana26 != sciana2 && sciana26 != sciana3 && sciana26 != sciana4 && sciana26 != sciana5 &&
                    sciana26 != sciana6 && sciana26 != sciana7 && sciana26 != sciana8 && sciana26 != sciana9 && sciana26 != sciana10 &&
                    sciana26 != sciana11 && sciana26 != sciana12 && sciana26 != sciana13 && sciana26 != sciana14 && sciana26 != sciana15 &&
                    sciana26 != sciana16 && sciana26 != sciana17 && sciana26 != sciana18 && sciana26 != sciana19 && sciana26 != sciana20 &&
                    sciana26 != sciana21 && sciana26 != sciana22 && sciana26 != sciana23 && sciana26 != sciana24 && sciana26 != sciana25)
                    break;
            }
            plansza[sciana26 / 10, sciana26 % 10] = sciana;

            // Wall 27
            while (true)
            {
                sciana27 = rnd.Next(0, 100);
                if (sciana27 != graczPos && sciana27 != pis1 && sciana27 != pis2 && sciana27 != pis3 && sciana27 != pis4 &&
                    sciana27 != pis5 && sciana27 != pis6 && sciana27 != pis7 && sciana27 != pis8 && sciana27 != pis9 && sciana27 != pis10 &&
                    sciana27 != sciana1 && sciana27 != sciana2 && sciana27 != sciana3 && sciana27 != sciana4 && sciana27 != sciana5 &&
                    sciana27 != sciana6 && sciana27 != sciana7 && sciana27 != sciana8 && sciana27 != sciana9 && sciana27 != sciana10 &&
                    sciana27 != sciana11 && sciana27 != sciana12 && sciana27 != sciana13 && sciana27 != sciana14 && sciana27 != sciana15 &&
                    sciana27 != sciana16 && sciana27 != sciana17 && sciana27 != sciana18 && sciana27 != sciana19 && sciana27 != sciana20 &&
                    sciana27 != sciana21 && sciana27 != sciana22 && sciana27 != sciana23 && sciana27 != sciana24 && sciana27 != sciana25 && sciana27 != sciana26)
                    break;
            }
            plansza[sciana27 / 10, sciana27 % 10] = sciana;

            // Wall 28
            while (true)
            {
                sciana28 = rnd.Next(0, 100);
                if (sciana28 != graczPos && sciana28 != pis1 && sciana28 != pis2 && sciana28 != pis3 && sciana28 != pis4 &&
                    sciana28 != pis5 && sciana28 != pis6 && sciana28 != pis7 && sciana28 != pis8 && sciana28 != pis9 && sciana28 != pis10 &&
                    sciana28 != sciana1 && sciana28 != sciana2 && sciana28 != sciana3 && sciana28 != sciana4 && sciana28 != sciana5 &&
                    sciana28 != sciana6 && sciana28 != sciana7 && sciana28 != sciana8 && sciana28 != sciana9 && sciana28 != sciana10 &&
                    sciana28 != sciana11 && sciana28 != sciana12 && sciana28 != sciana13 && sciana28 != sciana14 && sciana28 != sciana15 &&
                    sciana28 != sciana16 && sciana28 != sciana17 && sciana28 != sciana18 && sciana28 != sciana19 && sciana28 != sciana20 &&
                    sciana28 != sciana21 && sciana28 != sciana22 && sciana28 != sciana23 && sciana28 != sciana24 && sciana28 != sciana25 &&
                    sciana28 != sciana26 && sciana28 != sciana27)
                    break;
            }
            plansza[sciana28 / 10, sciana28 % 10] = sciana;

            // Wall 29
            while (true)
            {
                sciana29 = rnd.Next(0, 100);
                if (sciana29 != graczPos && sciana29 != pis1 && sciana29 != pis2 && sciana29 != pis3 && sciana29 != pis4 &&
                    sciana29 != pis5 && sciana29 != pis6 && sciana29 != pis7 && sciana29 != pis8 && sciana29 != pis9 && sciana29 != pis10 &&
                    sciana29 != sciana1 && sciana29 != sciana2 && sciana29 != sciana3 && sciana29 != sciana4 && sciana29 != sciana5 &&
                    sciana29 != sciana6 && sciana29 != sciana7 && sciana29 != sciana8 && sciana29 != sciana9 && sciana29 != sciana10 &&
                    sciana29 != sciana11 && sciana29 != sciana12 && sciana29 != sciana13 && sciana29 != sciana14 && sciana29 != sciana15 &&
                    sciana29 != sciana16 && sciana29 != sciana17 && sciana29 != sciana18 && sciana29 != sciana19 && sciana29 != sciana20 &&
                    sciana29 != sciana21 && sciana29 != sciana22 && sciana29 != sciana23 && sciana29 != sciana24 && sciana29 != sciana25 &&
                    sciana29 != sciana26 && sciana29 != sciana27 && sciana29 != sciana28)
                    break;
            }
            plansza[sciana29 / 10, sciana29 % 10] = sciana;

            // Wall 30
            while (true)
            {
                sciana30 = rnd.Next(0, 100);
                if (sciana30 != graczPos && sciana30 != pis1 && sciana30 != pis2 && sciana30 != pis3 && sciana30 != pis4 &&
                    sciana30 != pis5 && sciana30 != pis6 && sciana30 != pis7 && sciana30 != pis8 && sciana30 != pis9 && sciana30 != pis10 &&
                    sciana30 != sciana1 && sciana30 != sciana2 && sciana30 != sciana3 && sciana30 != sciana4 && sciana30 != sciana5 &&
                    sciana30 != sciana6 && sciana30 != sciana7 && sciana30 != sciana8 && sciana30 != sciana9 && sciana30 != sciana10 &&
                    sciana30 != sciana11 && sciana30 != sciana12 && sciana30 != sciana13 && sciana30 != sciana14 && sciana30 != sciana15 &&
                    sciana30 != sciana16 && sciana30 != sciana17 && sciana30 != sciana18 && sciana30 != sciana19 && sciana30 != sciana20 &&
                    sciana30 != sciana21 && sciana30 != sciana22 && sciana30 != sciana23 && sciana30 != sciana24 && sciana30 != sciana25 &&
                    sciana30 != sciana26 && sciana30 != sciana27 && sciana30 != sciana28 && sciana30 != sciana29)
                    break;
            }
            plansza[sciana30 / 10, sciana30 % 10] = sciana;

            // Wall 31
            while (true)
            {
                sciana31 = rnd.Next(0, 100);
                if (sciana31 != graczPos && sciana31 != pis1 && sciana31 != pis2 && sciana31 != pis3 && sciana31 != pis4 &&
                    sciana31 != pis5 && sciana31 != pis6 && sciana31 != pis7 && sciana31 != pis8 && sciana31 != pis9 && sciana31 != pis10 &&
                    sciana31 != sciana1 && sciana31 != sciana2 && sciana31 != sciana3 && sciana31 != sciana4 && sciana31 != sciana5 &&
                    sciana31 != sciana6 && sciana31 != sciana7 && sciana31 != sciana8 && sciana31 != sciana9 && sciana31 != sciana10 &&
                    sciana31 != sciana11 && sciana31 != sciana12 && sciana31 != sciana13 && sciana31 != sciana14 && sciana31 != sciana15 &&
                    sciana31 != sciana16 && sciana31 != sciana17 && sciana31 != sciana18 && sciana31 != sciana19 && sciana31 != sciana20 &&
                    sciana31 != sciana21 && sciana31 != sciana22 && sciana31 != sciana23 && sciana31 != sciana24 && sciana31 != sciana25 &&
                    sciana31 != sciana26 && sciana31 != sciana27 && sciana31 != sciana28 && sciana31 != sciana29 && sciana31 != sciana30)
                    break;
            }
            plansza[sciana31 / 10, sciana31 % 10] = sciana;

            // Wall 32
            while (true)
            {
                sciana32 = rnd.Next(0, 100);
                if (sciana32 != graczPos && sciana32 != pis1 && sciana32 != pis2 && sciana32 != pis3 && sciana32 != pis4 &&
                    sciana32 != pis5 && sciana32 != pis6 && sciana32 != pis7 && sciana32 != pis8 && sciana32 != pis9 && sciana32 != pis10 &&
                    sciana32 != sciana1 && sciana32 != sciana2 && sciana32 != sciana3 && sciana32 != sciana4 && sciana32 != sciana5 &&
                    sciana32 != sciana6 && sciana32 != sciana7 && sciana32 != sciana8 && sciana32 != sciana9 && sciana32 != sciana10 &&
                    sciana32 != sciana11 && sciana32 != sciana12 && sciana32 != sciana13 && sciana32 != sciana14 && sciana32 != sciana15 &&
                    sciana32 != sciana16 && sciana32 != sciana17 && sciana32 != sciana18 && sciana32 != sciana19 && sciana32 != sciana20 &&
                    sciana32 != sciana21 && sciana32 != sciana22 && sciana32 != sciana23 && sciana32 != sciana24 && sciana32 != sciana25 &&
                    sciana32 != sciana26 && sciana32 != sciana27 && sciana32 != sciana28 && sciana32 != sciana29 && sciana32 != sciana30 && sciana32 != sciana31)
                    break;
            }
            plansza[sciana32 / 10, sciana32 % 10] = sciana;

            // Wall 33
            while (true)
            {
                sciana33 = rnd.Next(0, 100);
                if (sciana33 != graczPos && sciana33 != pis1 && sciana33 != pis2 && sciana33 != pis3 && sciana33 != pis4 &&
                    sciana33 != pis5 && sciana33 != pis6 && sciana33 != pis7 && sciana33 != pis8 && sciana33 != pis9 && sciana33 != pis10 &&
                    sciana33 != sciana1 && sciana33 != sciana2 && sciana33 != sciana3 && sciana33 != sciana4 && sciana33 != sciana5 &&
                    sciana33 != sciana6 && sciana33 != sciana7 && sciana33 != sciana8 && sciana33 != sciana9 && sciana33 != sciana10 &&
                    sciana33 != sciana11 && sciana33 != sciana12 && sciana33 != sciana13 && sciana33 != sciana14 && sciana33 != sciana15 &&
                    sciana33 != sciana16 && sciana33 != sciana17 && sciana33 != sciana18 && sciana33 != sciana19 && sciana33 != sciana20 &&
                    sciana33 != sciana21 && sciana33 != sciana22 && sciana33 != sciana23 && sciana33 != sciana24 && sciana33 != sciana25 &&
                    sciana33 != sciana26 && sciana33 != sciana27 && sciana33 != sciana28 && sciana33 != sciana29 && sciana33 != sciana30 &&
                    sciana33 != sciana31 && sciana33 != sciana32)
                    break;
            }
            plansza[sciana33 / 10, sciana33 % 10] = sciana;

            // Wall 34
            while (true)
            {
                sciana34 = rnd.Next(0, 100);
                if (sciana34 != graczPos && sciana34 != pis1 && sciana34 != pis2 && sciana34 != pis3 && sciana34 != pis4 &&
                    sciana34 != pis5 && sciana34 != pis6 && sciana34 != pis7 && sciana34 != pis8 && sciana34 != pis9 && sciana34 != pis10 &&
                    sciana34 != sciana1 && sciana34 != sciana2 && sciana34 != sciana3 && sciana34 != sciana4 && sciana34 != sciana5 &&
                    sciana34 != sciana6 && sciana34 != sciana7 && sciana34 != sciana8 && sciana34 != sciana9 && sciana34 != sciana10 &&
                    sciana34 != sciana11 && sciana34 != sciana12 && sciana34 != sciana13 && sciana34 != sciana14 && sciana34 != sciana15 &&
                    sciana34 != sciana16 && sciana34 != sciana17 && sciana34 != sciana18 && sciana34 != sciana19 && sciana34 != sciana20 &&
                    sciana34 != sciana21 && sciana34 != sciana22 && sciana34 != sciana23 && sciana34 != sciana24 && sciana34 != sciana25 &&
                    sciana34 != sciana26 && sciana34 != sciana27 && sciana34 != sciana28 && sciana34 != sciana29 && sciana34 != sciana30 &&
                    sciana34 != sciana31 && sciana34 != sciana32 && sciana34 != sciana33)
                    break;
            }
            plansza[sciana34 / 10, sciana34 % 10] = sciana;

            // Wall 35
            while (true)
            {
                sciana35 = rnd.Next(0, 100);
                if (sciana35 != graczPos && sciana35 != pis1 && sciana35 != pis2 && sciana35 != pis3 && sciana35 != pis4 &&
                    sciana35 != pis5 && sciana35 != pis6 && sciana35 != pis7 && sciana35 != pis8 && sciana35 != pis9 && sciana35 != pis10 &&
                    sciana35 != sciana1 && sciana35 != sciana2 && sciana35 != sciana3 && sciana35 != sciana4 && sciana35 != sciana5 &&
                    sciana35 != sciana6 && sciana35 != sciana7 && sciana35 != sciana8 && sciana35 != sciana9 && sciana35 != sciana10 &&
                    sciana35 != sciana11 && sciana35 != sciana12 && sciana35 != sciana13 && sciana35 != sciana14 && sciana35 != sciana15 &&
                    sciana35 != sciana16 && sciana35 != sciana17 && sciana35 != sciana18 && sciana35 != sciana19 && sciana35 != sciana20 &&
                    sciana35 != sciana21 && sciana35 != sciana22 && sciana35 != sciana23 && sciana35 != sciana24 && sciana35 != sciana25 &&
                    sciana35 != sciana26 && sciana35 != sciana27 && sciana35 != sciana28 && sciana35 != sciana29 && sciana35 != sciana30 &&
                    sciana35 != sciana31 && sciana35 != sciana32 && sciana35 != sciana33 && sciana35 != sciana34)
                    break;
            }
            plansza[sciana35 / 10, sciana35 % 10] = sciana;

            // Wall 36
            while (true)
            {
                sciana36 = rnd.Next(0, 100);
                if (sciana36 != graczPos && sciana36 != pis1 && sciana36 != pis2 && sciana36 != pis3 && sciana36 != pis4 &&
                    sciana36 != pis5 && sciana36 != pis6 && sciana36 != pis7 && sciana36 != pis8 && sciana36 != pis9 && sciana36 != pis10 &&
                    sciana36 != sciana1 && sciana36 != sciana2 && sciana36 != sciana3 && sciana36 != sciana4 && sciana36 != sciana5 &&
                    sciana36 != sciana6 && sciana36 != sciana7 && sciana36 != sciana8 && sciana36 != sciana9 && sciana36 != sciana10 &&
                    sciana36 != sciana11 && sciana36 != sciana12 && sciana36 != sciana13 && sciana36 != sciana14 && sciana36 != sciana15 &&
                    sciana36 != sciana16 && sciana36 != sciana17 && sciana36 != sciana18 && sciana36 != sciana19 && sciana36 != sciana20 &&
                    sciana36 != sciana21 && sciana36 != sciana22 && sciana36 != sciana23 && sciana36 != sciana24 && sciana36 != sciana25 &&
                    sciana36 != sciana26 && sciana36 != sciana27 && sciana36 != sciana28 && sciana36 != sciana29 && sciana36 != sciana30 &&
                    sciana36 != sciana31 && sciana36 != sciana32 && sciana36 != sciana33 && sciana36 != sciana34 && sciana36 != sciana35)
                    break;
            }
            plansza[sciana36 / 10, sciana36 % 10] = sciana;

            // Wall 37
            while (true)
            {
                sciana37 = rnd.Next(0, 100);
                if (sciana37 != graczPos && sciana37 != pis1 && sciana37 != pis2 && sciana37 != pis3 && sciana37 != pis4 &&
                    sciana37 != pis5 && sciana37 != pis6 && sciana37 != pis7 && sciana37 != pis8 && sciana37 != pis9 && sciana37 != pis10 &&
                    sciana37 != sciana1 && sciana37 != sciana2 && sciana37 != sciana3 && sciana37 != sciana4 && sciana37 != sciana5 &&
                    sciana37 != sciana6 && sciana37 != sciana7 && sciana37 != sciana8 && sciana37 != sciana9 && sciana37 != sciana10 &&
                    sciana37 != sciana11 && sciana37 != sciana12 && sciana37 != sciana13 && sciana37 != sciana14 && sciana37 != sciana15 &&
                    sciana37 != sciana16 && sciana37 != sciana17 && sciana37 != sciana18 && sciana37 != sciana19 && sciana37 != sciana20 &&
                    sciana37 != sciana21 && sciana37 != sciana22 && sciana37 != sciana23 && sciana37 != sciana24 && sciana37 != sciana25 &&
                    sciana37 != sciana26 && sciana37 != sciana27 && sciana37 != sciana28 && sciana37 != sciana29 && sciana37 != sciana30 &&
                    sciana37 != sciana31 && sciana37 != sciana32 && sciana37 != sciana33 && sciana37 != sciana34 && sciana37 != sciana35 && sciana37 != sciana36)
                    break;
            }
            plansza[sciana37 / 10, sciana37 % 10] = sciana;

            // Wall 38
            while (true)
            {
                sciana38 = rnd.Next(0, 100);
                if (sciana38 != graczPos && sciana38 != pis1 && sciana38 != pis2 && sciana38 != pis3 && sciana38 != pis4 &&
                    sciana38 != pis5 && sciana38 != pis6 && sciana38 != pis7 && sciana38 != pis8 && sciana38 != pis9 && sciana38 != pis10 &&
                    sciana38 != sciana1 && sciana38 != sciana2 && sciana38 != sciana3 && sciana38 != sciana4 && sciana38 != sciana5 &&
                    sciana38 != sciana6 && sciana38 != sciana7 && sciana38 != sciana8 && sciana38 != sciana9 && sciana38 != sciana10 &&
                    sciana38 != sciana11 && sciana38 != sciana12 && sciana38 != sciana13 && sciana38 != sciana14 && sciana38 != sciana15 &&
                    sciana38 != sciana16 && sciana38 != sciana17 && sciana38 != sciana18 && sciana38 != sciana19 && sciana38 != sciana20 &&
                    sciana38 != sciana21 && sciana38 != sciana22 && sciana38 != sciana23 && sciana38 != sciana24 && sciana38 != sciana25 &&
                    sciana38 != sciana26 && sciana38 != sciana27 && sciana38 != sciana28 && sciana38 != sciana29 && sciana38 != sciana30 &&
                    sciana38 != sciana31 && sciana38 != sciana32 && sciana38 != sciana33 && sciana38 != sciana34 && sciana38 != sciana35 &&
                    sciana38 != sciana36 && sciana38 != sciana37)
                    break;
            }
            plansza[sciana38 / 10, sciana38 % 10] = sciana;

            // Wall 39
            while (true)
            {
                sciana39 = rnd.Next(0, 100);
                if (sciana39 != graczPos && sciana39 != pis1 && sciana39 != pis2 && sciana39 != pis3 && sciana39 != pis4 &&
                    sciana39 != pis5 && sciana39 != pis6 && sciana39 != pis7 && sciana39 != pis8 && sciana39 != pis9 && sciana39 != pis10 &&
                    sciana39 != sciana1 && sciana39 != sciana2 && sciana39 != sciana3 && sciana39 != sciana4 && sciana39 != sciana5 &&
                    sciana39 != sciana6 && sciana39 != sciana7 && sciana39 != sciana8 && sciana39 != sciana9 && sciana39 != sciana10 &&
                    sciana39 != sciana11 && sciana39 != sciana12 && sciana39 != sciana13 && sciana39 != sciana14 && sciana39 != sciana15 &&
                    sciana39 != sciana16 && sciana39 != sciana17 && sciana39 != sciana18 && sciana39 != sciana19 && sciana39 != sciana20 &&
                    sciana39 != sciana21 && sciana39 != sciana22 && sciana39 != sciana23 && sciana39 != sciana24 && sciana39 != sciana25 &&
                    sciana39 != sciana26 && sciana39 != sciana27 && sciana39 != sciana28 && sciana39 != sciana29 && sciana39 != sciana30 &&
                    sciana39 != sciana31 && sciana39 != sciana32 && sciana39 != sciana33 && sciana39 != sciana34 && sciana39 != sciana35 &&
                    sciana39 != sciana36 && sciana39 != sciana37 && sciana39 != sciana38)
                    break;
            }
            plansza[sciana39 / 10, sciana39 % 10] = sciana;

            // Wall 40
            while (true)
            {
                sciana40 = rnd.Next(0, 100);
                if (sciana40 != graczPos && sciana40 != pis1 && sciana40 != pis2 && sciana40 != pis3 && sciana40 != pis4 &&
                    sciana40 != pis5 && sciana40 != pis6 && sciana40 != pis7 && sciana40 != pis8 && sciana40 != pis9 && sciana40 != pis10 &&
                    sciana40 != sciana1 && sciana40 != sciana2 && sciana40 != sciana3 && sciana40 != sciana4 && sciana40 != sciana5 &&
                    sciana40 != sciana6 && sciana40 != sciana7 && sciana40 != sciana8 && sciana40 != sciana9 && sciana40 != sciana10 &&
                    sciana40 != sciana11 && sciana40 != sciana12 && sciana40 != sciana13 && sciana40 != sciana14 && sciana40 != sciana15 &&
                    sciana40 != sciana16 && sciana40 != sciana17 && sciana40 != sciana18 && sciana40 != sciana19 && sciana40 != sciana20 &&
                    sciana40 != sciana21 && sciana40 != sciana22 && sciana40 != sciana23 && sciana40 != sciana24 && sciana40 != sciana25 &&
                    sciana40 != sciana26 && sciana40 != sciana27 && sciana40 != sciana28 && sciana40 != sciana29 && sciana40 != sciana30 &&
                    sciana40 != sciana31 && sciana40 != sciana32 && sciana40 != sciana33 && sciana40 != sciana34 && sciana40 != sciana35 &&
                    sciana40 != sciana36 && sciana40 != sciana37 && sciana40 != sciana38 && sciana40 != sciana39)
                    break;
            }
            plansza[sciana40 / 10, sciana40 % 10] = sciana;
        }

        static void Show_Landscape()
        {
            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (plansza[i, j] == 0)
                        Console.Write($"_ ");
                    if (plansza[i, j] == 1)
                        Console.Write($"0 ");
                    if (plansza[i, j] == 2)
                        Console.Write($"| ");
                    if (plansza[i, j] == 3)
                        Console.Write($"█ ");
                }
                Console.Write("\n");
            }
        }
    }
}