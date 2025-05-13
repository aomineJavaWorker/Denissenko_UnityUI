using System.Collections.Generic;
using UnityEngine;

public class ClothingManager : MonoBehaviour
{
    public Transform characterRoot; // �������� ������ ���������
    public Dictionary<string, GameObject> equippedItems = new Dictionary<string, GameObject>();

    public void EquipClothing(string category, GameObject clothingPrefab)
    {
        // ������� ������ ������ ���� ���������
        if (equippedItems.ContainsKey(category))
        {
            Destroy(equippedItems[category]);
        }

        // �������� ����� ������ (��������� � ����������� � ���������)
        GameObject clone = Instantiate(clothingPrefab, characterRoot);
        clone.transform.localPosition = Vector3.zero;
        equippedItems[category] = clone;
    }
}
