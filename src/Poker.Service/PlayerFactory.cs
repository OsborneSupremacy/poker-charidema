using Bogus;

namespace Poker.Service;

public class PlayerFactory
{
    private readonly IRandomFactory _randomFactory;

    public PlayerFactory(IRandomFactory randomFactory)
    {
        _randomFactory = randomFactory ?? throw new ArgumentNullException(nameof(randomFactory));
    }

    public Task<IPlayer> CreateAsync(PlayerCreateArgs args)
    {
        Faker faker = new()
        {
            Random = new Randomizer(_randomFactory.GetSeed())
        };

        return Task.FromResult(new Player
        {
            Id = Guid.NewGuid(),
            BeginningStack = args.BeginningStack,
            Stack = args.BeginningStack,
            Name = faker.Person.FirstName,
            Automaton = args.Automaton
        } as IPlayer);
    }
}
