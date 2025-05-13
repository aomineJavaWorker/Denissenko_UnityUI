using System.Collections.Generic;
using UnityEngine;

public class ClothingManager : MonoBehaviour
{
    public Transform characterRoot; // корневой объект персонажа
    public Dictionary<string, GameObject> equippedItems = new Dictionary<string, GameObject>();

    public void EquipClothing(string category, GameObject clothingPrefab)
    {
        // Удаляем старую одежду этой категории
        if (equippedItems.ContainsKey(category))
        {
            Destroy(equippedItems[category]);
        }

        // Надеваем новую одежду (клонируем и прикрепляем к персонажу)
        GameObject clone = Instantiate(clothingPrefab, characterRoot);
        clone.transform.localPosition = Vector3.zero;
        equippedItems[category] = clone;
    }
}
