using UnityEngine;

namespace Feldspar {
  /**
   * An entry in the game database for an item (which can be roughly defined as something that can
   * be stored in the player's inventory).
   */
  public class ItemKind: MonoBehaviour {
    /** The item's name. */
    public string Name;

    /** Flavor text for the item. */
    public string Description;

    /** Weight is in grams. */
    public float Weight = 1;

    /** How many of this item can stack in a single inventory slot? */
    public int MaxStack = 1;
  }
}
