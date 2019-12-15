using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ServiceMenuController : MonoBehaviour
{
    public GameObject human;
    public GameObject humanGear;
    public GameObject animal;
    public GameObject item;
    public GameObject humanButton;
    public GameObject humanGearButton;
    public GameObject animalButton;
    public GameObject itemButton;
    public Text humanText;
    public Text humanGearText;
    public Text animalText;
    public Text itemText;

    private bool humanOn = false;
    private bool humanGearOn = false;
    private bool animalOn = false;
    private bool itemOn = false;
    public GameObject serviceMenu;
    private Dictionary<int , List<int>> choiceSaves = new Dictionary<int , List<int>>();
    private List<int> currentSave = new List<int>();
    private OrderViewer currentViewer;
    public List<GameObject> texts = new List<GameObject>();

    #region UI组件相关
    public GameManager gameManager;
    public TalkController talkController;
    public GameObject humanUpdate_1;
    public GameObject humanUpdate_2;
    public Toggle humanToggle_1;
    public Toggle humanToggle_2;
    public GameObject humanGearUpdate_1;
    public GameObject humanGearUpdate_2;
    public Toggle humanGearToggle_1;
    public Toggle humanGearToggle_2;
    public GameObject animalUpdate;
    public Toggle animalToggle;
    public GameObject itemUpdate;
    public Toggle itemToggle;
    #endregion

    public Text costUI;
    private int costSave = 0;

    public GameObject backGround;

    public GameObject playerUI;
    public GameObject orderUI;
    public GameObject orderMenu;

    #region  开销记录

    private void AddChoice(int i)
    {

        List<int> temp = new List<int>(currentSave);
        if (!choiceSaves.ContainsKey(i))
        {
            choiceSaves.Add(i, temp);
        }
        choiceSaves[i] = temp;
    }

    public void HumanBase(int n)
    {
        if (humanGearOn || animalOn || itemOn)
        {
            return;
        }
        if (humanOn)
        {
            costSave += n;
            currentSave.Add(1);
        }
        else
        {
            costSave -= n;
            currentSave.Remove(1);
        }
        costUI.text = costSave.ToString();
    }

    public void HumanUpdate1(int n)
    {
        if (humanGearOn || animalOn || itemOn)
        {
            return;
        }
        if (humanToggle_1.isOn)
        {
            costSave += n;
            currentSave.Add(2);
        }
        else
        {
            costSave -= n;
            currentSave.Remove(2);
        }
        costUI.text = costSave.ToString();
    }

    public void HumanUpdate2(int n)
    {
        if (humanGearOn || animalOn || itemOn)
        {
            return;
        }
        if (humanToggle_2.isOn)
        {
            costSave += n;
            currentSave.Add(3);
        }
        else
        {
            costSave -= n;
            currentSave.Remove(3);
        }
        costUI.text = costSave.ToString();
    }

    public void HumanGearBase(int n)
    {
        if (humanOn|| animalOn || itemOn)
        {
            return;
        }
        if (humanGearOn)
        {
            costSave += n;
           currentSave.Add(4);
        }
        else
        {
            costSave -= n;
            currentSave.Remove(4);
        }
        costUI.text = costSave.ToString();
    }

    public void HumanGearUpdate1(int n)
    {
        if (humanOn|| animalOn || itemOn)
        {
            return;
        }
        if (humanGearToggle_1.isOn)
        {
            costSave += n;
            currentSave.Add(5);
        }
        else
        {
            costSave -= n;
            currentSave.Remove(5);
        }
        costUI.text = costSave.ToString();
    }

    public void HumanGearUpdate2(int n)
    {
        if (humanOn|| animalOn || itemOn)
        {
            return;
        }
        if (humanGearToggle_2.isOn)
        {
            costSave += n;
            currentSave.Add(6);
        }
        else
        {
            costSave -= n;
            currentSave.Remove(6);
        }
        costUI.text = costSave.ToString();
    }

    public void AnimalBase(int n)
    {
        if (humanOn|| humanGearOn || itemOn)
        {
            return;
        }
        if (animalOn)
        {
            costSave += n;
            currentSave.Add(7);
        }
        else
        {
            costSave -= n;
            currentSave.Remove(7);
        }
        costUI.text = costSave.ToString();
    }

    public void AnimalUpdateSave(int n)
    {
        if (humanOn|| humanGearOn || itemOn)
        {
            return;
        }
        if (animalToggle.isOn)
        {
            costSave += n;
            currentSave.Add(8);
        }
        else
        {
            costSave -= n;
            currentSave.Remove(8);
        }
        costUI.text = costSave.ToString();
    }

    public void ItemBase(int n)
    {
        if (humanOn|| humanGearOn || animalOn)
        {
            return;
        }
        if (itemOn)
        {
            costSave += n;
            currentSave.Add(9);
        }
        else
        {
            costSave -= n;
            currentSave.Remove(9);
        }
        costUI.text = costSave.ToString();
    }

    public void ItemUpdateSave(int n)
    {
        if (humanOn|| humanGearOn || animalOn)
        {
            return;
        }
        if (itemToggle.isOn)
        {
            costSave += n;
            currentSave.Add(10);
        }
        else
        {
            costSave -= n;
            currentSave.Remove(10);
        }
        costUI.text = costSave.ToString();
    }

    #endregion

    public GameObject currentText = null;
    //文本选择
    public void TextSelecter()
    {
        if (currentText != null)
        {
            currentText.SetActive(false);
        }
        switch (currentViewer.m_order.ID)
        {
            //订单0
            case 0 :
            if (currentSave.Contains(1))
            {
                texts[1].SetActive(true);
                currentText = texts[1];
            }
            if (currentSave.Contains(9))
            {
                texts[0].SetActive(true);
                currentText = texts[0];
            }
            break;
            //订单1
            case 1 :
            if (currentSave.Contains(4))
            {
                texts[2].SetActive(true);
                currentText = texts[2];
            }
            if (currentSave.Contains(1))
            {
                texts[3].SetActive(true);
                currentText = texts[3];
            }
            if (currentSave.Contains(7))
            {
                texts[4].SetActive(true);
                currentText = texts[4];
            }
            if (currentSave.Contains(9))
            {
                texts[5].SetActive(true);
                currentText = texts[5];
            }
            break;
            //订单2
            case 2 :
            if (currentSave.Contains(4))
            {
                texts[6].SetActive(true);
                currentText = texts[6];
            }
            else
            {
                if (currentSave.Count <= 0)
                {
                    break;
                }
                texts[7].SetActive(true);
                currentText = texts[7];
            }
            break;
            //订单3
            case 3 :
            if (currentSave.Contains(9) && currentSave.Count == 1)
            {
                texts[8].SetActive(true);
                currentText = texts[8];
            }
            if (currentSave.Contains(9) && currentSave.Contains(10))
            {
                texts[9].SetActive(true);
                currentText = texts[9];
            }
            if (currentSave.Contains(7) && currentSave.Count == 1)
            {
                texts[10].SetActive(true);
                currentText = texts[10];
            }
            if (currentSave.Contains(7) && currentSave.Contains(8))
            {
                texts[11].SetActive(true);
                currentText = texts[11];
            }
            if (currentSave.Contains(1) && currentSave.Count == 1)
            {
                texts[12].SetActive(true);
                currentText = texts[12];
            }
            if (currentSave.Contains(1) && currentSave.Contains(2) && currentSave.Count == 2)
            {
                texts[13].SetActive(true);
                currentText = texts[13];
            }
            if (currentSave.Contains(1) && currentSave.Contains(3) && currentSave.Count == 2)
            {
                texts[14].SetActive(true);
                currentText = texts[14];
            }
            if (currentSave.Contains(1) && currentSave.Contains(2) && currentSave.Contains(3))
            {
                texts[15].SetActive(true);
                currentText = texts[15];
            }
            if (currentSave.Contains(4))
            {
                texts[16].SetActive(true);
                currentText = texts[16];
            }
            break;
            //订单4
            case 4 :
            if (currentSave.Contains(1) && currentSave.Contains(3) && currentSave.Count == 2)
            {
                texts[17].SetActive(true);
                currentText = texts[17];
            }
            break;
            //订单5
            case 5 :
            if (currentSave.Contains(1))
            {
                texts[18].SetActive(true);
                currentText = texts[18];
                break;
            }
            if (currentSave.Contains(4))
            {
                texts[19].SetActive(true);
                currentText = texts[19];
                break;
            }
            if (currentSave.Count <= 0)
            {
                break;
            }
            texts[20].SetActive(true);
            currentText = texts[20];
            break;
            //订单6
            case 6 :
            if (currentSave.Contains(4) && currentSave.Count == 1)
            {
                texts[21].SetActive(true);
                currentText = texts[21];
            }
            break;
        }
    }

    #region 开关
    //人类
    public void HumanFold()
    {
        if (humanGearOn || animalOn || itemOn)
        {
            return;
        }
        if (humanOn)
        {
            human.SetActive(false);
            humanText.text = "派遣员";
            humanOn = false;
            if (gameManager.round >= 3 && currentViewer.m_order.ID != 4)
            {
                humanUpdate_1.SetActive(false);
                humanToggle_1.isOn = false;
            }
            if (gameManager.round >= 3)
            {
                humanUpdate_2.SetActive(false);
                humanToggle_2.isOn = false;
            }
        }
        else
        {
            human.SetActive(true);
            humanText.text = "派遣员√";
            humanOn = true;
            if (gameManager.round >= 3 && currentViewer.m_order.ID != 4)
            {
                humanUpdate_1.SetActive(true);
            }
            if (gameManager.round >= 3)
            {
                humanUpdate_2.SetActive(true);
            }
        }
    }

    //仿生人
    public void HumanGearFold()
    {
        if (humanOn || animalOn || itemOn || gameManager.round < 2)
        {
            return;
        }
        if (humanGearOn)
        {
            humanGear.SetActive(false);
            humanGearText.text = "安可";
            humanGearOn = false;
            if (gameManager.round >= 3 && currentViewer.m_order.ID != 6)
            {
                humanGearUpdate_1.SetActive(false);
                humanGearToggle_1.isOn = false;
            }
            if (gameManager.round >= 3 && currentViewer.m_order.ID != 6)
            {
                humanGearUpdate_2.SetActive(false);
                humanGearToggle_2.isOn = false;
            }
        }
        else
        {
            humanGear.SetActive(true);
            humanGearText.text = "安可√";
            humanGearOn = true;
            if (gameManager.round >= 3 && currentViewer.m_order.ID != 6)
            {
                humanGearUpdate_1.SetActive(true);
            }
            if (gameManager.round >= 3 && currentViewer.m_order.ID != 6)
            {
                humanGearUpdate_2.SetActive(true);
            }
        }
    }

    public void AnimalFold()
    {
        if (humanGearOn || humanOn || itemOn || gameManager.round < 2)
        {
            return;
        }
        if (animalOn)
        {
            animal.SetActive(false);
            animalText.text = "宠物";
            animalOn = false;
            if (gameManager.round >= 3)
            {
                animalUpdate.SetActive(false);
            }
            animalToggle.isOn = false;
        }
        else
        {
            animal.SetActive(true);
            animalText.text = "宠物√";
            animalOn = true;
            if (gameManager.round >= 3)
            {
                animalUpdate.SetActive(true);
            }
        }
    }

    public void ItemFold()
    {
        if (humanGearOn || humanOn || animalOn)
        {
            return;
        }
        if (itemOn)
        {
            item.SetActive(false);
            itemText.text = "物件";
            itemOn = false;
            if (gameManager.round >= 3)
            {
                itemUpdate.SetActive(false);
            }
            itemToggle.isOn = false;
        }
        else
        {
            item.SetActive(true);
            itemText.text = "物件√";
            itemOn = true;
            if (gameManager.round >= 3)
            {
                itemUpdate.SetActive(true);
            }
        }
    }
    #endregion
    
    public void On()
    {
        serviceMenu.SetActive(true);
        //TODO 服务初始化
        currentViewer = gameObject.GetComponent<OrderMenuController>().currentViewer;
        Debug.Log(currentViewer.m_order.ID);
        if (currentViewer.m_order.ID == 4)
        {
            humanGearButton.SetActive(false);
            animalButton.SetActive(false);
            itemButton.SetActive(false);
        }
        if (currentViewer.m_order.ID == 6)
        {
            humanButton.SetActive(false);
            animalButton.SetActive(false);
            itemButton.SetActive(false);
        }
    }

    public void Off()
    {
        serviceMenu.SetActive(false);
        //还原属性
        if (humanOn)
        {
            HumanFold();
        }
        if (humanGearOn)
        {
            HumanGearFold();
        }
        if (animalOn)
        {
            AnimalFold();
        }
        if (itemOn)
        {
            ItemFold();
        }
        currentText.SetActive(false);
        currentText = null;
        costSave = 0;
        costUI.text = costSave.ToString();
        currentSave.Clear();
    }

    public void SaveChooseResult()
    {
        if (currentSave.Count <= 0)
        {
            gameObject.GetComponent<OrderMenuController>().On();
            Off();
            return;
        }
        gameManager.orderCount++;
        gameManager.playerFund -= costSave;
        gameManager.fundUI.text = gameManager.playerFund.ToString();
        currentSave.Sort();
        //Debug.Log(currentViewer.m_order.ID);
        AddChoice(currentViewer.m_order.ID);
        if (currentViewer.m_order.ID == 4)
        {
            humanGearButton.SetActive(true);
            animalButton.SetActive(true);
            itemButton.SetActive(true);
        }
        OrderViewer temp = gameObject.GetComponent<OrderMenuController>().currentViewer;
        if (temp != null)
        {
            gameObject.GetComponent<OrderMenuController>().allOrders.Remove(temp);
            Destroy(temp.gameObject);
        }
        if (gameObject.GetComponent<OrderMenuController>().allOrders.Count > 0)
        {
            gameObject.GetComponent<OrderMenuController>().On();
        }
        Off();
        if (gameManager.round == 4)
        {
            backGround.GetComponent<TextController>().enabled = false;
            backGround.GetComponent<Text>().color = new Color(255.0f, 0.0f, 0.0f, 255.0f);
            playerUI.SetActive(false);
            orderUI.SetActive(false);
            orderMenu.SetActive(false);
        }
    }

    public void SendChoiceResult()
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().dic = new Dictionary<int, List<int>>(choiceSaves);
    }
}
