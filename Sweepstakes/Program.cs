using System;

namespace Sweepstakes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            UserInterface userInterface = new UserInterface();
            string name = "user";
            Sweepstakes sweepstakes = new Sweepstakes(name);
            userInterface.MainMenu(sweepstakes);
        }
    }
}
