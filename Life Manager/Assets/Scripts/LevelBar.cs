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
    public string mediumMessage;
    public string lowMessage;
    public float timeDamage;
    Image fillComponent;
    Image iconComponent;
    Text textComponent;
    
    

    // start
    void Start()
    {
        SetChildren();
    }

    public void SetMaxLevel(float maxLevel)
    {
        slider.maxValue = maxLevel;
        slider.value = maxLevel;
    }

    public void SetLevel(float level)
    {
        slider.value = level;
        textComponent.text = text + " " + slider.value.ToString("F1") + " %";
        //Debug.Log("value: " + slider.value);
    }

    void SetChildren()
     {
        // log all children
        foreach (Transform child in transform)
        {
            // if child is the Fill
            if (child.name == "Fill")
            {
                fillComponent = child.GetComponent<Image>();
                fillComponent.color = color;
                //Debug.Log(fillComponent.color);
            }
            // if child is the Icon
            else if (child.name == "Icon")
            {
                iconComponent = child.GetComponent<Image>();
                iconComponent.sprite = sprite;
                //Debug.Log(iconComponent.sprite);
            }
            // if child is the Text
            else if (child.name == "Text")
            {
                textComponent = child.GetComponent<Text>();
                textComponent.text = text + " " + slider.value.ToString();
                //Debug.Log(textComponent.text);
            }
        }
     }

    public void TakeDamage(float damage)
    {
        //Debug.Log("damage: " + damage);
        SetLevel(slider.value - damage);
    }

    public void TakeDamage()
    {
        TakeDamage(timeDamage);
    }

    public void Heal(float heal)
    {
        SetLevel(slider.value + heal);
    }

    public bool IsMediumLevel() 
    {
        return ((slider.value > (slider.maxValue * 0.70f) - timeDamage) && (slider.value < (slider.maxValue * 0.70f) + timeDamage) );
    }

    public bool IsLowLevel()
    {
        return ((slider.value > (slider.maxValue * 0.30f) - timeDamage) && (slider.value < (slider.maxValue * 0.30f) + timeDamage) );
    }

  
}
