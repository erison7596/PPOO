using Observer.Models;
using Observer.Observers;

namespace Observer.Controllers;
public class KeyPad
{
    private PhoneModel model;
    private Screen screen; 

    public KeyPad(PhoneModel model, Screen screen)
    {
        this.model = model;
        this.screen = screen;
    }

    public void SimulateKeyPresses(int numKeyPresses)
    {
        Random rnd = new Random();
        const int MAX_DIGIT = 9;
        for (int i = 0; i < numKeyPresses; i++)
        {
            int newDigit = rnd.Next(MAX_DIGIT);
            Console.WriteLine($"Pressionando: {newDigit}");
            model.AddDigit(newDigit);
        }
        screen.PrintCurrentNumber(); 
    }
}