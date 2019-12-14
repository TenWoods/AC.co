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
    public Text humanText;
    public Text humanGearText;
    public Text animalText;
    public Text itemText;
    private bool humanOn = false;
    private bool humanGearOn = false;
    private bool animalOn = false;
    private bool itemOn = false;
    public GameObject serviceMenu;
    public Toggle toggle;


    #region 下层菜单开关
    public void HumanFold()
    {
        if (humanGearOn || animalOn || itemOn)
        {
            return;
        }
        if (humanOn)
        {
            human.SetActive(false);
            humanText.text = "人类";
            humanOn = false;
        }
        else
        {
            human.SetActive(true);
            humanText.text = "人类√";
            humanOn = true;
        }
    }

    public void HumanGearFold()
    {
        if (humanOn || animalOn || itemOn)
        {
            return;
        }
        if (humanGearOn)
        {
            humanGear.SetActive(false);
            humanGearText.text = "仿生人";
            humanGearOn = false;
        }
        else
        {
            humanGear.SetActive(true);
            humanGearText.text = "仿生人√";
            humanGearOn = true;
        }
    }

    public void AnimalFold()
    {
        if (humanGearOn || humanOn || itemOn)
        {
            return;
        }
        if (animalOn)
        {
            animal.SetActive(false);
            animalText.text = "动物";
            animalOn = false;
        }
        else
        {
            animal.SetActive(true);
            animalText.text = "动物√";
            animalOn = true;
        }
    }

    public void ItemFold()
    {
        if (humanGearOn || humanOn || animalOn)
        {
            return;
        }
        if (itemOn)
        {
            item.SetActive(false);
            itemText.text = "物品";
            itemOn = false;
        }
        else
        {
            item.SetActive(true);
            itemText.text = "物品√";
            itemOn = true;
        }
    }
    #endregion
    public void On()
    {
        serviceMenu.SetActive(true);
        Debug.Log("?");
        //TODO 服务初始化
    }

    public void Off()
    {
        serviceMenu.SetActive(false);
    }
}
