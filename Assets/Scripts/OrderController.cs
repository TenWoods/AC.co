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

    // 可能留存一个上回合生成过的订单 ID
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 根据设置生成的订单
    public void InitOrders()
    {
        //InitSimpleOrder(this,0,1,2,3,4,5);
        //InitSimpleOrder(this,1,1,2,3,4,5);
        //InitSimpleOrder(this,2,1,2,3,4,5);
        
        Order temp0 = new Order(this,0,1,2,3,4,5);
        Order temp1 = new Order(this,1,1,2,3,4,5);
        // Order temp2 = new Order(this,2,1,2,3,4,5);
        // Order temp3 = new Order(this,3,1,2,3,4,5);
        // Order temp4 = new Order(this,4,1,2,3,4,5);
        // Order temp5 = new Order(this,5,1,2,3,4,5);

        orderPool.Add(temp0.ID,temp0);
        orderPool.Add(temp1.ID,temp1);
        // orderPool.Add(temp2.ID,temp2);
        // orderPool.Add(temp3.ID,temp3);
        // orderPool.Add(temp4.ID,temp4);
        // orderPool.Add(temp5.ID,temp5);
        //orderMenuController.allOrders.Add(new OrderViewer());
    }


    public void InitSimpleOrder(OrderController _oc,
                int id,int reward,int rewardTime,int orderMoney,int exp,float costModule,
                bool hasOrderMoney = false,
                bool isSpLabel = false,
                bool isChecked = false)
                {
                    Order temp0 = new Order(_oc,id,reward,rewardTime,orderMoney,exp,costModule);
                    orderPool.Add(temp0.ID,temp0);
                }

    // 随机选取 count 个 Order，返回一个 Order 数组
    public Order[] RandomOrders(int count)
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
    }

    public void SetOrderActive(int id)
    {
        orderPool[id].IsActive = true;
    }

    public void SetOrderDisActive(int id)
    {
        orderPool[id].IsActive = false;
    }
    public int CheckActiveOrder()
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
    }
}
