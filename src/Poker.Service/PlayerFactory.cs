namespace Poker.Service;

public class PlayerFactory
{
    private readonly IRandomService _randomService;

    public PlayerFactory(IRandomService randomService)
    {
        _randomService = randomService ?? throw new ArgumentNullException(nameof(randomService));
    }

    public Task<Player> CreateAsync(PlayerCreateRequest request) =>
        Task.FromResult(new Player
        {
            Id = request.Id,
            BeginningStack = request.BeginningStack,
            Stack = request.BeginningStack,
            Name = _randomService.CreatePerson().FirstName,
            Automaton = request.Automaton,
            Busted = false,
            Cards = [],
            Stake = 0,
            Folded = false
        });
}
