namespace Feldspar {
  public enum Brittleness {
    DisintegratesWithAnyForce = 100,
    ShattersWithAnyForce = 200,
    BreaksWithLightForce = 300,
    BreaksWithModerateForce = 400,
    BreaksWithHighForce = 500,
    DentsWithHighForce = 600,
    NearlyUnbreakable = 700,
  }

  public static class BrittlenessExtensions {
    public static float ToFloat(this Brittleness brittleness) {
      return ((float) brittleness) / 100f;
    }
  }
}
