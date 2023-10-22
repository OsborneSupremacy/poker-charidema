using Bogus;

namespace Poker.Service;

public class PlayerFactory
{
    private readonly IRandomFactory _randomFactory;

    public PlayerFactory(IRandomFactory randomFactory)
    {
        _randomFactory = randomFactory ?? throw new ArgumentNullException(nameof(randomFactory));
    }

    public Task<Player> CreateAsync(PlayerCreateRequest request)
    {
        Faker faker = new()
        {
            Random = new Randomizer(_randomFactory.GetSeed())
        };

        return Task.FromResult(new Player
        {
            Id = request.Id,
            BeginningStack = request.BeginningStack,
            Stack = request.BeginningStack,
            Name = faker.Person.FirstName,
            Automaton = request.Automaton,
            Busted = false,
            Cards = new(),
            Folded = false
        });
    }
}
