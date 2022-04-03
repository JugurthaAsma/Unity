using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelBar : MonoBehaviour
{
    public Slider slider;
    public Sprite sprite;
    public Color color;
    public string text;
    Image fillComponent;
    Image iconComponent;
    Text textComponent;
    

    // start
    void Start()
    {
        setChildren();
    }

    // update
    void Update()
    {
        //setLevel(slider.value - 0.1f);
    }


    public void setMaxLevel(float maxLevel)
    {
        slider.maxValue = maxLevel;
        slider.value = maxLevel;
    }

    public void setLevel(float level)
    {
        slider.value = level;
        textComponent.text = text + " " + slider.value.ToString();
        Debug.Log("value: " + slider.value);
    }

    void setChildren()
     {
        // log all children
        foreach (Transform child in transform)
        {
            // if child is the Fill
            if (child.name == "Fill")
            {
                fillComponent = child.GetComponent<Image>();
                fillComponent.color = color;
                Debug.Log(fillComponent.color);
            }
            // if child is the Icon
            else if (child.name == "Icon")
            {
                iconComponent = child.GetComponent<Image>();
                iconComponent.sprite = sprite;
                Debug.Log(iconComponent.sprite);
            }
            // if child is the Text
            else if (child.name == "Text")
            {
                textComponent = child.GetComponent<Text>();
                textComponent.text = text + " " + slider.value.ToString();
                Debug.Log(textComponent.text);
            }
           
        }



        /*
        // list of all children
        Transform[] children = GetComponentsInChildren<Transform>();
         
        // foreach loop through all children
        foreach (Transform child in children)
        {
            // if child is the Fill
            if (child.gameObject.name == "Fill")
            {
                child.gameObject.sprite = sprite;
                Debug.Log(child.gameObject.sprite);
                //slider = child.gameObject.GetComponent<Slider>();
            }
            // if child is a sprite
            else if (child.gameObject.name == "Sprite")
            {
                sprite = child.gameObject.GetComponent<Image>().sprite;
            }
            // if child is a text
            else if (child.gameObject.name == "Text")
            {
                text = child.gameObject.GetComponent<Text>().text;
            }
            // if child is a color
            else if (child.gameObject.name == "Color")
            {
                color = child.gameObject.GetComponent<Image>().color;
            }
        }
        /*
        for (int i = 0; i < transform.childCount; i++)
        {
            // get child
            Transform child = transform.GetChild(i);

            // set sprite
            if (child.name == "Sprite")
            {
                child.sprite = sprite;
                Debug.Log(child.sprite);
            }

            // set color
            if (child.name == "Color")
            {
                child.color = color;
                Debug.Log(child.color);
            }

            // set text
            if (child.name == "Text")
            {
                child.text = text;
            }
        }
/*
        // get child named "Image" and set it's sprite to sprite
        Image image = transform.Find("Image").GetComponent<Image>();
        image.sprite = sprite;
        Debug.Log(image.sprite);


        // get child named "Fill" and set it's color to color
        Image fill = transform.Find("Fill").GetComponent<Image>();
        fill.color = color;
        Debug.Log(fill.color);

        ;*/
     }

  
}
