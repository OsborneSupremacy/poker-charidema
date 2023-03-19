using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Service;

public class GameService : IGameService
{
    private readonly I

    public async Task<Game> PlayAsync(GameArgs args)
    {
        Game game = new();

        return Task.FromResult(game);
    }
}
