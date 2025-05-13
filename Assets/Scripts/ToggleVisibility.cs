using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class ToggleVisibility : MonoBehaviour
{
    public Toggle toggle;
    public string tagToToggle = "ClothingItem";

    // Список для хранения объектов
    private List<GameObject> objectsToToggle = new List<GameObject>();

    void Start()
    {
        // Находим все объекты с нужным тегом и сохраняем в список
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag(tagToToggle))
        {
            objectsToToggle.Add(obj);
        }

        // Привязываем событие к чекбоксу
        toggle.onValueChanged.AddListener(OnToggleChanged);

        // Обновляем начальное состояние
        OnToggleChanged(toggle.isOn);
    }

    void OnToggleChanged(bool isVisible)
    {
        foreach (GameObject obj in objectsToToggle)
        {
            obj.SetActive(isVisible);
        }
    }
}
