using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class boutonTab : MonoBehaviour
{
    /*
    public GameObject bouton1;
    public GameObject bouton2;
    public GameObject bouton3;
*/
    public GameObject content1;
    public GameObject content2;
    public GameObject content3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showContent1()
    {
        content1.SetActive(true);
        content2.SetActive(false);
        content3.SetActive(false);

        //bouton1.GetComponent<Button>().image.color = new Color32(255, 255, 255, 255);
        //bouton2.GetComponent<Button>().image.color = new Color32(212, 212, 212, 255);
    }
    public void showContent2()
    {
        content1.SetActive(false);
        content2.SetActive(true);
        content3.SetActive(false);

        //bouton2.GetComponent<Button>().image.color = new Color32(255, 255, 255, 255);
        //bouton1.GetComponent<Button>().image.color = new Color32(212, 212, 212, 255);

    }

    public void showContent3()
    {
        content1.SetActive(false);
        content2.SetActive(false);
        content3.SetActive(true);

        //bouton2.GetComponent<Button>().image.color = new Color32(255, 255, 255, 255);
        //bouton1.GetComponent<Button>().image.color = new Color32(212, 212, 212, 255);

    }
}
