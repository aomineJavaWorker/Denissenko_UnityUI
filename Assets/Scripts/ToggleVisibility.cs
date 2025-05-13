using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class ToggleVisibility : MonoBehaviour
{
    public Toggle toggle;
    public string tagToToggle = "ClothingItem";

    // ������ ��� �������� ��������
    private List<GameObject> objectsToToggle = new List<GameObject>();

    void Start()
    {
        // ������� ��� ������� � ������ ����� � ��������� � ������
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag(tagToToggle))
        {
            objectsToToggle.Add(obj);
        }

        // ����������� ������� � ��������
        toggle.onValueChanged.AddListener(OnToggleChanged);

        // ��������� ��������� ���������
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
