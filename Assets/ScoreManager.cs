using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI scoreText;
    public int score = 0;
    private CircleManager circleManager;
    public int circleCount = 0;
    private int bonus;
    void Start()
    {
        circleManager = GameObject.Find("Circle Manager").GetComponent<CircleManager>();
        circleCount =circleManager.GetClickCount();
        PlayerPrefs.SetInt("SCORE", 0);
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        //SumScore();
        circleCount = circleManager.GetClickCount();
        scoreText.text = "ÉXÉRÉA" + score + "pt";

    }

    public void SumScore()
    {
        Bonus(circleManager.GetComboNum());
        score += 1000 + bonus;
        PlayerPrefs.SetInt("SCORE", score);
        PlayerPrefs.Save();
    }

    public void Bonus(int ComboNum)
    {
        if(ComboNum <= 1) bonus = 0;
        else bonus = ComboNum * ComboNum;
    }
}
