using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeAndDestroy : MonoBehaviour
{
    private SpriteRenderer circleRenderer;
    private bool isRed = false;
    private CircleManager circleManager;
    private ScoreManager scoreManager;
    private int num;
    private float size;
    private byte red1;
    private byte green1;
    private byte blue1;
    private byte red2;
    private byte green2;
    private byte blue2;
    private Collider2D CircleCollider;
    
    private void Start()
    {
        circleRenderer = GetComponent<SpriteRenderer>();
        circleManager = GameObject.Find("Circle Manager").GetComponent<CircleManager>();
        scoreManager = GameObject.Find("Score").GetComponent <ScoreManager>();
        num = circleManager.GetClickNum();
        size = PlayerPrefs.GetFloat("size", 1);
        transform.localScale = new Vector3(size, size, 1);
        red1 = (byte)PlayerPrefs.GetInt("Red1", 255);
        green1 = (byte)PlayerPrefs.GetInt("Green1", 0);
        blue1 = (byte)PlayerPrefs.GetInt("Blue1", 0);
        red2 = (byte)PlayerPrefs.GetInt("Red2", 0);
        green2 = (byte)PlayerPrefs.GetInt("Green2", 0);
        blue2 = (byte)PlayerPrefs.GetInt("Blue2", 255);
        //circleRenderer.color = new Color32(0, 0, 255, 255);
        circleRenderer.color = new Color32(red2, green2, blue2, 255);
        CircleCollider = GetComponent<Collider2D>();



    }

    private void Update()
    {
        if (num < circleManager.GetClickNum())
        {

            UpdateColor();
        }
        if (circleManager.IsFinished())
        {
            CircleCollider.enabled = false;
        }
    }

    private void OnMouseDown()
    {
        if (isRed)
        {
            circleManager.AddClickNum();
            Destroy(gameObject);
            circleManager.SpawnBlueCircle();
            circleManager.AddComboNum();
            scoreManager.SumScore();
        }
    }

    public void UpdateColor()
    {
        //circleRenderer.color = new Color32(255,0,0,255);
        circleRenderer.color = new Color32(red1, green1, blue1, 255);
        isRed = true;
    }

}
