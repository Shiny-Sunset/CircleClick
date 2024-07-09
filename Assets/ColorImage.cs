using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorImage : MonoBehaviour
{
    // Start is called before the first frame update
    private Image circleRenderer;
    private byte red1;
    private byte green1;
    private byte blue1;
    void Start()
    {
        circleRenderer = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        red1 = (byte)PlayerPrefs.GetInt("Red1", 255);
        green1 = (byte)PlayerPrefs.GetInt("Green1", 0);
        blue1 = (byte)PlayerPrefs.GetInt("Blue1", 0);
        circleRenderer.color = new Color32(red1, green1, blue1, 255);
    }
}
