using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using UnityEngine.UI;
public class OrderController : MonoBehaviour
{
    public GameManager gameManager;
    public Order[] orders;

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
    public Order[] InitOrders()
    {

        Order[] orders = new Order[1];
        // ID,Reward,RewardTime,OrderMoney,ConceptModule,CompleteDegree,CostModule,Name
        orders[0] = new Order(0,1,2,3,4,5);
        //orders[1] = new Order(1,1,2,3,4,5);
        //orders[2] = new Order(2,1,2,3,4,5);
        //orders[3] = new Order(3,1,2,3,4,5);
        //orders[4] = new Order(4,1,2,3,4,5);
        //orders[5] = new Order(1,1,2,3,4,5);
        //orders[6] = new Order(2,1,2,3,4,5);
        //orders[7] = new Order(3,1,2,3,4,5);
        //orders[8] = new Order(4,1,2,3,4,5);
        //orders[9] = new Order(1,1,2,3,4,5);
        //orders[10] = new Order(2,1,2,3,4,5);
        //orders[11] = new Order(3,1,2,3,4,5);
        //orders[12] = new Order(4,1,2,3,4,5);
        //orders[13] = new Order(1,1,2,3,4,5);
        //orders[14] = new Order(2,1,2,3,4,5);
        //orders[15] = new Order(3,1,2,3,4,5);
        //orders[16] = new Order(4,1,2,3,4,5);

        return orders;
    }

}
