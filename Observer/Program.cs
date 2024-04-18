using Observer.Controllers;
using Observer.Models;
using Observer.Observers;

class Program
{
    static void Main(string[] args)
    {
        const int NUM_DIGITS = 12;

        PhoneModel model = new PhoneModel();
        Screen screen = new Screen(model);
        KeyPad keyPad = new KeyPad(model, screen);

        keyPad.SimulateKeyPresses(NUM_DIGITS);
    }
}
