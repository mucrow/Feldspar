using UnityEngine;

namespace Feldspar {
  /**
   * A tool entry in the game database. A tool is a shield or a weapon. The player has two equip
   * slots for tools.
   */
  [RequireComponent(typeof(EquipKind))]
  public class ToolKind: MonoBehaviour {
    public ToolType ToolType;
    public ToolAction PrimaryAction;
    public ToolAction SecondaryAction;
  }
}
