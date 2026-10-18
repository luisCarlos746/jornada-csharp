using System;

namespace CinemaBooking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            char[,] seats = new char[5, 5];

            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    seats[r, c] = '.';
                }
            }

            int option;
            do
            {
                Console.Clear();
                Console.WriteLine("----  Cinema Booking System ----");
                Console.WriteLine("1. Show Seats");
                Console.WriteLine("2. Book a Seat");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");

                if (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine(" Invalid input! Press any key to retry...");
                    Console.ReadKey();
                    continue;
                }

                if (option == 1)
                {

                    ShowSeats(seats);
                    Console.WriteLine("\nPress any key to return to menu...");
                    Console.ReadKey();
                }
                else if (option == 2)
                {

                    Console.Clear();
                    Console.WriteLine("----  Book a Seat ----");
                    ShowSeats(seats); 

                    Console.Write("\nEnter Row number (1 to 5): ");
                    int row = int.Parse(Console.ReadLine()!) - 1; 

                    Console.Write("Enter Column number (1 to 5): ");
                    int col = int.Parse(Console.ReadLine()!) - 1; 

                    if(row < 0 || row > 4 || col < 0 || col > 4)
                    {
                        Console.WriteLine("Invalid seat selection! Please choose a seat within the valid range.");
                    }
                    else if (seats[row, col] == 'X')
                    {
                        Console.WriteLine("Sorry, this seat is already booked. Please choose another seat.");
                    }
                    else
                    {
                        seats[row, col] = 'X';
                        Console.WriteLine($"Seat at Row {row + 1}, Column {col + 1} has been successfully booked!");
                    }

                    Console.WriteLine("\nPress any key to return to menu...");
                    Console.ReadKey();
                }
                else if (option == 3)
                {
                    Console.WriteLine("\nThank you for using our system! Goodbye.");
                }
                else
                {
                    Console.WriteLine(" Invalid option! Press any key to retry...");
                    Console.ReadKey();
                }

            } while (option != 3);
        }


        static void ShowSeats(char[,] seats)
        {
            Console.WriteLine("\n      --- SCREEN ---");
            Console.WriteLine("    1   2   3   4   5"); 

            for (int r = 0; r < 5; r++)
            {
                Console.Write($"{r + 1} | "); 
                for (int c = 0; c < 5; c++)
                {
                    Console.Write(seats[r, c] + "   ");
                }
                Console.WriteLine();
            }
        }
    }
}
