using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum RotationState
    {
        Up,
        Right,
        Down,
        Doleva,
        Unset
    }
    class Program
    {
        static void Main(string[] args)
        {

            



            Lode Ships = new Lode();
            
            Lode Ships2 = new Lode();

            Lode Ships3 = new Lode();

            ConsoleKeyInfo input;
			string inputToKursor;
			bool game = true;
            bool game2 = true;
            int Player = 1;
            int Player1Reecon = 3;
            int Player1Fire = 3;
            int Player2Reecon = 3;
            int Player2Fire = 3;
            int Player3Reecon = 3;
            int Player3Fire = 3;

            Mapa Mapa1 = new Mapa();
            Mapa Mapa2 = new Mapa();
            Mapa Mapa3 = new Mapa();
            Mapa1.GenerateMap();
            Mapa2.GenerateMap();
            Mapa3.GenerateMap();

            while (game)
			{
                Console.WriteLine("Hráči 1 připrav se pokládat své lodě.");
                Console.WriteLine("Ujisti se aby tě tvůj protivník neviděl jej pokládat");
                Console.ReadKey();
                Console.Clear();

                while (true)
                {
                    if (Mapa1.NumOFShips == 0)
                    {
                        Console.Clear();
                        Console.WriteLine(Mapa1.TextToPlayer);
                        Mapa1.PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        Mapa1.MapKurzor(inputToKursor);
                        Mapa1.PlaceShip(Ships.GetShip(6));
                        
                    }
                    else if (Mapa1.NumOFShips == 1)
                    {
                        Console.Clear();
                        Console.WriteLine(Mapa1.TextToPlayer);
                        Mapa1.PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        Mapa1.MapKurzor(inputToKursor);
                        Mapa1.PlaceShip(Ships.GetShip(3));
                        
                    }
                    else if (Mapa1.NumOFShips == 2)
                    {
                        Console.Clear();
                        Console.WriteLine(Mapa1.TextToPlayer);
                        Mapa1.PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        Mapa1.MapKurzor(inputToKursor);
                        Mapa1.PlaceShip(Ships.GetShip(2));
                    }
                    else if (Mapa1.NumOFShips == 3)
                    {
                        Console.Clear();
                        Console.WriteLine(Mapa1.TextToPlayer);
                        Mapa1.PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        Mapa1.MapKurzor(inputToKursor);
                        Mapa1.PlaceShip(Ships.GetShip(5));
                    }
                    else if (Mapa1.NumOFShips == 4)
                    {
                        Console.Clear();
                        Console.WriteLine(Mapa1.TextToPlayer);
                        Mapa1.PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        Mapa1.MapKurzor(inputToKursor);
                        Mapa1.PlaceShip(Ships.GetShip(1));
                    }
                    else if (Mapa1.NumOFShips == 5)
                    {
                        Console.Clear();
                        Console.WriteLine(Mapa1.TextToPlayer);
                        Mapa1.PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        Mapa1.MapKurzor(inputToKursor);
                        Mapa1.PlaceShip(Ships.GetShip(0));
                    }
                    else
                    {
                        break;
                    }
                }
                Console.Clear();
                Console.WriteLine("Hráči 2 připrav se pokládat své lodě.");
                Console.WriteLine("Ujisti se aby tě tvůj protivník neviděl jej pokládat");
                Console.ReadKey();
                Console.Clear();

                while (true)
                {
                    if (Mapa2.NumOFShips == 0)
                    {
                        Console.Clear();
                        Console.WriteLine(Mapa2.TextToPlayer);
                        Mapa2.PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        Mapa2.MapKurzor(inputToKursor);
                        Mapa2.PlaceShip(Ships2.GetShip(6));

                    }
                    else if (Mapa2.NumOFShips == 1)
                    {
                        Console.Clear();
                        Console.WriteLine(Mapa2.TextToPlayer);
                        Mapa2.PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        Mapa2.MapKurzor(inputToKursor);
                        Mapa2.PlaceShip(Ships2.GetShip(3));

                    }
                    else if (Mapa2.NumOFShips == 2)
                    {
                        Console.Clear();
                        Console.WriteLine(Mapa2.TextToPlayer);
                        Mapa2.PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        Mapa2.MapKurzor(inputToKursor);
                        Mapa2.PlaceShip(Ships2.GetShip(2));
                    }
                    else if (Mapa2.NumOFShips == 3)
                    {
                        Console.Clear();
                        Console.WriteLine(Mapa2.TextToPlayer);
                        Mapa2.PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        Mapa2.MapKurzor(inputToKursor);
                        Mapa2.PlaceShip(Ships2.GetShip(5));
                    }
                    else if (Mapa2.NumOFShips == 4)
                    {
                        Console.Clear();
                        Console.WriteLine(Mapa2.TextToPlayer);
                        Mapa2.PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        Mapa2.MapKurzor(inputToKursor);
                        Mapa2.PlaceShip(Ships2.GetShip(1));
                    }
                    else if (Mapa2.NumOFShips == 5)
                    {
                        Console.Clear();
                        Console.WriteLine(Mapa2.TextToPlayer);
                        Mapa2.PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        Mapa2.MapKurzor(inputToKursor);
                        Mapa2.PlaceShip(Ships2.GetShip(0));
                    }
                    else
                    {
                        break;
                    }
                }

                Console.Clear();
                Console.WriteLine("Hráči 3 připrav se pokládat své lodě.");
                Console.WriteLine("Ujisti se aby tě tvůj protivník neviděl jej pokládat");
                Console.ReadKey();
                Console.Clear();

                while (true)
                {
                    if (Mapa3.NumOFShips == 0)
                    {
                        Console.Clear();
                        Console.WriteLine(Mapa3.TextToPlayer);
                        Mapa3.PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        Mapa3.MapKurzor(inputToKursor);
                        Mapa3.PlaceShip(Ships3.GetShip(6));

                    }
                    else if (Mapa3.NumOFShips == 1)
                    {
                        Console.Clear();
                        Console.WriteLine(Mapa3.TextToPlayer);
                        Mapa3.PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        Mapa3.MapKurzor(inputToKursor);
                        Mapa3.PlaceShip(Ships3.GetShip(3));

                    }
                    else if (Mapa3.NumOFShips == 2)
                    {
                        Console.Clear();
                        Console.WriteLine(Mapa3.TextToPlayer);
                        Mapa3.PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        Mapa3.MapKurzor(inputToKursor);
                        Mapa3.PlaceShip(Ships3.GetShip(2));
                    }
                    else if (Mapa3.NumOFShips == 3)
                    {
                        Console.Clear();
                        Console.WriteLine(Mapa3.TextToPlayer);
                        Mapa3.PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        Mapa3.MapKurzor(inputToKursor);
                        Mapa3.PlaceShip(Ships3.GetShip(5));
                    }
                    else if (Mapa3.NumOFShips == 4)
                    {
                        Console.Clear();
                        Console.WriteLine(Mapa3.TextToPlayer);
                        Mapa3.PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        Mapa3.MapKurzor(inputToKursor);
                        Mapa3.PlaceShip(Ships3.GetShip(1));
                    }
                    else if (Mapa3.NumOFShips == 5)
                    {
                        Console.Clear();
                        Console.WriteLine(Mapa3.TextToPlayer);
                        Mapa3.PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        Mapa3.MapKurzor(inputToKursor);
                        Mapa3.PlaceShip(Ships3.GetShip(0));
                    }
                    else
                    {
                        break;
                    }
                }

                Mapa1.RemoveInvalid();
                Mapa2.RemoveInvalid();
                Mapa3.RemoveInvalid();
                while (game2)
                {
                    
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("je na tahu hráč " + (Player));
                        Console.WriteLine("Zásoby ostrých ran Hráče 1: " + Player1Fire + "  | Zásoby ostrých ran Hráče 2: " + Player2Fire + "  | Zásoby ostrých ran Hráče 3: " + Player3Fire);
                        Console.WriteLine("Zásoby Odhalovacích ran Hráče 1: " + Player1Reecon + " | Zásoby Odhalovacích ran Hráče 2: " + Player2Reecon + " | Zásoby Odhalovacích ran Hráče 3: " + Player3Reecon);
                        Console.WriteLine("1 = 1 ranná ostrá rána | 2 = 3 ranná nepřesná ostrá střelba | 0 = konec tahu");
                        Console.WriteLine("1 = 4 ranná označovací rána | 5 = 3 ranná nepřesná označovací střelba | 6 = řada označovacích ran");
                        Console.WriteLine("Mapa hráče 1");
                        Mapa1.PrintMapToHit();
                        Console.WriteLine();
                        Console.WriteLine("Mapa hráče 2");
                        Mapa2.PrintMapToHit();
                        Console.WriteLine();
                        Console.WriteLine("Mapa hráče 3");
                        Mapa3.PrintMapToHit();

                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();

                        if(Player == 1)
                        {
                            if (inputToKursor == "1")
                            {
                                while (true)
                                {
                                    if (Player1Fire < 1)
                                    {
                                        break;
                                    }

                                    Console.Clear();
                                    Console.WriteLine("|0 Zpět na výběr|");
                                    Console.WriteLine("|Cena: 1 Zásoba ostrých ran||Zbývá: " + Player1Fire + " |");

                                    Mapa2.PrintMapToHit();
                                    input = Console.ReadKey();
                                    inputToKursor = input.KeyChar.ToString();

                                    if (inputToKursor == "0")
                                    {
                                        break;
                                    }
                                    else if (inputToKursor == " ")
                                    {
                                        Player1Fire--;
                                    }
                                    
                                    Mapa2.MapKurzor(inputToKursor);
                                    Mapa2.Shoot(Ships2.GetShip(0));
                                }

                            }
                            else if (inputToKursor == "2")
                            {
                                while (true)
                                {
                                    if (Player1Fire < 2)
                                    {
                                        break;
                                    }

                                    Console.Clear();
                                    Console.WriteLine("|0 Zpět na výběr|");
                                    Console.WriteLine("|Cena: 2 Zásobay ostrých ran||Zbývá: " + Player1Fire + " |");

                                    Mapa2.PrintMapToHit();
                                    input = Console.ReadKey();
                                    inputToKursor = input.KeyChar.ToString();

                                    if (inputToKursor == "0")
                                    {
                                        break;
                                    }
                                    else if (inputToKursor == " ")
                                    {
                                        Player1Fire = Player1Fire - 2;
                                    }
                                    
                                    Mapa2.MapKurzor(inputToKursor);
                                    Mapa2.Shoot(Ships2.GetShip(5));
                                }

                            }
                            else if (inputToKursor == "4")
                            {
                                while (true)
                                {
                                    if (Player1Reecon < 1)
                                    {
                                        break;
                                    }

                                    Console.Clear();
                                    Console.WriteLine("|0 Zpět na výběr|");
                                    Console.WriteLine("|Cena: 1 Zásoba Odhalovacích ran||Zbývá: " + Player1Reecon + " |");

                                    Mapa2.PrintMapToHit();
                                    input = Console.ReadKey();
                                    inputToKursor = input.KeyChar.ToString();

                                    if (inputToKursor == "0")
                                    {
                                        break;
                                    }
                                    else if (inputToKursor == " ")
                                    {
                                        Player1Reecon--;
                                    }
                                    
                                    Mapa2.MapKurzor(inputToKursor);
                                    Mapa2.Discover(Ships2.GetShip(0));
                                }

                            }
                            else if (inputToKursor == "5")
                            {
                                while (true)
                                {
                                    if (Player1Reecon < 2)
                                    {
                                        break;
                                    }

                                    Console.Clear();
                                    Console.WriteLine("|0 Zpět na výběr|");
                                    Console.WriteLine("|Cena: 2 Zásoby Odhalovacích ran||Zbývá: " + Player1Reecon + " |");

                                    Mapa2.PrintMapToHit();
                                    input = Console.ReadKey();
                                    inputToKursor = input.KeyChar.ToString();

                                    if (inputToKursor == "0")
                                    {
                                        break;
                                    }
                                    else if (inputToKursor == " ")
                                    {
                                        Player1Reecon = Player1Reecon - 2;
                                    }
                                    
                                    Mapa2.MapKurzor(inputToKursor);
                                    Mapa2.Discover(Ships2.GetShip(5));
                                }

                            }
                            else if (inputToKursor == "6")
                            {
                                while (true)
                                {
                                    if (Player1Reecon < 4)
                                    {
                                        break;
                                    }

                                    Console.Clear();
                                    Console.WriteLine("|0 Zpět na výběr|");
                                    Console.WriteLine("|Cena: 4 Zásoba Odhalovacích ran||Zbývá: " + Player1Reecon + " |");

                                    Mapa2.PrintMapToHit();
                                    input = Console.ReadKey();
                                    inputToKursor = input.KeyChar.ToString();

                                    if (inputToKursor == "0")
                                    {
                                        break;
                                    }
                                    else if (inputToKursor == " ")
                                    {
                                        Player1Reecon = Player1Reecon - 4;
                                    }
                                    
                                    Mapa2.MapKurzor(inputToKursor);
                                    Mapa2.Discover(Ships2.GetShip(4));
                                }

                            }
                            else if (inputToKursor == "0")
                            {
                                if (Player == 1)
                                {
                                    Player1Fire++;
                                    Player1Reecon++;
                                    Player = 2;
                                }
                                else if (Player == 2)
                                {
                                    Player2Fire++;
                                    Player2Reecon++;
                                    Player = 3;
                                }else
                                {
                                    Player3Fire++;
                                    Player3Reecon++;
                                    Player = 1;
                                }
                                if (Mapa1.DestroyedShips() == true)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Vyhrál hráč 3!");
                                    Console.ReadKey();
                                    game = false;
                                    game2 = false;
                                    break;
                                }
                                else if (Mapa2.DestroyedShips() == true)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Vyhrál hráč 1!");
                                    Console.ReadKey();
                                    game = false;
                                    game2 = false;
                                    break;
                                }
                                else if (Mapa3.DestroyedShips() == true)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Vyhrál hráč 2!");
                                    Console.ReadKey();
                                    game = false;
                                    game2 = false;
                                    break;
                                }
                                break;
                            }

                        }
                        else if (Player == 2)
                        {
                            if (inputToKursor == "1")
                            {
                                while (true)
                                {
                                    if (Player2Fire < 1)
                                    {
                                        break;
                                    }

                                    Console.Clear();
                                    Console.WriteLine("|0 Zpět na výběr|");
                                    Console.WriteLine("|Cena: 1 Zásoba ostrých ran||Zbývá: " + Player2Fire + " |");

                                    Mapa3.PrintMapToHit();
                                    input = Console.ReadKey();
                                    inputToKursor = input.KeyChar.ToString();

                                    if (inputToKursor == "0")
                                    {
                                        break;
                                    }
                                    else if (inputToKursor == " ")
                                    {
                                        Player2Fire--;
                                    }

                                    Mapa3.MapKurzor(inputToKursor);
                                    Mapa3.Shoot(Ships2.GetShip(0));
                                }

                            }
                            else if (inputToKursor == "2")
                            {
                                while (true)
                                {
                                    if (Player2Fire < 2)
                                    {
                                        break;
                                    }

                                    Console.Clear();
                                    Console.WriteLine("|0 Zpět na výběr|");
                                    Console.WriteLine("|Cena: 2 Zásobay ostrých ran||Zbývá: " + Player2Fire + " |");

                                    Mapa3.PrintMapToHit();
                                    input = Console.ReadKey();
                                    inputToKursor = input.KeyChar.ToString();

                                    if (inputToKursor == "0")
                                    {
                                        break;
                                    }
                                    else if (inputToKursor == " ")
                                    {
                                        Player2Fire = Player2Fire - 2;
                                    }

                                    Mapa3.MapKurzor(inputToKursor);
                                    Mapa3.Shoot(Ships2.GetShip(5));
                                }

                            }
                            else if (inputToKursor == "4")
                            {
                                while (true)
                                {
                                    if (Player2Reecon < 1)
                                    {
                                        break;
                                    }

                                    Console.Clear();
                                    Console.WriteLine("|0 Zpět na výběr|");
                                    Console.WriteLine("|Cena: 1 Zásoba Odhalovacích ran||Zbývá: " + Player2Reecon + " |");

                                    Mapa3.PrintMapToHit();
                                    input = Console.ReadKey();
                                    inputToKursor = input.KeyChar.ToString();

                                    if (inputToKursor == "0")
                                    {
                                        break;
                                    }
                                    else if (inputToKursor == " ")
                                    {
                                        Player2Reecon--;
                                    }

                                    Mapa3.MapKurzor(inputToKursor);
                                    Mapa3.Discover(Ships2.GetShip(0));
                                }

                            }
                            else if (inputToKursor == "5")
                            {
                                while (true)
                                {
                                    if (Player2Reecon < 2)
                                    {
                                        break;
                                    }

                                    Console.Clear();
                                    Console.WriteLine("|0 Zpět na výběr|");
                                    Console.WriteLine("|Cena: 2 Zásoby Odhalovacích ran||Zbývá: " + Player2Reecon + " |");

                                    Mapa3.PrintMapToHit();
                                    input = Console.ReadKey();
                                    inputToKursor = input.KeyChar.ToString();

                                    if (inputToKursor == "0")
                                    {
                                        break;
                                    }
                                    else if (inputToKursor == " ")
                                    {
                                        Player2Reecon = Player2Reecon - 2;
                                    }

                                    Mapa3.MapKurzor(inputToKursor);
                                    Mapa3.Discover(Ships2.GetShip(5));
                                }

                            }
                            else if (inputToKursor == "6")
                            {
                                while (true)
                                {
                                    if (Player2Reecon < 4)
                                    {
                                        break;
                                    }

                                    Console.Clear();
                                    Console.WriteLine("|0 Zpět na výběr|");
                                    Console.WriteLine("|Cena: 4 Zásoba Odhalovacích ran||Zbývá: " + Player2Reecon + " |");

                                    Mapa3.PrintMapToHit();
                                    input = Console.ReadKey();
                                    inputToKursor = input.KeyChar.ToString();

                                    if (inputToKursor == "0")
                                    {
                                        break;
                                    }
                                    else if (inputToKursor == " ")
                                    {
                                        Player2Reecon = Player2Reecon - 4;
                                    }

                                    Mapa3.MapKurzor(inputToKursor);
                                    Mapa3.Discover(Ships2.GetShip(4));
                                }

                            }
                            else if (inputToKursor == "0")
                            {
                                if (Player == 1)
                                {
                                    Player1Fire++;
                                    Player1Reecon++;
                                    Player = 2;
                                }
                                else if (Player == 2)
                                {
                                    Player2Fire++;
                                    Player2Reecon++;
                                    Player = 3;
                                }
                                else
                                {
                                    Player3Fire++;
                                    Player3Reecon++;
                                    Player = 1;
                                }
                                if (Mapa1.DestroyedShips() == true)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Vyhrál hráč 3!");
                                    Console.ReadKey();
                                    game = false;
                                    game2 = false;
                                    break;
                                }
                                else if (Mapa2.DestroyedShips() == true)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Vyhrál hráč 1!");
                                    Console.ReadKey();
                                    game = false;
                                    game2 = false;
                                    break;
                                }
                                else if (Mapa3.DestroyedShips() == true)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Vyhrál hráč 2!");
                                    Console.ReadKey();
                                    game = false;
                                    game2 = false;
                                    break;
                                }
                                break;

                            }
                        }
                        else if (Player == 3)
                        {
                            if (inputToKursor == "1")
                            {
                                while (true)
                                {
                                    if (Player3Fire < 1)
                                    {
                                        break;
                                    }

                                    Console.Clear();
                                    Console.WriteLine("|0 Zpět na výběr|");
                                    Console.WriteLine("|Cena: 1 Zásoba ostrých ran||Zbývá: " + Player3Fire + " |");

                                    Mapa1.PrintMapToHit();
                                    input = Console.ReadKey();
                                    inputToKursor = input.KeyChar.ToString();

                                    if (inputToKursor == "0")
                                    {
                                        break;
                                    }
                                    else if (inputToKursor == " ")
                                    {
                                        Player3Fire--;
                                    }

                                    Mapa1.MapKurzor(inputToKursor);
                                    Mapa1.Shoot(Ships3.GetShip(0));
                                }

                            }
                            else if (inputToKursor == "2")
                            {
                                while (true)
                                {
                                    if (Player3Fire < 2)
                                    {
                                        break;
                                    }

                                    Console.Clear();
                                    Console.WriteLine("|0 Zpět na výběr|");
                                    Console.WriteLine("|Cena: 2 Zásobay ostrých ran||Zbývá: " + Player3Fire + " |");

                                    Mapa1.PrintMapToHit();
                                    input = Console.ReadKey();
                                    inputToKursor = input.KeyChar.ToString();

                                    if (inputToKursor == "0")
                                    {
                                        break;
                                    }
                                    else if (inputToKursor == " ")
                                    {
                                        Player3Fire = Player3Fire - 2;
                                    }

                                    Mapa1.MapKurzor(inputToKursor);
                                    Mapa1.Shoot(Ships3.GetShip(5));
                                }

                            }
                            else if (inputToKursor == "4")
                            {
                                while (true)
                                {
                                    if (Player3Reecon < 1)
                                    {
                                        break;
                                    }

                                    Console.Clear();
                                    Console.WriteLine("|0 Zpět na výběr|");
                                    Console.WriteLine("|Cena: 1 Zásoba Odhalovacích ran||Zbývá: " + Player3Reecon + " |");

                                    Mapa1.PrintMapToHit();
                                    input = Console.ReadKey();
                                    inputToKursor = input.KeyChar.ToString();

                                    if (inputToKursor == "0")
                                    {
                                        break;
                                    }
                                    else if (inputToKursor == " ")
                                    {
                                        Player3Reecon--;
                                    }

                                    Mapa1.MapKurzor(inputToKursor);
                                    Mapa1.Discover(Ships3.GetShip(0));
                                }

                            }
                            else if (inputToKursor == "5")
                            {
                                while (true)
                                {
                                    if (Player3Reecon < 2)
                                    {
                                        break;
                                    }

                                    Console.Clear();
                                    Console.WriteLine("|0 Zpět na výběr|");
                                    Console.WriteLine("|Cena: 2 Zásoby Odhalovacích ran||Zbývá: " + Player3Reecon + " |");

                                    Mapa1.PrintMapToHit();
                                    input = Console.ReadKey();
                                    inputToKursor = input.KeyChar.ToString();

                                    if (inputToKursor == "0")
                                    {
                                        break;
                                    }
                                    else if (inputToKursor == " ")
                                    {
                                        Player3Reecon = Player3Reecon - 2;
                                    }

                                    Mapa1.MapKurzor(inputToKursor);
                                    Mapa1.Discover(Ships3.GetShip(5));
                                }

                            }
                            else if (inputToKursor == "6")
                            {
                                while (true)
                                {
                                    if (Player3Reecon < 4)
                                    {
                                        break;
                                    }

                                    Console.Clear();
                                    Console.WriteLine("|0 Zpět na výběr|");
                                    Console.WriteLine("|Cena: 4 Zásoba Odhalovacích ran||Zbývá: " + Player3Reecon + " |");

                                    Mapa1.PrintMapToHit();
                                    input = Console.ReadKey();
                                    inputToKursor = input.KeyChar.ToString();

                                    if (inputToKursor == "0")
                                    {
                                        break;
                                    }
                                    else if (inputToKursor == " ")
                                    {
                                        Player3Reecon = Player3Reecon - 4;
                                    }

                                    Mapa1.MapKurzor(inputToKursor);
                                    Mapa1.Discover(Ships3.GetShip(4));
                                }

                            }
                            else if (inputToKursor == "0")
                            {
                                if (Player == 1)
                                {
                                    Player1Fire++;
                                    Player1Reecon++;
                                    Player = 2;
                                }
                                else if (Player == 2)
                                {
                                    Player2Fire++;
                                    Player2Reecon++;
                                    Player = 3;
                                }
                                else
                                {
                                    Player3Fire++;
                                    Player3Reecon++;
                                    Player = 1;
                                }
                                if (Mapa1.DestroyedShips() == true)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Vyhrál hráč 3!");
                                    Console.ReadKey();
                                    game = false;
                                    game2 = false;
                                    break;
                                }
                                else if (Mapa2.DestroyedShips() == true)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Vyhrál hráč 1!");
                                    Console.ReadKey();
                                    game = false;
                                    game2 = false;
                                    break;
                                }
                                else if (Mapa3.DestroyedShips() == true)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Vyhrál hráč 2!");
                                    Console.ReadKey();
                                    game = false;
                                    game2 = false;
                                    break;
                                }
                                break;

                            }
                        }



                    }
                    


                }








            }

		}
    }
}
