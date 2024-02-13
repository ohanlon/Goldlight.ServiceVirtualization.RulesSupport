namespace Goldlight.ServiceVirtualization.RulesSupport;

public class ItemTypeDetails
{
  private readonly Dictionary<ItemType, string> itemTypes = new();

  public ItemTypeDetails()
  {
    itemTypes.Add(ItemType.Integer, "Integer");
    itemTypes.Add(ItemType.Boolean, "Boolean");
    itemTypes.Add(ItemType.Float, "Float");
    itemTypes.Add(ItemType.Date, "Date");
    itemTypes.Add(ItemType.String, "String");
    itemTypes.Add(ItemType.Object, "Object");
  }

  public string Name(ItemType itemType) => itemTypes[itemType];
}