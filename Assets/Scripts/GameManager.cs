using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int round = 0;
    [SerializeField]
    private bool calcStart = false;
    // Start is called before the first frame update
    private void Start()
    {
        Init();
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    //游戏初始化
    private void Init()
    {
        
    }

    public void NextRound()
    {
        round++;
        Debug.Log(round);
        calcStart = true;
    }
}
