using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SkapisScript : MonoBehaviour
{
    public List<GameObject> wardrobeItems;
    void Start()
    {

        foreach (GameObject item in wardrobeItems)
        {
            item.SetActive(false);
        }
    }
    public void Skapis(int index)
    {
        HideAll();

        if (index == 0)
        {
            foreach (GameObject item in wardrobeItems)
            {
                item.SetActive(true);
            }
        }
    }

    private void HideAll()
    {
        foreach (GameObject item in wardrobeItems)
        {
            item.SetActive(false);
        }
    }
}
