using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingRedColor : MonoBehaviour
{
    // Start is called before the first frame update
    Slider colorSlider;
    private int red;
    void Start()
    {
        colorSlider = GetComponent<Slider>();
        colorSlider.value = PlayerPrefs.GetInt("Red1", 255);
    }

    // Update is called once per frame
    void Update()
    {
        red = (int)colorSlider.value;
        PlayerPrefs.SetInt("Red1", red);
    }

    public void setDefault()
    {
        colorSlider.value = 255;
    }
}
