using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
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

    public Dictionary<int,List<int>> dic;

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
        Order[] roll = orderController.PushActiveOrders();
        orderMenuController.InitOrders(roll);
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
        CalculateMoney();
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
        List<int> answer = new List<int>();
        for(int k = 0;k <orderController.orderPool[ID].Demands.Length;k++)
        {
            answer.Add(orderController.orderPool[ID].Demands[k]);
        }
        for(int i = 0;i < answer.Count;i++)
        {
            if(i < exam.Length)
            {
                /*Debug.Log("ID:"+ID);
                Debug.Log("i:"+i);
                Debug.Log("Exam:"+exam[i]);
                for(int j = 0;j<orderController.orderPool[ID].Demands.Length;j++)
                {
                    if(orderController.orderPool[ID].IsActive)
                        Debug.Log("Answer:"+orderController.orderPool[ID].Demands[j]);

                }*/
                
                if(exam[i] == answer[i])
                count++;
            }
            else break;
        }
        float score = count/(float)answer.Count;
        Debug.Log("命中率为："+score);
        orderController.orderPool[ID].CompleteDegree = score;
        this.playerFund += orderController.orderPool[ID].Reward * score;
        fundUI.text = this.playerFund.ToString();
        Debug.Log("当前持有" + this.playerFund);
        return score;
    }

    public void CalculateMoney()
    {
        if(dic != null)
        {
            foreach (var item in dic)
            {
                item.Value.Sort();
                for(int i = 0;i < item.Value.ToArray().Length;i++)
                {
                    Debug.Log(item.Value.ToArray()[i]);
                }
                CheckAnswer(item.Key,item.Value.ToArray());
            }
        }
        else
        {
            Debug.Log("> _ <");
        }
 

    }

}
