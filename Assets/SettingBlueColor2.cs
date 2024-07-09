using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingBlueColor2 : MonoBehaviour
{
    // Start is called before the first frame update
    Slider colorSlider;
    private int blue;
    void Start()
    {
        colorSlider = GetComponent<Slider>();
        colorSlider.value = PlayerPrefs.GetInt("Blue2", 255);
    }

    // Update is called once per frame
    void Update()
    {
        blue = (int)colorSlider.value;
        PlayerPrefs.SetInt("Blue2", blue);
    }

    public void setDefault()
    {
        colorSlider.value = 255;
    }
}
