using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResultScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        int resultScore = PlayerPrefs.GetInt("SCORE");
        scoreText.text = "ÉXÉRÉA" + resultScore + "pt";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
