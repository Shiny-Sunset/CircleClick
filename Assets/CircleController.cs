using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleController : MonoBehaviour
{
    private SpriteRenderer circleRenderer;
    private CircleManager circleManager;
    private ScoreManager scoreManager;
    private float size;
    private byte red1;
    private byte green1;
    private byte blue1;
    private Collider2D CircleCollider;

    // Start is called before the first frame update
    void Start()
    {
        circleRenderer = GetComponent<SpriteRenderer>();
        circleManager = GameObject.Find("Circle Manager").GetComponent<CircleManager>();
        scoreManager = GameObject.Find("Score").GetComponent<ScoreManager>();
        size = PlayerPrefs.GetFloat("size", 1);
        transform.localScale = new Vector3(size, size, 1);
        red1 = (byte)PlayerPrefs.GetInt("Red1", 255);
        green1 = (byte)PlayerPrefs.GetInt("Green1", 0);
        blue1 = (byte)PlayerPrefs.GetInt("Blue1", 0);
        //circleRenderer.color = new Color32(255, 0, 0, 255);
        circleRenderer.color = new Color32(red1, green1, blue1, 255);
        CircleCollider = GetComponent<Collider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (circleManager.IsFinished())
        {
            CircleCollider.enabled = false;
        }

    }

    private void OnMouseDown()
    {

            circleManager.AddClickNum();
            Destroy(gameObject);
            circleManager.SpawnBlueCircle();
            circleManager.AddComboNum();
            scoreManager.SumScore();
    }

}
