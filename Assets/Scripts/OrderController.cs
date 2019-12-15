using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using UnityEngine.UI;
public class OrderController : MonoBehaviour
{
    public GameManager gameManager;
    public Dictionary<int,Order> orderPool = new Dictionary<int, Order>();
    public OrderMenuController orderMenuController;
    public int[] answer0 = {1};
    public int[] answer1 = {1,2,3};
    public int[] answer2 = {0,313,3};
    public int[] answer3 = {1,2,3};
    public int[] answer4 = {0,3,3};

    // 根据设置生成的订单
    public void InitOrders()
    {
        Debug.Log("OrderController Init");
        Order temp0 = new Order(this,0,50,2,3,4,5,answer0,true);
        Order temp1 = new Order(this,1,200,2,3,4,5,answer1,false);
        Order temp2 = new Order(this,2,200,2,3,4,5,answer2,false);
        Order temp3 = new Order(this,3,0,2,3,4,5,answer3,false);
        Order temp4 = new Order(this,4,5000,2,3,4,5,answer4,false);
        Order temp5 = new Order(this,5,1,2,3,4,5,answer0,true);
        Order temp6 = new Order(this,6,1,2,3,4,5,answer1,false);
        Order temp7 = new Order(this,7,1,2,3,4,5,answer2,false);
        Order temp8 = new Order(this,8,1,2,3,4,5,answer3,false);
        Order temp9 = new Order(this,9,1,2,3,4,5,answer4,false);


        orderPool.Add(temp0.ID,temp0);
        orderPool.Add(temp1.ID,temp1);
        orderPool.Add(temp2.ID,temp2);
        orderPool.Add(temp3.ID,temp3);
        orderPool.Add(temp4.ID,temp4);
        orderPool.Add(temp5.ID,temp5);
        orderPool.Add(temp6.ID,temp6);
        orderPool.Add(temp7.ID,temp7);
        orderPool.Add(temp8.ID,temp8);
        orderPool.Add(temp9.ID,temp9);
    }

    // 随机选取 count 个 Order，返回一个 Order 数组
    /*public Order[] RandomOrders(int count)
    {
        List<Order> orders = new List<Order>();

        int activeCount = CheckActiveOrder();
        if(count >= activeCount)
        {
            for(int i = 0;i<orderPool.Count;i++)
            {
                if(orderPool[i].IsActive)
                    orders.Add(DeepCopy(orderPool[i]));
            }
        }
        else
        {
            Hashtable ht = new Hashtable();
            for(int i = 0;i < count; i++)
            {
                int dice = Random.Range(0,orderPool.Count);
                if(orderPool[dice].IsActive && !ht.ContainsKey(orderPool[dice].ID))
                {
                    ht.Add(orderPool[dice].ID,orderPool[dice].ID);
                    orders.Add(DeepCopy(orderPool[dice]));
                }
            }
        }
        return orders.ToArray(); 
    }*/

    public Order[] PushActiveOrders()
    {
        List<Order> orders = new List<Order>();
        for(int i = 0;i<orderPool.Count;i++)
        {
            orders.Add(orderPool[i]);
        }
        return orders.ToArray();
        
    }
    /*public Order[] PushActiveOrders()
    {
        List<Order> orders = new List<Order>();

        for(int i = 0;i<orderPool.Count;i++)
        {
            if(orderPool[i].IsActive)
                orders.Add(orderPool[i]);
        }
        Debug.Log(orders.ToArray().Length);
        return orders.ToArray();
    }

    public void SetOrderActive(int id)
    {
        orderPool[id].IsActive = true;
    }

    public void SetOrderDisActive(int id)
    {
        orderPool[id].IsActive = false;
    }

    /* public int CheckActiveOrder()
    {
        int count = 0;
       for(int i = 0;i<orderPool.Count;i++)
        {
            if(orderPool[i].IsActive)
                count++;
        }
        return count;
    }

    public Order DeepCopy(Order target)
    {
        Order od = new Order(this,0,1,2,3,4,5);

        od.oc = target.oc;
        // TODO：给定外部参数进行订单生成
        od.ID = target.ID;
        od.Reward = target.Reward;
        od.RewardTime = target.RewardTime;
        od.OrderMoney = target.OrderMoney;
        od.Exp = target.Exp;
        od.CostModule = target.CostModule;

        od.CompleteDegree = target.CompleteDegree;

        od.IsSpLabel = target.IsSpLabel;
        od.IsChecked = target.IsChecked;
        od.IsActive =  target.IsActive;

        return od;
    }*/
}
