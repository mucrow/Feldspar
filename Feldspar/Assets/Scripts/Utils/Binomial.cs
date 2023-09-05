using UnityEngine;

namespace Feldspar.Utils {
  [System.Serializable]
  public struct Binomial {
    public static readonly Binomial Identity = new Binomial(1f, 0f);

    public float Coefficient;
    public float Constant;

    public Binomial(float coefficient, float constant) {
      Coefficient = coefficient;
      Constant = constant;
    }

    public static implicit operator Trinomial(Binomial binomial) {
      return new Trinomial(1f, binomial.Coefficient, binomial.Constant);
    }

    public float Apply(float value) {
      return value * Coefficient + Constant;
    }

    public Binomial NegateConstant() {
      return new Binomial(Coefficient, -1f * Constant);
    }
  }
}
