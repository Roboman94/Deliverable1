using System;

class MainClass
{
    public static void Main(string[] args)
    {
        string vacationType;
        bool vacavalid = false;

        Console.WriteLine("What kind of trip would you like to go on, musical, tropical, or adventurous? ");
        vacationType = (Console.ReadLine());
     
        while (vacavalid == false)
        {

            if (vacationType.Contains("musical"))
            {
                vacationType = "New Orleans";
                vacavalid = true;
            }
            else if (vacationType.Contains("tropical"))
            {
                vacationType = "A Beach Vacation in Mexico";
                vacavalid = true;
            }
            else if (vacationType.Contains("adventurous"))
            {
                vacationType = "Whitewater Rafting the Grand Canyon";
                vacavalid = true;
            }
            else
            {
                Console.WriteLine(
                    "Incorrect entry. Please try again.");
                Console.WriteLine("What kind of trip would you like to go on, musical, tropical, or adventurous? ");
                vacationType = (Console.ReadLine());
            }
        }

     ///////
          
            string result = "empty";
            int groupSize;

        Console.WriteLine("How many are in your group? ");


            while (!Int32.TryParse(Console.ReadLine(), out groupSize))
            {
                Console.WriteLine("Invalid input. Please try again.");
                Console.WriteLine("How many are in your group? ");
            }

            if (groupSize <= 2)
            {
                result = " first class flight to " + vacationType;
             
            }

            else if (groupSize <= 5)
            {
                result = " helicopter to " + vacationType;
             
            }

            else if (groupSize >= 6)
            {
                result = " charter to " + vacationType;
              
            }


     ///////

            Console.WriteLine("Since you're a group of " + groupSize + " you should take a" + result);

        
    }
}