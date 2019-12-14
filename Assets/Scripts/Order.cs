using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Order
{
    public OrderController oc;
    public int ID {get;set;}                        // 订单 ID
    public int Reward {get;set;}                    // 报酬
    public int RewardTime {get;set;}                // 回报时间
    public int OrderMoney {get;set;}                // 定金
    public int OrderLife{get;set;}
    public int Exp {get;set;}                       // 经验值

    public int NextOrderID;
    public int[] Demands;                           // 要求,用来存正确答案

    public float CostModule {get;set;}              // 成本系数
    public string[] Report{get;set;}                // 订单完成报告

    // 默认数值
    public float CompleteDegree {get;set;}          // 订单完成度
    public bool IsSpLabel = false;                  // 特殊订单标签
    public bool IsChecked {get;set;}                // 订单是否完成（完成/超时）
    public bool IsActive {get;set;}

    public Order(OrderController _oc,
                int id,int reward,int rewardTime,int orderMoney,int exp,float costModule,
                int[] demands,
                bool isActive = false,
                int nextOrderId = -1,
                bool isSpLabel = false,
                bool isChecked = false)
    {
        oc = _oc;
        // TODO：给定外部参数进行订单生成
        ID = id;
        Reward = reward;
        RewardTime = rewardTime;
        OrderMoney = orderMoney;
        Exp = exp;
        CostModule = costModule;
        Demands = demands;
        //DeepCopy(demands);
        CompleteDegree = 0;
        NextOrderID = nextOrderId;
        IsSpLabel = false;
        IsChecked = false;
        IsActive =  isActive;


    }

    private void DeepCopy(int[] demand)
    {
        for(int i = 0;i < demand.Length;i++)
        {
            Demands[i] = demand[i];
        }
    }

    public void DebugItself()
    {
        Debug.Log(ID+" "+ Reward + " "+ RewardTime+Demands[0]+Demands[1]+Demands[2]);
    }

    //public void SetNextOrderActive()
    //{
    //    oc.SetOrderActive(NextOrderID);
    //}

}
