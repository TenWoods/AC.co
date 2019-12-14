using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //玩家资金
    private int playerFund;
    //评价
    private int playerConcept;
    //玩家等级
    private int playerLevel;

    private int round = 0;
    [SerializeField]
   
    public OrderController orderController;
    public int orderNumMax;
    private int orderNumCurrent;

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
            //int orderNum = orderNumMax - orderNumCurrent;
            //orderController.InitOrders();
            //TODO 准备下个回合
            initNextRound = false;
        }
    }

    //游戏初始化
    private void Init()
    {
        
    }

    
    #region 跟GM交互的UI方法
    //下一回合按钮
    public void NextRound()
    {
        round++;
        //Debug.Log(round);
        calcStart = true;
    }
    //回合结算确定按钮
    public void EnterNextRound()
    {
        initNextRound = true;
    }

    #endregion
}
