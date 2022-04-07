using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{

    public string itemName;
    public int quantity;
    public Sprite icon;
    public LevelBar levelBarToHeal;
    public int healEffect;
    public LevelBar levelBarToDamage;
    public int damageEffect;

    Transform buttonChild;
    Transform textChild;


    // Start is called before the first frame update
    void Start()
    {
        SetChildren();
    }

    void SetChildren()
     {

        foreach (Transform child in transform)
        {
            // the icon on the button
            if (child.name == "Button")
            {
                setButton(child);
            }
            // if child is the Name
            else if (child.name == "Name")
            {
                setText(child);
            }
        }
     }

    void setText(Transform child)
    {
        textChild = child;
        UpdateText();
        

    }

    void setButton(Transform child)
    {
        buttonChild = child;
        // set the image of button
        buttonChild.GetComponent<Image>().sprite = icon;
        //Debug.Log(icon.sprite);
    }

    public void ApplyLevelBarsEffect()
    {

        if (quantity > 0)
        {
            quantity--;
            UpdateText();
            levelBarToHeal.Heal(healEffect);
            levelBarToDamage.TakeDamage(damageEffect);
            
        }
    }

    private void UpdateText()
    {
        textChild.GetComponent<Text>().text = quantity + " " + itemName;
        //Debug.Log(textChild.GetComponent<Text>().text);
    }
}



