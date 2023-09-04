using System;
using UnityEngine;

namespace Feldspar {
  public abstract class EquipProperty: MonoBehaviour {
    public abstract EquipPropertyKey Key { get; }
    protected abstract object GetValue();

    public T GetValue<T>() {
      return (T) GetValue();
    }
  }

  public enum EquipPropertyKey {
    PassiveDefense = 0,
    ToolInfo = 1,
  }
}
