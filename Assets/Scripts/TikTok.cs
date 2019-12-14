using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TikTok : MonoBehaviour
{
    public Image desktop;
    public float changeFrequence;
    private Color white;
    private Color dark;
    private bool isDark = true;

    // Start is called before the first frame update
    private void Start()
    {
        white = desktop.color;
        dark = new Color(white.r, white.g, white.b, 0.0f);
        desktop.color = dark;
    }

    private void Update()
    {
        if (isDark)
        {
            desktop.color = Color.Lerp(desktop.color, white, Time.deltaTime * changeFrequence);
            if (desktop.color.a >= (white.a - 0.005f))
            {
                desktop.color = white;
                isDark = false;
            }
        }
        else
        {
            desktop.color = Color.Lerp(desktop.color, dark, Time.deltaTime * changeFrequence);
            if (desktop.color.a <= 0.005f)
            {
                desktop.color = dark;
                isDark = true;
            }
        }
    }


}
