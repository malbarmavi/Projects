using System.Collections.Generic;

namespace TryMVC.Models
{
  public static class EquipmentStorage
  {
    private static List<Equipment> equipments { get; set; } = new List<Equipment>();

    public static void AddEquipment(string equipmentName)
    {
      equipments.Add(new Equipment() { Name = equipmentName });
    }

    public static List<Equipment> GetAll()
    {
      return equipments;
    }
  }
}