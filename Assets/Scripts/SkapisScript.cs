using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkapisScript : MonoBehaviour
{
    public Dropdown categoryDropdown;
    public List<GameObject> wardrobeItems;

    // Новый список надетой одежды
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
            // Не отключаем надетые вещи!
            if (wornItems.Contains(item)) continue;

            item.SetActive(false);
        }
    }

    // Вызывать из DropZone, когда одежда «надета»
    public void MarkAsWorn(GameObject item)
    {
        if (!wornItems.Contains(item))
        {
            wornItems.Add(item);
        }
    }
}
