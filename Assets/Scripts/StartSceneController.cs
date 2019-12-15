using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartSceneController : MonoBehaviour
{   
    public Text text_1;
    public Text text_2;
    public GameObject loginButton;
    public float speed = 10.0f;

    private void Update()
    {
        if (text_1.color.a >= 0.1f)
        {
            text_1.color -= new Color(0.0f, 0.0f, 0.0f, speed);
        }
        else
        {
            text_1.gameObject.SetActive(false);
        }
        if (text_1.gameObject.activeSelf == false)
        {
            text_2.color += new Color(0.0f, 0.0f, 0.0f, speed);
        }
        if (text_2.color.a >= 0.9f)
        {
            text_2.color = new Color(text_2.color.r, text_2.color.g, text_2.color.b, 1.0f);
            loginButton.SetActive(true);
        }
    }

    public void LoadStage()
    {
        SceneManager.LoadScene(1);
    }
}
