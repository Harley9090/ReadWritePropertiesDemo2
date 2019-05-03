using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using In = NBCC_WMAD_Console.Input;
using Out = NBCC_WMAD_Console.Output;

namespace NBCC_WMAD_Console
{
    class Program
    {
        /// <summary>
        /// Menu Items are added here
        /// </summary>
        private static void LoadMenu()
        {
            Menu.menuDictionary.Add(0, "Exit");
            Menu.menuDictionary.Add(1, "About the Console");
            Menu.menuDictionary.Add(2, "Car builder");
        }

        static void Main(string[] args)
        {
            string choice = Init();

            while (choice.ToLower() == "y")
            {
                switch (In.Get<int>(Menu.CreateMenu(), ConsoleColor.Yellow))
                {
                    case 0:
                        choice = "n";
                        break;
                    case 1:
                        AboutThisApp();
                        break;
                    case 2:
                        CarBuilder();
                        break;
                    //Add more options in the menu here
                }
            }

            Out.P("Press any key to exit.");
            Console.ReadLine();
        }
        //store the cars created in the list
        static List<car> myCars = new List<car>();

        private static void CarBuilder()
        {
            string userCarType = In.GetString("Provide a car type (i.e car, truck, van) \n");
            int userNumberOfDoors = In.GetInt("Provide number of doors:");
            int userCarSpeed = In.GetInt("Provide car speed:");
            string question = In.GetString("Do you want to print list of all cars? y/n");

            car car = new car();
            car.CarType = userCarType;
            car.NumberOfDoors = userNumberOfDoors;
            car.Speed = userCarSpeed;
            

            Out.P("*************************");
            Out.P($"The car created is: \n" +
                $"Type: {car.CarType} \n" +
                $"Doors: {car.NumberOfDoors} \n" +
                $"Speed: {car.Speed} \n" +
                $"Price: {car.Price.GetValueOrDefault()}  \n");
            Out.P("*************************");

            //print 
            myCars.Add(car);

            Out.P($"I have a car count in my list of: {myCars.Count}");

            //Out.P("Do you want to list all cars y/n");

            if(question.ToLower() == "y")
            {
                foreach (car  item in myCars)
                {
                    Out.P($"Car type: {item.CarType} Numb of doors: {item.NumberOfDoors} Speed: {item.Speed} Price: {item.Price.GetValueOrDefault().ToString("c")} \n");
                }
            }
            
            //prompt the user "Do you want to list all cars" yes or no
            //if user enter yes => loop the list of cars => print each car with all
            //properties
            //if user enter no => don't print
        }

        #region [My Functionality]

        /*
         * My methods will be added here for executing functionality within the console
         */

        #endregion

        /// <summary>
        /// The About this App
        /// </summary>
        private static void AboutThisApp()
        {
            Out.P("\n");
            Out.P("This app is the Console Root Application. Build on it by providing new menu items and adding to the switch statement");
            Out.P("\n");
        }
        
        /// <summary>
        /// Initialize the Console
        /// </summary>
        /// <returns></returns>
        private static string Init()
        {
            LoadMenu();
            string choice = "y";
            Logo.CreateLogo("The Root App");
            return choice;
        }
    }
}
