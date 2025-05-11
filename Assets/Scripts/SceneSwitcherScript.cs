using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcherScript : MonoBehaviour
{
    public TMP_Dropdown dropdown;

    void Start()
    {

       dropdown.onValueChanged.AddListener(OnDropdownValueChanged);
    }


    public void OnDropdownValueChanged(int index)
    {
        string selectedOption = dropdown.options[index].text;

        if (selectedOption == "Bienin")
        {
            SceneManager.LoadScene("BieninScene");
        }else if (selectedOption == "Fierin")
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}
