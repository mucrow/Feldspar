namespace Feldspar {
  public class EquipPropertyPassiveDefense: EquipProperty {
    public override EquipPropertyKey Key => EquipPropertyKey.PassiveDefense;
    public float Value;

    protected override object GetValue() {
      return Value;
    }
  }
}
