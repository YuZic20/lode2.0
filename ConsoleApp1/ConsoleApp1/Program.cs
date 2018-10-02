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


            ;


            List<Lode> ShipsList = new List<Lode>();
            List<Mapa> MapList = new List<Mapa>();
            Lode Ships1 = new Lode();

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
            int Kill = 1;

            Mapa Map1 = new Mapa();
            Mapa Map2 = new Mapa();
            Mapa Map3 = new Mapa();

            MapList.Add(Map1);
            MapList.Add(Map2);
            MapList.Add(Map3);

            ShipsList.Add(Ships1);
            ShipsList.Add(Ships2);
            ShipsList.Add(Ships3);

            MapList[0].GenerateMap();
            MapList[1].GenerateMap();
            MapList[2].GenerateMap();




            while (game)
            {
                Console.WriteLine("Hráči 1 připrav se pokládat své lodě.");
                Console.WriteLine("Ujisti se aby tě tvůj protivník neviděl jej pokládat");
                Console.ReadKey();
                Console.Clear();

                while (true)
                {
                    if (MapList[0].NumOFShips == 0)
                    {
                        Console.Clear();
                        Console.WriteLine(MapList[0].TextToPlayer);
                        MapList[0].PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        MapList[0].MapKurzor(inputToKursor);
                        MapList[0].PlaceShip(ShipsList[0].GetShip(6));

                    }
                    else if (MapList[0].NumOFShips == 1)
                    {
                        Console.Clear();
                        Console.WriteLine(MapList[0].TextToPlayer);
                        MapList[0].PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        MapList[0].MapKurzor(inputToKursor);
                        MapList[0].PlaceShip(ShipsList[0].GetShip(3));

                    }
                    else if (MapList[0].NumOFShips == 2)
                    {
                        Console.Clear();
                        Console.WriteLine(MapList[0].TextToPlayer);
                        MapList[0].PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        MapList[0].MapKurzor(inputToKursor);
                        MapList[0].PlaceShip(ShipsList[0].GetShip(2));
                    }
                    else if (MapList[0].NumOFShips == 3)
                    {
                        Console.Clear();
                        Console.WriteLine(MapList[0].TextToPlayer);
                        MapList[0].PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        MapList[0].MapKurzor(inputToKursor);
                        MapList[0].PlaceShip(ShipsList[0].GetShip(5));
                    }
                    else if (MapList[0].NumOFShips == 4)
                    {
                        Console.Clear();
                        Console.WriteLine(MapList[0].TextToPlayer);
                        MapList[0].PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        MapList[0].MapKurzor(inputToKursor);
                        MapList[0].PlaceShip(ShipsList[0].GetShip(1));
                    }
                    else if (MapList[0].NumOFShips == 5)
                    {
                        Console.Clear();
                        Console.WriteLine(MapList[0].TextToPlayer);
                        MapList[0].PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        MapList[0].MapKurzor(inputToKursor);
                        MapList[0].PlaceShip(ShipsList[0].GetShip(0));
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
                    if (MapList[1].NumOFShips == 0)
                    {
                        Console.Clear();
                        Console.WriteLine(MapList[1].TextToPlayer);
                        MapList[1].PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        MapList[1].MapKurzor(inputToKursor);
                        MapList[1].PlaceShip(ShipsList[1].GetShip(6));

                    }
                    else if (MapList[1].NumOFShips == 1)
                    {
                        Console.Clear();
                        Console.WriteLine(MapList[1].TextToPlayer);
                        MapList[1].PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        MapList[1].MapKurzor(inputToKursor);
                        MapList[1].PlaceShip(ShipsList[1].GetShip(3));

                    }
                    else if (MapList[1].NumOFShips == 2)
                    {
                        Console.Clear();
                        Console.WriteLine(MapList[1].TextToPlayer);
                        MapList[1].PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        MapList[1].MapKurzor(inputToKursor);
                        MapList[1].PlaceShip(ShipsList[1].GetShip(2));
                    }
                    else if (MapList[1].NumOFShips == 3)
                    {
                        Console.Clear();
                        Console.WriteLine(MapList[1].TextToPlayer);
                        MapList[1].PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        MapList[1].MapKurzor(inputToKursor);
                        MapList[1].PlaceShip(ShipsList[1].GetShip(5));
                    }
                    else if (MapList[1].NumOFShips == 4)
                    {
                        Console.Clear();
                        Console.WriteLine(MapList[1].TextToPlayer);
                        MapList[1].PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        MapList[1].MapKurzor(inputToKursor);
                        MapList[1].PlaceShip(ShipsList[1].GetShip(1));
                    }
                    else if (MapList[1].NumOFShips == 5)
                    {
                        Console.Clear();
                        Console.WriteLine(MapList[1].TextToPlayer);
                        MapList[1].PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        MapList[1].MapKurzor(inputToKursor);
                        MapList[1].PlaceShip(ShipsList[1].GetShip(0));
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
                    if (MapList[2].NumOFShips == 0)
                    {
                        Console.Clear();
                        Console.WriteLine(MapList[2].TextToPlayer);
                        MapList[2].PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        MapList[2].MapKurzor(inputToKursor);
                        MapList[2].PlaceShip(ShipsList[2].GetShip(6));

                    }
                    else if (MapList[2].NumOFShips == 1)
                    {
                        Console.Clear();
                        Console.WriteLine(MapList[2].TextToPlayer);
                        MapList[2].PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        MapList[2].MapKurzor(inputToKursor);
                        MapList[2].PlaceShip(ShipsList[2].GetShip(3));

                    }
                    else if (MapList[2].NumOFShips == 2)
                    {
                        Console.Clear();
                        Console.WriteLine(MapList[2].TextToPlayer);
                        MapList[2].PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        MapList[2].MapKurzor(inputToKursor);
                        MapList[2].PlaceShip(ShipsList[2].GetShip(2));
                    }
                    else if (MapList[2].NumOFShips == 3)
                    {
                        Console.Clear();
                        Console.WriteLine(MapList[2].TextToPlayer);
                        MapList[2].PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        MapList[2].MapKurzor(inputToKursor);
                        MapList[2].PlaceShip(ShipsList[2].GetShip(5));
                    }
                    else if (MapList[2].NumOFShips == 4)
                    {
                        Console.Clear();
                        Console.WriteLine(MapList[2].TextToPlayer);
                        MapList[2].PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        MapList[2].MapKurzor(inputToKursor);
                        MapList[2].PlaceShip(ShipsList[2].GetShip(1));
                    }
                    else if (MapList[2].NumOFShips == 5)
                    {
                        Console.Clear();
                        Console.WriteLine(MapList[2].TextToPlayer);
                        MapList[2].PrintMap();
                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();
                        MapList[2].MapKurzor(inputToKursor);
                        MapList[2].PlaceShip(ShipsList[2].GetShip(0));
                    }
                    else
                    {
                        break;
                    }
                }

                MapList[0].RemoveInvalid();
                MapList[1].RemoveInvalid();
                MapList[2].RemoveInvalid();
                while (game2)
                {

                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("je na tahu hráč " + (Player));
                        Console.WriteLine("Střílí se na hráče " + (Kill + 1));
                        Console.WriteLine("Zásoby ostrých ran Hráče 1: " + Player1Fire + "  | Zásoby ostrých ran Hráče 2: " + Player2Fire + "  | Zásoby ostrých ran Hráče 3: " + Player3Fire);
                        Console.WriteLine("Zásoby Odhalovacích ran Hráče 1: " + Player1Reecon + " | Zásoby Odhalovacích ran Hráče 2: " + Player2Reecon + " | Zásoby Odhalovacích ran Hráče 3: " + Player3Reecon);
                        Console.WriteLine("1 = 1 ranná ostrá rána | 2 = 3 ranná nepřesná ostrá střelba | 0 = konec tahu");
                        Console.WriteLine("1 = 4 ranná označovací rána | 5 = 3 ranná nepřesná označovací střelba | 6 = řada označovacích ran");
                        Console.WriteLine("7 = Střelba na hrace 1 | 8 = Střelba na hrace  2 | 9 = Střelba na hrace 3");
                        Console.WriteLine("Mapa hráče 1");
                        MapList[0].PrintMapToHit();
                        Console.WriteLine();
                        Console.WriteLine("Mapa hráče 2");
                        MapList[1].PrintMapToHit();
                        Console.WriteLine();
                        Console.WriteLine("Mapa hráče 3");
                        MapList[2].PrintMapToHit();

                        input = Console.ReadKey();
                        inputToKursor = input.KeyChar.ToString();

                        if (Player == 1)
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

                                    MapList[Kill].PrintMapToHit();
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

                                    MapList[Kill].MapKurzor(inputToKursor);
                                    MapList[Kill].Shoot(ShipsList[1].GetShip(0));
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

                                    MapList[Kill].PrintMapToHit();
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

                                    MapList[Kill].MapKurzor(inputToKursor);
                                    MapList[Kill].Shoot(ShipsList[1].GetShip(5));
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

                                    MapList[Kill].PrintMapToHit();
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

                                    MapList[Kill].MapKurzor(inputToKursor);
                                    MapList[Kill].Discover(ShipsList[1].GetShip(0));
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

                                    MapList[Kill].PrintMapToHit();
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

                                    MapList[Kill].MapKurzor(inputToKursor);
                                    MapList[Kill].Discover(ShipsList[1].GetShip(5));
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

                                    MapList[Kill].PrintMapToHit();
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

                                    MapList[Kill].MapKurzor(inputToKursor);
                                    MapList[Kill].Discover(ShipsList[1].GetShip(4));
                                }

                            }
                            else if (inputToKursor == "7")
                            {
                                Kill = 0;

                            }
                            else if (inputToKursor == "8")
                            {
                                Kill = 1;

                            }
                            else if (inputToKursor == "9")
                            {
                                Kill = 2;

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
                                if (MapList[Kill].DestroyedShips() == true)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Vyhrál hráč 3!");
                                    Console.ReadKey();
                                    game = false;
                                    game2 = false;
                                    break;
                                }
                                else if (MapList[Kill].DestroyedShips() == true)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Vyhrál hráč 1!");
                                    Console.ReadKey();
                                    game = false;
                                    game2 = false;
                                    break;
                                }
                                else if (MapList[Kill].DestroyedShips() == true)
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

                                    MapList[Kill].PrintMapToHit();
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

                                    MapList[Kill].MapKurzor(inputToKursor);
                                    MapList[Kill].Shoot(ShipsList[1].GetShip(0));
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

                                    MapList[Kill].PrintMapToHit();
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

                                    MapList[Kill].MapKurzor(inputToKursor);
                                    MapList[Kill].Shoot(ShipsList[1].GetShip(5));
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

                                    MapList[Kill].PrintMapToHit();
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

                                    MapList[Kill].MapKurzor(inputToKursor);
                                    MapList[Kill].Discover(ShipsList[1].GetShip(0));
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

                                    MapList[Kill].PrintMapToHit();
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

                                    MapList[Kill].MapKurzor(inputToKursor);
                                    MapList[Kill].Discover(ShipsList[1].GetShip(5));
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

                                    MapList[Kill].PrintMapToHit();
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

                                    MapList[Kill].MapKurzor(inputToKursor);
                                    MapList[Kill].Discover(ShipsList[1].GetShip(4));
                                }

                            }
                            else if (inputToKursor == "7")
                            {
                                Kill = 0;

                            }
                            else if (inputToKursor == "8")
                            {
                                Kill = 1;

                            }
                            else if (inputToKursor == "9")
                            {
                                Kill = 2;

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
                                if (MapList[Kill].DestroyedShips() == true)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Vyhrál hráč 3!");
                                    Console.ReadKey();
                                    game = false;
                                    game2 = false;
                                    break;
                                }
                                else if (MapList[Kill].DestroyedShips() == true)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Vyhrál hráč 1!");
                                    Console.ReadKey();
                                    game = false;
                                    game2 = false;
                                    break;
                                }
                                else if (MapList[Kill].DestroyedShips() == true)
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

                                    MapList[Kill].PrintMapToHit();
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

                                    MapList[Kill].MapKurzor(inputToKursor);
                                    MapList[Kill].Shoot(ShipsList[2].GetShip(0));
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

                                    MapList[Kill].PrintMapToHit();
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

                                    MapList[Kill].MapKurzor(inputToKursor);
                                    MapList[Kill].Shoot(ShipsList[2].GetShip(5));
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

                                    MapList[Kill].PrintMapToHit();
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

                                    MapList[Kill].MapKurzor(inputToKursor);
                                    MapList[Kill].Discover(ShipsList[2].GetShip(0));
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

                                    MapList[Kill].PrintMapToHit();
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

                                    MapList[Kill].MapKurzor(inputToKursor);
                                    MapList[Kill].Discover(ShipsList[2].GetShip(5));
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

                                    MapList[Kill].PrintMapToHit();
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

                                    MapList[Kill].MapKurzor(inputToKursor);
                                    MapList[Kill].Discover(ShipsList[2].GetShip(4));
                                }

                            }
                            else if (inputToKursor == "7")
                            {
                                Kill = 0;

                            }
                            else if (inputToKursor == "8")
                            {
                                Kill = 1;

                            }
                            else if (inputToKursor == "9")
                            {
                                Kill = 2;

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
                                if (MapList[Kill].DestroyedShips() == true)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Vyhrál hráč 3!");
                                    Console.ReadKey();
                                    game = false;
                                    game2 = false;
                                    break;
                                }
                                else if (MapList[Kill].DestroyedShips() == true)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Vyhrál hráč 1!");
                                    Console.ReadKey();
                                    game = false;
                                    game2 = false;
                                    break;
                                }
                                else if (MapList[Kill].DestroyedShips() == true)
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
