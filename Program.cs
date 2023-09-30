using System;

namespace GameShop
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                bool isValid = true;

                Console.WriteLine("Welcome to Lula's GameShop!");             

                Console.WriteLine("Pick a Console (with a discount):");
                Console.WriteLine("1. Computer = -10%");
                Console.WriteLine("2. Playstation = -15%");
                Console.WriteLine("3. XBOX = -20%");
                int console = Convert.ToInt32(Console.ReadLine());
                string consoleName = "";

                Console.WriteLine(); //Pula 1 linha.
                
                int game = 0;
                string gameName = "";
                double price = 0;

                switch (console)
                {
                    case 1:
                        Console.WriteLine("Pick a Game:");
                        consoleName = "Computer";
                        Console.WriteLine("1. Counter Strike - R$30,00");
                        Console.WriteLine("2. World of Warcraft - R$40,00");
                        Console.WriteLine("3. Call of Duty - R$100,00");
                        game = Convert.ToInt32(Console.ReadLine());
                        
                        switch (game)
                        {
                            case 1:
                                gameName = "Counter Strike";
                                price = 30;
                                break;

                            case 2:
                                gameName = "World of Warcraft";
                                price = 40;
                                break;

                            case 3:
                                gameName = "Call of Duty";
                                price = 100;
                                break;

                            default:
                                Console.WriteLine("Invalid Game. Try again.");
                                isValid = false;
                                break;
                        }
                        break;

                    case 2: // Playstation
                        Console.WriteLine("Pick a Game:");
                        consoleName = "Playstation";
                        Console.WriteLine("1. God of War - R$250,00");
                        Console.WriteLine("2. The Last of Us - R$200,00");
                        Console.WriteLine("3. Spider-Man - R$300,00");
                        game = Convert.ToInt32(Console.ReadLine());                        

                        switch (game)
                        {
                            case 1:
                                gameName = "God of War";
                                price = 250;
                                break;

                            case 2:
                                gameName = "The Last of Us";
                                price = 200;
                                break;

                            case 3:
                                gameName = "Spider-Man";
                                price = 300;
                                break;

                            default:
                                Console.WriteLine("Invalid Game. Try again.");
                                isValid = false;
                                break;
                        }
                        break;

                    case 3: // XBOX
                        Console.WriteLine("Pick a Game:");
                        consoleName = "XBOX";
                        Console.WriteLine("1. Forza Horizon - R$200,00");
                        Console.WriteLine("2. Halo - R$180,00");
                        Console.WriteLine("3. Gears of War - R$150,00");
                        game = Convert.ToInt32(Console.ReadLine());

                        switch (game)
                        {
                            case 1:
                                gameName = "Forza Horizon";
                                price = 200;
                                break;

                            case 2:
                                gameName = "Halo";
                                price = 180;
                                break;

                            case 3:
                                gameName = "Gears of War";
                                price = 150;
                                break;

                            default:
                                Console.WriteLine("Invalid Game. Try again.");
                                isValid = false;
                                break;
                        }                        
                        break;

                    default:
                        Console.WriteLine("Invalid Console. Try again.");
                        isValid = false;
                        break;
                }

                Console.WriteLine(); //Pula 1 linha

                if (isValid)
                {
                    //Acrescenta desconto do console.
                    double discount = (console == 1) ? 0.9 : (console == 2) ? 0.85 : (console == 3) ? 0.8 : 0;
                    double totalPrice = price * discount;

                    Console.WriteLine($"Your game costs R${Convert.ToString(totalPrice)}.");
                    Console.WriteLine("How would you like to pay?");
                    Console.WriteLine("1. Credit = -5%");
                    Console.WriteLine("2. Debit = -10%");
                    int metodPayment = Convert.ToInt32(Console.ReadLine());

                    //Acrescenta desconto do método de pagamento.
                    if (metodPayment == 1)
                    {
                        totalPrice = totalPrice * 0.95;
                    }
                    else if (metodPayment == 2)
                    {
                        totalPrice = totalPrice * 0.90;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Payment. Try again.");
                        isValid = false;
                    }

                    Console.WriteLine(); //Pula 1 linha

                    //Mensagem final.
                    if (isValid == true)
                    {
                        Console.WriteLine($"Congratulations! You just bought the Game {gameName} for the price of R${Convert.ToString(totalPrice)} to play on your {consoleName}!");
                    }
                }
            }
        }
    }
}