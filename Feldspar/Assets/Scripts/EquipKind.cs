using UnityEngine;

namespace Feldspar {
  /** An entry in the game database for a piece of equipment. */
  [RequireComponent(typeof(ItemKind))]
  public class EquipKind: MonoBehaviour {
    public EquipSlot Slot;
    public float MaxDurability;
  }
}
