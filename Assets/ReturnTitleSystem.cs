using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnTitleSystem : MonoBehaviour
{
    public void ReturnTitle()
    {
        SceneManager.LoadScene("Title");
    }
}
