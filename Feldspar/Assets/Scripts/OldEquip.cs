using System;
using System.Collections.Generic;
using UnityEngine;

namespace Feldspar {
  public class OldEquip: MonoBehaviour {
  }

  public class _MaterialIG: ScriptableObject {
    public string Name;
    // public Brittleness Brittleness;
    public bool ConductsElectricity;
    public bool ConductsHeat;
    public bool Flammable;
    public float Hardness;
  }

  /**
   * [weapon1, weapon2] are example weapons, but they are not necessarily the only ones that can
   * do the action they annotate
   */
  public enum _ToolActionType {
    /** [hammer] bring the weapon down onto the enemies head */
    OverheadSwing = 1000,

    /** [sword] horizontal slash starting away from the body and moving inward */
    InwardSwing = 1100,

    /** [sword] horizontal slash starting near the body and moving outward */
    OutwardSwing = 1200,

    /** [spear, dagger] thrust the weapon forward */
    ThrustAttack = 1300,

    /** swing the weapon in a circle */
    SpinAttack = 1400,

    /** [bow, gun, wand, magical object] fire a projectile from the weapon */
    FireProjectile = 1500,

    /** [bomb, throwing axe, boomerang] throw the weapon */
    Throw = 1600,

    /** [gun] reload or recharge weapon, or prepare next attack */
    Ready = 1700,

    /** [wand, magical object, musical instrument] create a status effect area around the player */
    StatusArea = 1800,

    /** [shield] block attacks */
    Block = 1900,

    /** [shield] parry attacks */
    Parry = 2000,
  }
}
