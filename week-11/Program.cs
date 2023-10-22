using System;

public class Program
{
    public static void Main()
    {
        Movie m = new Movie();
        m.MainMenu();
    }
}

class Movie
{
    public string watchMovie;
    public string roundTimes;
    public void MainMenu()
    {
        Console.Clear();
        Movie m = new Movie();
        Console.WriteLine("Welcome To Chanwit Cineplex");
        Console.WriteLine("Please Selected Movie");
        Console.WriteLine("1.Sapalur");
        Console.WriteLine("2.The Marvel");
        Console.WriteLine("3.TeeYod");
        Console.WriteLine("Press Q = Exit Program");
        Console.WriteLine(" -------------------- ");
        Console.Write("Please Enter Your Input Selected : ");
        string userChoice = Console.ReadLine().ToUpper();
        Console.WriteLine(" -------------------- ");
        m.initialChoice(userChoice);
    }

    public void initialChoice(string Choice)
    {
        Movie m = new Movie();
        Console.Clear();
        if (Choice == "1" || Choice == "2" || Choice == "3"){
            m.getNameMovie(Int32.Parse(Choice));
            m.RoundTimes();
        }else{
            Console.Clear();
            Console.WriteLine(" ---------------------------------- ");
            Console.WriteLine("The menu you selected was not found.");
            Console.WriteLine(" ---------------------------------- ");
            Console.WriteLine("Press Q = Exit, H = Back To Menu");
            string NotfoundChoice = Console.ReadLine().ToUpper();
            if ( NotfoundChoice == "H"){
                m.MainMenu();
            }else if (NotfoundChoice == "Q"){
                m.initialChoice("Q");
            }
        }
    }

    public void RoundTimes()
    {
        Movie m = new Movie();
        Console.Clear();
        Console.WriteLine(" ---------------------------------- ");
        Console.WriteLine("Your Selected Movie : {0}", watchMovie);
        Console.WriteLine("Please Selected Movie Round Times");
        Console.WriteLine(" ---------------------------------- ");
        Console.WriteLine("1. 10:00 - 12:00");
        Console.WriteLine("2. 12:00 - 14:00");
        Console.WriteLine("3. 14:00 - 16:00");
        Console.WriteLine("Press Q = Exit, H = Back To Menu");
        Console.WriteLine(" ---------------------------------- ");
        Console.Write("Please Enter Your Input Selected : ");
        string userRoundTimes = Console.ReadLine().ToUpper();
        Console.WriteLine(" ---------------------------------- ");
        if (userRoundTimes == "1" || userRoundTimes == "2" || userRoundTimes == "3"){
            m.getRoundTimes(Int32.Parse(userRoundTimes), watchMovie);
            Console.Clear();
            m.Successfully();
        }else{
            m.initialChoice(null);
        }
    }

    public void getNameMovie(int MoviesId)
    {
        switch (MoviesId)
        {
            case 1:
                watchMovie = "Sapalur";
                break;
            case 2:
                watchMovie = "The Marvel";
                break;
            case 3:
               watchMovie = "TeeYod";
                break;
        }
    }

    public void getRoundTimes(int TimesId, string watchMovieName)
    {
        watchMovie = watchMovieName;
        switch (TimesId)
        {
            case 1:
                roundTimes = "10:00 - 12:00";
                break;
            case 2:
                roundTimes = "12:00 - 14:00";
                break;
            case 3:
                roundTimes = "14:00 - 16:00";
                break;
        }
    }

    public void Successfully()
    {
        Console.WriteLine(" ===== Successfully reserved =====");
        Console.WriteLine("Your Watch Movie : {0}", watchMovie);
        Console.WriteLine("Your Watch Round Times : {0}", roundTimes);
        Console.WriteLine("==================================");
    }


}