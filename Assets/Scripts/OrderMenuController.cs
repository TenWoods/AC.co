using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderMenuController : MonoBehaviour
{
    public GameObject orderMenu;
    public GameObject onSwitch;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Off();
        }
    }

    public void On()
    {
        //TODO 订单按钮分配位置
        orderMenu.SetActive(true);
        onSwitch.SetActive(false);
    }

    public void Off()
    {
        orderMenu.SetActive(false);
        onSwitch.SetActive(true);
    }
}
