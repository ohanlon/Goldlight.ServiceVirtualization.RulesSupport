namespace Goldlight.ServiceVirtualization.RulesSupport;

public class DoesNotEqualRule : DataRule
{
  public DoesNotEqualRule() : base("NotEqualTo")
  {
    AllowedTypes.Add(ItemType.Integer);
    AllowedTypes.Add(ItemType.Boolean);
    AllowedTypes.Add(ItemType.Date);
    AllowedTypes.Add(ItemType.Float);
    AllowedTypes.Add(ItemType.String);
  }
}