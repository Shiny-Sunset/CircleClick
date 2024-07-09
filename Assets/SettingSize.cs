using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingSize : MonoBehaviour
{
    // Start is called before the first frame update
    Slider sizeSlider;
    private float size;
    void Start()
    {
        sizeSlider = GetComponent<Slider>();
        sizeSlider.value = PlayerPrefs.GetFloat("size", 1);
    }

    // Update is called once per frame
    void Update()
    {
        size = sizeSlider.value;
        PlayerPrefs.SetFloat("size",size);
    }

    public void SetDefault()
    {
        sizeSlider.value = 1;
    }

}
