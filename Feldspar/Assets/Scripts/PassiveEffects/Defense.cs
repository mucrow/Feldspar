using Feldspar.Utils;

namespace Feldspar.PassiveEffects {
  public class Defense: PassiveEffect {
    public Binomial Amount = new Binomial(1f, 10f);
  }
}
