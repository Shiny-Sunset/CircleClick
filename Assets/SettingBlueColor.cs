using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingBlueColor : MonoBehaviour
{
    // Start is called before the first frame update
    Slider colorSlider;
    private int blue;
    void Start()
    {
        colorSlider = GetComponent<Slider>();
        colorSlider.value = PlayerPrefs.GetInt("Blue1", 0);
    }

    // Update is called once per frame
    void Update()
    {
        blue = (int)colorSlider.value;
        PlayerPrefs.SetInt("Blue1", blue);
    }

    public void setDefault()
    {
        colorSlider.value = 0;
    }
}
