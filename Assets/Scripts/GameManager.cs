using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //玩家资金
    private int playerFund = 1000;
    public int round = 1;
    public OrderController orderController;
    // public int orderNumMax;
    // private int orderNumCurrent;
    public OrderMenuController orderMenuController;
    //玩家属性显示UI
    public Text weekCount;
    public Text fundUI;

    private bool calcStart = false;
    private bool initNextRound = false;

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
        Order[] roll = orderController.RandomOrders(2);
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
    }

    //回合结算确定按钮
    public void EnterNextRound()
    {
        initNextRound = true;
        weekCount.text = round.ToString();
        fundUI.text = playerFund.ToString();
    }

    #endregion
}
