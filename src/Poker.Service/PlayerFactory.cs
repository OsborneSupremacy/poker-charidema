using Poker.Service.Messaging;

namespace Poker.Service;

/// <inheritdoc />
internal class PlayerFactory : IPlayerFactory
{
    private readonly IRandomService _randomService;

    private readonly ILedgerService _ledgerService;

    public PlayerFactory(IRandomService randomService, ILedgerService ledgerService)
    {
        _randomService = randomService ?? throw new ArgumentNullException(nameof(randomService));
        _ledgerService = ledgerService ?? throw new ArgumentNullException(nameof(ledgerService));
    }

    public Task<Player> CreateAsync(PlayerCreateRequest request)
    {
        return Task.FromResult(new Player
        {
            Id = request.Id,
            BeginningStack = () => _ledgerService.GetPlayerGetBeginningStack(request.Id),
            Stack = () => _ledgerService.GetPlayerStack(request.Id),
            Name = _randomService.CreatePerson().FirstName,
            Automaton = request.Automaton,
            Busted = () => _ledgerService.IsPlayerBusted(request.Id)
        });
    }
}
