using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectScript : MonoBehaviour
{
    public GameObject Top1;
    public GameObject Top2;
    public GameObject Top3;
    public GameObject Belt1;
    public GameObject Belt2;
    public GameObject Belt3;
    public GameObject Sword1;
    public GameObject Sword2;
    public GameObject Sword3;
    public GameObject other1;
    public GameObject other2;
    public GameObject other3;
    public Slider widthSlider;
    public Slider heightSlider;


    public string clothingCategory; 
    public GameObject clothingPrefab; 
    public ClothingManager clothingManager;


    [HideInInspector]
    public Vector2 Top1Pos;
    [HideInInspector]
    public Vector2 Top2Pos;
    [HideInInspector]
    public Vector2 Top3Pos;
    [HideInInspector]
    public Vector2 Belt1Pos;
    [HideInInspector]
    public Vector2 Belt2Pos;
    [HideInInspector]
    public Vector2 Belt3Pos;

    public AudioSource audioSource;
    public AudioClip[] audioClips;

    public GameObject lastDragged = null;
    [HideInInspector]
    public bool rightPlace = false;

    public Slider rotationSlider;

    void Start()
    {
        Top1Pos = Top1.GetComponent<RectTransform>().localPosition;
        Top2Pos = Top2.GetComponent<RectTransform>().localPosition;
        Top3Pos = Top3.GetComponent<RectTransform>().localPosition;
        Belt1Pos = Belt1.GetComponent<RectTransform>().localPosition;
        Belt2Pos = Belt2.GetComponent<RectTransform>().localPosition;
        Belt3Pos = Belt3.GetComponent<RectTransform>().localPosition;
    }

    public void ChangeSize(float newSize)
    {
        if (lastDragged != null)
        {
            lastDragged.transform.localScale = new Vector3(newSize, newSize, 1);
        }
    }
    public void ChangeRotation()
    {
        if (lastDragged != null && rotationSlider != null)
        {
            float angle = rotationSlider.value * 360f;
            lastDragged.transform.localRotation = Quaternion.Euler(0, 0, angle);
        }
    }

    public void FlipLastDragged()
    {
        if (lastDragged != null)
        {
            Vector3 scale = lastDragged.transform.localScale;
            scale.x *= -1;
            lastDragged.transform.localScale = scale;
        }


    }

    public void ToLeft()
    {
        if (lastDragged != null)
        {
            Vector3 scale = lastDragged.transform.localScale;
            scale.x = Mathf.Abs(scale.x); 
            lastDragged.transform.localScale = scale;
        }
    }

    public void ToRight()
    {
        if (lastDragged != null)
        {
            Vector3 scale = lastDragged.transform.localScale;
            scale.x = -Mathf.Abs(scale.x); 
            lastDragged.transform.localScale = scale;
        }
    }

    public void ChangeWidth(float newWidth)
    {
        if (lastDragged != null)
        {
            Vector3 currentScale = lastDragged.transform.localScale;
            float sign = Mathf.Sign(currentScale.x); // сохраняем направление
            lastDragged.transform.localScale = new Vector3(newWidth * sign, currentScale.y, currentScale.z);
        }
    }


    public void ChangeHeight(float newHeight)
    {
        if (lastDragged != null)
        {
            Vector3 currentScale = lastDragged.transform.localScale;
            lastDragged.transform.localScale = new Vector3(currentScale.x, newHeight, currentScale.z);

        }
    }

    public void SetInitialSliderValueByTag()
    {
        if (lastDragged != null && widthSlider != null && heightSlider != null)
        {
            Vector3 scale = lastDragged.transform.localScale;

            switch (lastDragged.tag)
            {
                case "Drēbes":
                case "Cap":
                case "character":
                    widthSlider.value = Mathf.Abs(scale.x);
                    heightSlider.value = scale.y;
                    break;
            }
        }
    }





}
