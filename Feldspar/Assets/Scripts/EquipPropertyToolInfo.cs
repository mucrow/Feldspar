using UnityEngine;

namespace Feldspar {
  public class EquipPropertyToolInfo: EquipProperty {
    public override EquipPropertyKey Key => EquipPropertyKey.ToolInfo;
    [SerializeField] ToolInfo _toolInfo;

    protected override object GetValue() {
      return _toolInfo;
    }
  }

  [System.Serializable]
  public struct ToolInfo {
    public ToolType ToolType;
    public ToolActionType PrimaryAction;
    public ToolActionType SecondaryAction;
  }
}
