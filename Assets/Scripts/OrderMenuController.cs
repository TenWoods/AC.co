using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderMenuController : MonoBehaviour
{
    public GameObject orderMenu;
    public GameObject onSwitch;
    private int orderNum = 10;
    public List<OrderViewer> allOrders;
    public List<GameObject> orderPrefabs;
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
        float offset = 948.0f / orderNum;
        float currentY = 458.0f;
        for(int i = 0; i < allOrders.Count; i++)
        {
            allOrders[i].m_button.GetComponent<RectTransform>().anchoredPosition = new Vector3(-516.0f, currentY, 0.0f);
            currentY -= offset;
        }
        currentViewer = allOrders[0];
        currentViewer.On();
        orderMenu.SetActive(true);
        onSwitch.SetActive(false);
    }

    public void Off()
    {
        if (currentViewer != null)
        {
            currentViewer.Off();
        }
        currentViewer = null;
        orderMenu.SetActive(false);
        onSwitch.SetActive(true);
    }

    public void InitOrders(Order[] orders)
    {
        allOrders.Clear();
        foreach(var i in orders)
        {
            GameObject temp = GameObject.Instantiate(orderPrefabs[i.ID]);
            temp.GetComponent<RectTransform>().SetParent(orderMenu.transform);
            temp.GetComponent<OrderViewer>().m_order = i;
            allOrders.Add(temp.GetComponent<OrderViewer>());
        }
        foreach(var i in allOrders)
        {
            i.Print();
        }
    }
}
