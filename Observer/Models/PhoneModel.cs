using Observer.Observers;

namespace Observer.Models;
public class PhoneModel
{
    private List<int> digits = new List<int>();
    private List<IDigitObserver> observers = new List<IDigitObserver>();

    public void AddDigit(int newDigit)
    {
        digits.Add(newDigit);
        NotifyObservers(newDigit);
    }

    public List<int> GetDigits() => digits;

    public void Attach(IDigitObserver observer)
    {
        observers.Add(observer);
    }

    private void NotifyObservers(int digit)
    {
        foreach (var observer in observers)
        {
            observer.Update(digit);
        }
    }
}