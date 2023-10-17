namespace Poker.Domain.Delegates;

public delegate IEnumerable<EvaluatedHandResponse> HandCollectionEvaluator(
    EvaluatedHandCollectionRequest request
);

