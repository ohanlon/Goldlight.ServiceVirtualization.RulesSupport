namespace Goldlight.ServiceVirtualization.RulesSupport;

public class EqualsRule : DataRule
{
  public EqualsRule() : base("Equals")
  {
    AllowedTypes.Add(ItemType.Integer);
    AllowedTypes.Add(ItemType.Boolean);
    AllowedTypes.Add(ItemType.Date);
    AllowedTypes.Add(ItemType.Float);
    AllowedTypes.Add(ItemType.String);
  }
}