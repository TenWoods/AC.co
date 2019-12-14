using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //玩家资金
    private float playerFund = 1000;
    public int round = 1;
    public OrderController orderController;

    public OrderMenuController orderMenuController;
    //玩家属性显示UI
    public Text weekCount;
    public Text fundUI;

    private bool calcStart = false;
    private bool initNextRound = false;

    public Dictionary<int,List<Order>> dic;

    private void Start()
    {
        Init();
    }

    private void Update()
    {
        if (calcStart)
        {
            //TODO 进行回合结算
            calcStart = false;
        }
        if (initNextRound)
        {
            //TODO 准备下个回合
            initNextRound = false;
        }
    }

    //游戏初始化
    private void Init()
    {
        orderController.InitOrders();
        //Order[] roll = orderController.RandomOrders(2);
        Order[] roll = orderController.PushActiveOrders();
        orderMenuController.InitOrders(roll);
//        Debug.Log(roll.Length);
        weekCount.text = round.ToString();
        fundUI.text = playerFund.ToString();
    }

    
    #region 跟GM交互的UI方法
    //下一回合按钮
    public void NextRound()
    {
        round++;
        Debug.Log(round);
        calcStart = true;
        // 这个时候改变接下来订单状态
        Debug.Log(PushOrder(round).Length);
        int[] ans = {0,2,4};
        Debug.Log("Degree: "+CheckAnswer(round,ans));
    }

    //回合结算确定按钮
    public void EnterNextRound()
    {
        initNextRound = true;
        weekCount.text = round.ToString();
        fundUI.text = playerFund.ToString();

    }

    #endregion


    public Order[] PushOrder(int round)
    {
        List<Order> od = new List<Order>();
        switch(round)
        {
            case 1: od.Add(orderController.orderPool[0]);
                break;
            case 2: od.Add(orderController.orderPool[1]);
                    od.Add(orderController.orderPool[2]);
                break;
            case 3: od.Add(orderController.orderPool[3]);
                    od.Add(orderController.orderPool[4]);
                    od.Add(orderController.orderPool[5]);
                break;
            case 4: od.Add(orderController.orderPool[6]);
                    od.Add(orderController.orderPool[7]);
                    od.Add(orderController.orderPool[8]);
                break;
            case 5: od.Add(orderController.orderPool[9]);
                break;
        }
        return od.ToArray();
    }


    public float CheckAnswer(int ID,int[] exam)
    {
        float count = 0;
        if(ID > 9)
            return 0.0f;
        int[] answer = orderController.orderPool[ID].Demands;
        for(int i = 0;i < answer.Length;i++)
        {
            if(i < exam.Length)
            {
                if(exam[i] == answer[i])
                count++;
            }
            else break;
        }
        float score = count/(float)answer.Length;
        orderController.orderPool[ID].CompleteDegree = score;
        this.playerFund += orderController.orderPool[ID].Reward * score;
        fundUI.text = this.playerFund.ToString();
        Debug.Log("当前持有" + this.playerFund);
        return score;
    }

}
