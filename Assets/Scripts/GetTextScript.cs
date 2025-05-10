using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
public class GetTextScript : MonoBehaviour
{
    string vards;
    string gads;
    int vecums;
    public string[] textArray = { "Sveiks mani sauc ", " un man ir " };
    public GameObject inputFieldVards;
    public GameObject inputFieldVecums;
    public GameObject textField;
    // Start is called before the first frame update
    public void ShowText()
    {
        vards = inputFieldVards.GetComponent<Text>().text;
        gads = inputFieldVecums.GetComponent<Text>().text;
        vecums = System.DateTime.Now.Year - int.Parse(gads);

        textField.GetComponent<Text>().text =
            textArray[0] + vards.ToUpper() + textArray[1] + vecums + " gadi!";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
