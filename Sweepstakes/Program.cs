using System;

namespace Sweepstakes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            UserInterface userInterface = new UserInterface();
            Sweepstakes sweepstakes = new Sweepstakes();

            userInterface.MainMenu(sweepstakes);
        }
    }
}
