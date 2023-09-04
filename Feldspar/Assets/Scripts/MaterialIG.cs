using UnityEngine;

namespace Feldspar {
  [CreateAssetMenu(fileName = "Data", menuName = "Feldspar/MaterialIG")]
  public class MaterialIG: ScriptableObject {
    public string Name;
    public Brittleness Brittleness;
    public bool ConductsElectricity;
    public bool ConductsHeat;
    public bool Flammable;
    public float Hardness;
  }
}
