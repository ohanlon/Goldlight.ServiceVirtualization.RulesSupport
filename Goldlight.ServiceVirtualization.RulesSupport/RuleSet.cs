namespace Goldlight.ServiceVirtualization.RulesSupport;

public class RuleSet
{
  public readonly HashSet<DataRule> Rules =
  [
    new EqualsRule(),
    new DoesNotEqualRule(),
    new MatchesPatternRule(),
  ];
}