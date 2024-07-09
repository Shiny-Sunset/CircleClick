using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CircleCounter : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI circleNumText;
    private int countNum;
    private CircleManager circleManager;
    void Start()
    {
        circleManager = GameObject.Find("Circle Manager").GetComponent<CircleManager>();
    }

    // Update is called once per frame
    void Update()
    {
        countNum = circleManager.GetClickNum();
        circleNumText.text = countNum.ToString() + "ŒÂ";
    }
}
