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
                setIcon(child);
            }
            // if child is the Name
            else if (child.name == "Name")
            {
                setName(child);
            }
        }
     }

    void setName(Transform child)
    {
        child.GetComponent<Text>().text = quantity + " " + itemName;
        //Debug.Log(child.GetComponent<Text>().text);

    }

    void setIcon(Transform child)
    {

        // set the image of button
        child.GetComponent<Image>().sprite = icon;
        //Debug.Log(icon.sprite);
    }

    public void applyLevelBarsEffect()
    {

        if (quantity > 0)
        {
            levelBarToHeal.Heal(healEffect);
            levelBarToDamage.TakeDamage(damageEffect);
            quantity--;
        }
    }
}



