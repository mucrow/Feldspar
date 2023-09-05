using UnityEngine;

namespace Feldspar.Utils {
  [System.Serializable]
  public struct Trinomial {
    public static readonly Trinomial Identity = new Trinomial(1f, 1f, 0f);

    public float Exponent;
    public float Coefficient;
    public float Constant;

    public Trinomial(float exponent, float coefficient, float constant) {
      Exponent = exponent;
      Coefficient = coefficient;
      Constant = constant;
    }

    public float Apply(float value) {
      return Mathf.Pow(value, Exponent) * Coefficient + Constant;
    }

    public Trinomial NegateConstant() {
      return new Trinomial(Exponent, Coefficient, -1f * Constant);
    }
  }
}