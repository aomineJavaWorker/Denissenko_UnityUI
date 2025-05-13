using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkapisScript : MonoBehaviour
{
    public Dropdown categoryDropdown;
    public List<GameObject> wardrobeItems;

    // ����� ������ ������� ������
    public List<GameObject> wornItems = new List<GameObject>();

    void Start()
    {
        categoryDropdown.onValueChanged.AddListener(delegate {
            UpdateWardrobeDisplay(categoryDropdown.options[categoryDropdown.value].text);
        });

        HideAll();
    }

    public void UpdateWardrobeDisplay(string category)
    {
        HideAll();

        foreach (GameObject item in wardrobeItems)
        {
            if (item.CompareTag(category))
            {
                item.SetActive(true);
            }
        }
    }

    private void HideAll()
    {
        foreach (GameObject item in wardrobeItems)
        {
            // �� ��������� ������� ����!
            if (wornItems.Contains(item)) continue;

            item.SetActive(false);
        }
    }

    // �������� �� DropZone, ����� ������ �������
    public void MarkAsWorn(GameObject item)
    {
        if (!wornItems.Contains(item))
        {
            wornItems.Add(item);
        }
    }
}
