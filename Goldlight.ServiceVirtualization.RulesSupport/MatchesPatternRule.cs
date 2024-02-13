namespace Goldlight.ServiceVirtualization.RulesSupport;

public class MatchesPatternRule : DataRule
{
  public MatchesPatternRule() : base("MatchesPattern")
  {
    AllowedTypes.Add(ItemType.String);
  }
}