using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderViewer : MonoBehaviour
{
    public Order m_order;
    public Button m_button;
    public GameObject m_menu;

    private void Start()
    {
        //TODO 订单页面根据订单进行初始化
    }

    private void Update()
    {
        
    }

    //显示订单页面
    public void On()
    {
        OrderViewer current = GameObject.Find("Canvas").GetComponent<OrderMenuController>().currentViewer;
        if (current != null)
        {
            current.Off();
        }
        m_menu.SetActive(true);
        GameObject.Find("Canvas").GetComponent<OrderMenuController>().currentViewer = this;
    }

    public void Off()
    {
        m_menu.SetActive(false);
    }
}
