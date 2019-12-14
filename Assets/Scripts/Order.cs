using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class Order
{
    public int ID {get;set;}                        // 订单 ID
    public int Reward {get;set;}                    // 报酬
    public int RewardTime {get;set;}                // 回报时间
    public int OrderMoney {get;set;}                // 定金
    public float ConceptModule {get;set;}          // 评价影响系数
    
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

    public Image Avatar{get;set;}                // 头像
    public string Name {get;set;}                 // 用户名

    // 默认数值
    public float CompleteDegree {get;set;}        // 订单完成度
    public int Level{get;set;}                  // 订单等级
    public bool IsSpLabel = false;              // 特殊订单标签
    public bool HasOrderMoney {get;set;}           // 是否拥有定金
    public bool IsChecked {get;set;}              // 订单是否完成（完成/超时）？？？

    public Order(int id,int reward,int rewardTime,int orderMoney,float conceptModule,float costModule,
                float completeDegree = -100,
                bool hasOrderMoney = false,
                bool isSpLabel = false,
                bool isChecked = false)
    {
        // TODO：给定外部参数进行订单生成
        ID = id;
        Reward = reward;
        RewardTime = rewardTime;
        OrderMoney = orderMoney;
        ConceptModule = conceptModule;
        CostModule = costModule;
    }



}
