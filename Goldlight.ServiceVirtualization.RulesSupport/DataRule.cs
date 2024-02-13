namespace Goldlight.ServiceVirtualization.RulesSupport;

public abstract class DataRule(string name)
{
  protected readonly HashSet<ItemType> AllowedTypes = new();

  public string Name { get; private set; } = name;
  public bool AppliesTo(ItemType type) => AllowedTypes.Contains(type);
}