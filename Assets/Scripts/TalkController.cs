using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkController : MonoBehaviour
{

    public TalkPanel[] Panels;
    public int activeIndex = -1;
    public Queue<int> queue = new Queue<int>();

    public bool hasNext = false;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        //PushPanel(0);
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        HidePanel();
    }

    public void PushPanel(int index)
    {
        Panels[index].PushPanel();
        activeIndex = index;
    }

    public void HidePanel()
    {
        //Debug.Log("Hide");
        Panels[activeIndex].HidePanel();
    }

    public void HidePanel(int index,TalkController tc)
    {
        if(Input.GetMouseButtonDown(0))
        {
            tc.queue.Enqueue(index+1);
            if(activeIndex != -1)
            {
                Panels[activeIndex].gameObject.SetActive(false);
                tc.queue.Dequeue();
                activeIndex = -1;
            }
        }

    }
}
