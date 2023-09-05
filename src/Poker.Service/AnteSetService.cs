namespace Poker.Service;

public class AnteSetService : IAnteSetService
{
    private readonly IRandomFactory _randomFactory;

    private readonly IUserInterfaceService _userInterfaceService;

    public AnteSetService(
        IRandomFactory randomFactory,
        IUserInterfaceService userInterfaceService
        )
    {
        _randomFactory = randomFactory ?? throw new ArgumentNullException(nameof(randomFactory));
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
    }

    public Task<uint> GetAsync(GameArgs gameArgs, IInGamePlayer button)
    {
        if (gameArgs.Match.FixAnte.HasValue)
            return Task.FromResult(gameArgs.Match.FixAnte.Value);

        uint anteAmount = 0;
        _userInterfaceService
            .PromptForMoney("Specify ante amount", 1, (int)gameArgs.Match.StartingStack, input =>
            {
                anteAmount = (uint)input;
            });
        return Task.FromResult(anteAmount);
    }
}
