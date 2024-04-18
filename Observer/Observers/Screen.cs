using Observer.Models;

namespace Observer.Observers;
using System;

public class Screen : IDigitObserver
{
    private PhoneModel model;

    public Screen(PhoneModel model)
    {
        this.model = model;
        this.model.Attach(this);
    }

    public void Update(int digit)
    {
        Console.WriteLine(digit);
    }

    public void PrintCurrentNumber()
    {
        Console.Write("Agora discando ");
        foreach (int digit in model.GetDigits())
        {
            Console.Write(digit);
        }
        Console.WriteLine("...");
    }
}
