using Datadog.Trace.Annotations;

namespace TestAPI.Services;

public class RandomNumberService : IRandomNumberService
{
    private readonly Random _random;

    public RandomNumberService()
    {
        _random = new Random();
    }

    [Trace]
    public int GetRandomNumber()
    {
        return _random.Next(1, 1001); // Returns a random number between 1 and 1000
    }
}