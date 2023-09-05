using Feldspar.Utils;

namespace Feldspar.PassiveEffects {
  public class MoveSpeed: PassiveEffect {
    public Binomial Amount = new Binomial(1.125f, 1f);
  }
}
