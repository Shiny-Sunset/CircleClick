using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingGreenColor : MonoBehaviour
{
    // Start is called before the first frame update
    Slider colorSlider;
    private int green;
    void Start()
    {
        colorSlider = GetComponent<Slider>();
        colorSlider.value = PlayerPrefs.GetInt("Green1", 0);
    }

    // Update is called once per frame
    void Update()
    {
        green = (int)colorSlider.value;
        PlayerPrefs.SetInt("Green1", green);
    }

    public void setDefault()
    {
        colorSlider.value = 0;
    }
}
