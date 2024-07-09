using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorImage2 : MonoBehaviour
{
    // Start is called before the first frame update
    private Image circleRenderer;
    private byte red2;
    private byte green2;
    private byte blue2;
    void Start()
    {
        circleRenderer = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        red2 = (byte)PlayerPrefs.GetInt("Red2", 0);
        green2 = (byte)PlayerPrefs.GetInt("Green2", 0);
        blue2 = (byte)PlayerPrefs.GetInt("Blue2", 255);
        circleRenderer.color = new Color32(red2, green2, blue2, 255);
    }
}
