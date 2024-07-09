using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingGreenColor2 : MonoBehaviour
{
    // Start is called before the first frame update
    Slider colorSlider;
    private int green;
    void Start()
    {
        colorSlider = GetComponent<Slider>();
        colorSlider.value = PlayerPrefs.GetInt("Green2", 0);
    }

    // Update is called once per frame
    void Update()
    {
        green = (int)colorSlider.value;
        PlayerPrefs.SetInt("Green2", green);
    }

    public void setDefault()
    {
        colorSlider.value = 0;
    }
}
