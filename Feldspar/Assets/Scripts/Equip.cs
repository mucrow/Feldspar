using System;
using System.Collections.Generic;
using UnityEngine;

namespace Feldspar {
  public class Equip: MonoBehaviour {
    public string Name;
    public EquipSlot EquipSlot;
    public string Description;
    public float Weight;
    public float MaxDurability;

    Dictionary<EquipPropertyKey, EquipProperty> _propertiesAsDict;

    public float Defense => GetProperty<float>(EquipPropertyKey.PassiveDefense);
    public ToolType ToolType => GetProperty<ToolType>(EquipPropertyKey.ToolInfo);

    void InitPropertiesDict() {
      _propertiesAsDict = new Dictionary<EquipPropertyKey, EquipProperty>();
      var properties = GetComponents<EquipProperty>();
      foreach (var property in properties) {
        _propertiesAsDict[property.Key] = property;
      }
    }

    public Dictionary<EquipPropertyKey, EquipProperty> GetProperties() {
      if (_propertiesAsDict != null) {
        return _propertiesAsDict;
      }
      InitPropertiesDict();
      return _propertiesAsDict;
    }

    public T GetProperty<T>(EquipPropertyKey key) {
      return GetProperties()[key].GetValue<T>();
    }
  }
}
