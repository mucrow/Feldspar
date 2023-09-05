using System.Collections.Generic;
using Feldspar.Utils;

namespace Feldspar.PassiveEffects {
  public class AttackSpeed: PassiveEffect {
    public Binomial Amount = new Binomial(1.125f, 1f);
    public List<ToolType> AffectedToolTypes = new List<ToolType>();
  }
}
