using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ServiceMenuController : MonoBehaviour
{
    public GameObject human;
    public GameObject humanGear;
    public GameObject animal;
    public GameObject item;
    public GameObject other;
    public Text humanText;
    public Text humanGearText;
    public Text animalText;
    public Text itemText;
    public Text otherText;
    private bool humanOn = false;
    private bool humanGearOn = false;
    private bool animalOn = false;
    private bool itemOn = false;
    private bool otherOn = false;



    public void HumanFold()
    {
        if (humanOn)
        {
            human.SetActive(false);
            humanText.text = "人类<-";
            humanOn = false;
        }
        else
        {
            human.SetActive(true);
            humanText.text = "人类>-";
            humanOn = true;
        }
    }

    public void HumanGearFold()
    {
        if (humanGearOn)
        {
            humanGear.SetActive(false);
            humanGearText.text = "仿生人修吉<-";
            humanGearOn = false;
        }
        else
        {
            humanGear.SetActive(true);
            humanGearText.text = "仿生人修吉>-";
            humanGearOn = true;
        }
    }

    public void AnimalFold()
    {
        if (animalOn)
        {
            animal.SetActive(false);
            animalText.text = "仿生人修吉<-";
            animalOn = false;
        }
        else
        {
            animal.SetActive(true);
            animalText.text = "仿生人修吉>-";
            animalOn = true;
        }
    }

    public void ItemFold()
    {
        if (itemOn)
        {
            item.SetActive(false);
            itemText.text = "物品<-";
            itemOn = false;
        }
        else
        {
            item.SetActive(true);
            itemText.text = "物品>-";
            itemOn = true;
        }
    }

    public void OtherFold()
    {
        if (otherOn)
        {
            other.SetActive(false);
            otherText.text = "豪华功能<-";
            otherOn = false;
        }
        else
        {
            other.SetActive(true);
            otherText.text = "豪华功能>-";
            otherOn = true;
        }
    }
}
