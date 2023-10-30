namespace Poker.Domain.Delegates;

public delegate IOrderedEnumerable<EvaluatedHandResponse> HandCollectionEvaluator(
    EvaluateHandCollectionRequest request
);

