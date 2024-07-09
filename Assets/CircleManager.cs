using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CircleManager : MonoBehaviour
{
    public GameObject redCirclePrefab;
    public GameObject blueCirclePrefab;
    public int ClickNum=0;
    public int ClickCount=0;
    public int maxSpawnAttempts = 10;
    public int comboNum=0;
    public Vector3 redpos;
    public Vector3 bluepos;
    public ComboCounter comboCounter;
    public List<GameObject> list = new List<GameObject>();
    private GameObject currentCircle;
    public CountdownTimer timer;
    public bool finished;
    public Animator finishTextAnimator;
    private void Start()
    {
        SpawnRedCircle();
        SpawnBlueCircle();
        timer = GameObject.Find("Timer").GetComponent<CountdownTimer>();
        finished = timer.IsFinished();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ClickCount++;
        }
        finished = timer.IsFinished();
        if (finished)
        {
            ChangeResultSceneWithAnimation();
        }
    }

    public void SpawnRedCircle()
    {
        Vector3 spawnPosition = GetRandomPosition();
        currentCircle = Instantiate(redCirclePrefab, spawnPosition, Quaternion.identity);
        bluepos = spawnPosition;
        list.Add(currentCircle);
    }

    public void SpawnBlueCircle()
    {
        Vector3 spawnPosition = GetNonOverlappingPosition();
        currentCircle = Instantiate(blueCirclePrefab, spawnPosition, Quaternion.identity);
        bluepos = spawnPosition;
        list.Add(currentCircle);
    }

    private Vector3 GetRandomPosition()
    {
        float maxRandomX = 7.5f;
        float maxRandomY = 3f;
        Vector3 spawnPosition = new Vector3(Random.Range(-maxRandomX, maxRandomX), Random.Range(-maxRandomY, maxRandomY), 0f);
        return spawnPosition;
    }

    public int GetClickNum()
    {
        return ClickNum;
    }
    public void AddClickNum()
    {
        ClickNum++;
    }

    public int GetClickCount()
    {
        return ClickCount;
    }

    public int GetComboNum() { return comboNum; }
    public void AddComboNum() { comboNum++; }
    public void ResetComboNum() { comboNum = 0; }


    public void SetRedpos(Vector3 redpos)
    {
        this.redpos = redpos;
    }

    public void SetBluepos(Vector3 bluepos)
    {
        this.bluepos = bluepos;
    }

    private Vector3 GetNonOverlappingPosition()
    {
        int attempts = 0;
        Vector3 randomPosition = Vector3.zero;
        bool isOverlapping = true;

        while (isOverlapping && attempts < maxSpawnAttempts)
        {
            randomPosition = new Vector3(Random.Range(-7.5f, 7.5f), Random.Range(-3f, 3f), 0f);
            isOverlapping = CheckOverlap(randomPosition);
            attempts++;
        }

        return randomPosition;
    }

    private bool CheckOverlap(Vector3 position)
    {
            if (Vector3.Distance(position, bluepos) < 1.5f) // Adjust the radius as needed
            {
                return true;
            }
        return false;
    }

    public bool IsFinished()
    {
        return finished;
    }

    public void ChangeResultScene()
    {
        SceneManager.LoadScene("Result");
    }

    public void ChangeResultSceneWithAnimation()
    {
        StartCoroutine(PlayAnimationAndChangeScene("Result"));
    }

    private IEnumerator PlayAnimationAndChangeScene(string sceneName)
    {
        finishTextAnimator.SetTrigger("PlayFinishTextAnimation");
        yield return new WaitForSeconds(1.9f); // アニメーションの長さに応じて調整
        SceneManager.LoadScene(sceneName);
    }
}
