﻿namespace Poker.Service.Interface;

public interface IDealerService
{
    Task<Deck> ShuffleAsync(Deck deck);
    
    Task<Deck> ReshuffleAsync(ReshuffleRequest request);
}
