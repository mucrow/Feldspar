using Feldspar;
using Feldspar.Utils;
using UnityEngine;

namespace Feldspar.ToolActions {
  public class Block: ToolAction {
    public bool CanParry = true;
    public Binomial DamageAbsorption = new Binomial(1f, 10f);
  }
}
