// Author: Spencer Stewart
// Date: 9/14/2019
// Project: StatePattern

/* Description:
 * 
 * This class is our pilot program for our state pattern project.
 * The purpose of this class is to test the functionality of our project
 * to make sure it works properly.
 * 
 */

using System;

namespace StatePattern
{
    class PilotProgram
    {
        static void Main(string[] args)
        {

            void displayMenu()
            {
                Console.WriteLine("\n\n" +
                    "1. Turn on car.\n" +
                    "2. Turn off car.\n" +
                    "3. Push brake pedal.\n" +
                    "4. Push gas pedal.\n" +
                    "5. Exit Program.\n");
                Console.Write("Please make a selection: ");
            }

            // Create a new Automobile to test our functionality with.
            Automobile HondaAccord = new Automobile("Accord", "Spencer");

            // Create variable to hold the input from the user.
            int userInput;

            // Welcome the user to the application.
            Console.WriteLine("You have just entered your new Honda Accord!\n" +
                "What would you like to do?");

            // Continue giving the user options while they want to.
            while (true)
            {
                
                // Display their options menu.
                displayMenu();

                userInput = Convert.ToInt32(Console.ReadLine());

                // Check to make sure the user inputed a value number.
                while (userInput > 5 || userInput < 1)
                {
                    Console.WriteLine("That number is not a value option," +
                        " please enter a valid selection.");
                    userInput = Convert.ToInt32(Console.ReadLine());
                }

                // Switch statement to let the user select what they want to do.
                switch (userInput)
                {
                    case 1:
                        HondaAccord.TurnKeyOn();
                        break;

                    case 2:
                        HondaAccord.TurnKeyOff();
                        break;

                    case 3:
                        HondaAccord.PushBrakePedal();
                        break;

                    case 4:
                        HondaAccord.PushGasPedal();
                        break;

                    case 5:
                        System.Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Hit unreachable code. Not closing program.");
                        System.Environment.Exit(0);
                        break;
                }
            }
        }
    }
}