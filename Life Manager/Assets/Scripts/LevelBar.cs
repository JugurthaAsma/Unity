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
    public float damage;
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
        takeDamage(damage);
    }


    public void setMaxLevel(float maxLevel)
    {
        slider.maxValue = maxLevel;
        slider.value = maxLevel;
    }

    public void setLevel(float level)
    {
        slider.value = level;
        textComponent.text = text + " " + slider.value.ToString("F1") + " %";
        //Debug.Log("value: " + slider.value);
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



     }

    public void takeDamage(float damage)
    {
        
        //Debug.Log("damage: " + damage);
        setLevel(slider.value - damage);
    }

  
}
