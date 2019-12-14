using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkPanel : MonoBehaviour
{
    public int index;
    public TalkPanel nextNode;
    public TalkController talkController;
    //public MeshRenderer meshRenderer;
    public void PushPanel()
    {
        this.gameObject.SetActive(true);
        Debug.Log(this.index);
    }

    public void HidePanel()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(this.gameObject.activeSelf)
            {
                if(nextNode != null)
                {
                    this.nextNode.PushPanel();
                    talkController.activeIndex = this.index+1;
                    Debug.Log("--------");
                    Debug.Log(this.index);
                }
                //this.meshRenderer.enabled = false;
                this.gameObject.SetActive(false);
                //Destroy(this.gameObject);
            }

        }
    }
}
