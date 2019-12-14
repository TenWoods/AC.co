using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class Order
{
    public OrderController oc;
    public int ID {get;set;}                        // 订单 ID
    public int Reward {get;set;}                    // 报酬
    public int RewardTime {get;set;}                // 回报时间
    public int OrderMoney {get;set;}                // 定金
    
    public int Exp {get;set;}                       // 经验值

    public int NextOrderID;
    public Service[] demands;                       // 要求（存疑，或许要建一个 Demand 新类）
    public enum demand                              // 根据要求枚举去生成相应的服务
    {
        human,
        cyberhuman,
        animal,
        item,
        vip,
    }
    

    public float CostModule {get;set;}            // 成本系数
    public string[] Report{get;set;}             // 订单完成报告

    // 默认数值
    public float CompleteDegree {get;set;}        // 订单完成度
    public bool IsSpLabel = false;                // 特殊订单标签
    public bool IsChecked {get;set;}              // 订单是否完成（完成/超时）？？？
    public bool IsActive {get;set;}

    public Order(OrderController _oc,
                int id,int reward,int rewardTime,int orderMoney,int exp,float costModule,
                bool isActive = true,
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

        CompleteDegree = 0;

        IsSpLabel = false;
        IsChecked = false;
        IsActive =  true;


    }



}
