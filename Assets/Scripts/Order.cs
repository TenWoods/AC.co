using System.Collections;
using System.Collections.Generic;

public class Order
{
    public int reward;                  // 报酬
    public int rewardTime;              // 回报时间
    public int orderMoney;              // 定金
    public bool hasOrderMoney;          // 是否拥有定金
    public float conceptModule;         // 评价影响系数
    public string[] demands;            // 要求（存疑，或许要建一个 Demand 新类）
    public float completeDegree;        // 订单完成度
    public float costModule;            // 成本系数
    public bool isSpLabel;              // 特殊订单标签
    public string[] report;             // 订单完成报告
    public bool isChecked;              // 订单是否完成（完成/超时）？？？
    public Order()
    {
        // TODO：给定外部参数进行订单生成
    }

}
