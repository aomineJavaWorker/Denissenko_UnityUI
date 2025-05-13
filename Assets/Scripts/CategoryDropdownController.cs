using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CategoryDropdownController : MonoBehaviour
{
    public Dropdown categoryDropdown;
    public GameObject panelTops, panelBottoms, panelAccessories;

    public void OnDropdownChanged()
    {
        string selected = categoryDropdown.options[categoryDropdown.value].text;

        panelTops.SetActive(selected == "Tops");
        panelBottoms.SetActive(selected == "Bottoms");
        panelAccessories.SetActive(selected == "Accessories");
    }
    // Start is called before the first frame update
    void Start()
    {
        categoryDropdown.onValueChanged.AddListener(delegate { OnDropdownChanged(); });
        OnDropdownChanged(); // Запуск по умолчанию

    }
}
