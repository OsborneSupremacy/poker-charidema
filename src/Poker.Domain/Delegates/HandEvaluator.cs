namespace Poker.Domain.Delegates;

public delegate EvaluatedHandResponse HandEvaluator(
    EvaluatedHandRequest request
);
