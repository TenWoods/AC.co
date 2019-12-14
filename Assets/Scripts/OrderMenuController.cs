﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderMenuController : MonoBehaviour
{
    public GameObject orderMenu;
    public GameObject onSwitch;
    private int orderNum = 10;
    public List<OrderViewer> allOrders;
    public OrderViewer currentViewer = null;

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
        float offset = 980.0f / orderNum;
        float currentY = 490.0f;
        for(int i = 0; i < allOrders.Count; i++)
        {
            allOrders[i].m_button.GetComponent<RectTransform>().anchoredPosition = new Vector3(-510.0f, currentY, 0.0f);
            currentY -= offset;
        }
        currentViewer = allOrders[0];
        currentViewer.On();
        orderMenu.SetActive(true);
        onSwitch.SetActive(false);
    }

    public void Off()
    {
        currentViewer.Off();
        currentViewer = null;
        orderMenu.SetActive(false);
        onSwitch.SetActive(true);
    }

    public void UpdateOrderNum(int num)
    {
        orderNum = num;
    }
}
