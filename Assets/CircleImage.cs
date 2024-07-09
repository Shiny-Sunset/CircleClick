using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleImage : MonoBehaviour
{
    private float size=1;
    void Update()
    {
        size = PlayerPrefs.GetFloat("size", 1);
        transform.localScale = new Vector3(size, size, 1);
    }
}
