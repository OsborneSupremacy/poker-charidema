namespace Poker.Domain.Delegates;

public delegate EvaluatedHandResponse HandEvaluator(
    EvaluateHandRequest request
);
