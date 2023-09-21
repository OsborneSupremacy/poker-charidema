namespace Poker.Domain.Abstractions;

public delegate QualifiedHandResponse HandQualifier(
    QualifiedHandRequest request
);
