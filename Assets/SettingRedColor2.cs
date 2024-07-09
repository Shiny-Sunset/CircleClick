using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingRedColor2 : MonoBehaviour
{
    // Start is called before the first frame update
    Slider colorSlider;
    private int red;
    void Start()
    {
        colorSlider = GetComponent<Slider>();
        colorSlider.value = PlayerPrefs.GetInt("Red2", 0);
    }

    // Update is called once per frame
    void Update()
    {
        red = (int)colorSlider.value;
        PlayerPrefs.SetInt("Red2", red);
    }

    public void setDefault()
    {
        colorSlider.value = 0;
    }
}
