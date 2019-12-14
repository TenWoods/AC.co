using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // TODO: 根据机制生成的派单函数
    public Order[] InitOrders(int num)
    {
        Order[] orders = new Order[num];
        for(int i = 0;i < num;i++)
        {
            // TODO
            orders[i] = new Order();
        }
        return orders;
    }
}
