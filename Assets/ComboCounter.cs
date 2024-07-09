using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ComboCounter : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI comboText;
    public int comboNum;
    public bool isCombo;
    private CircleManager circleManager;
    private int difference = 0;
    void Start()
    {
        circleManager = GameObject.Find("Circle Manager").GetComponent<CircleManager>();
        comboNum = 0;
        isCombo = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsCombo())
        {
            comboNum=circleManager.comboNum;
            if (comboNum != 0)
            {
                comboText.text = comboNum + "ƒRƒ“ƒ{I";
            }
            else
            {
                comboText.text = null;
            }
        }
        else
        {
            circleManager.ResetComboNum();
        }
    }

    public void AddComboNum()
    {
        comboNum++;
    }

    private bool IsCombo()
    {
        if (circleManager.GetClickCount() - circleManager.GetClickNum() > difference)
        {
            difference = circleManager.GetClickCount() - circleManager.GetClickNum();
            return false;
        }
        else
        {
            return true;
        }
    }

}
