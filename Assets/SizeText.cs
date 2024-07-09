using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SizeText : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI sizeText;
    float size;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        size = PlayerPrefs.GetFloat("size", 1);
        sizeText.SetText("x {0:2}", size);
    }
}

/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SizeText : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI sizeText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sizeText.text = "";
    }
}
*/
