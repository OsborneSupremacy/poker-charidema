namespace Poker.Domain.Delegates;

public delegate EvaluatedHandResponse BestHandEvaluator(
    BestHandRequest request
);
