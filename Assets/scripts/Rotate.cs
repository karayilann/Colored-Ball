using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float donmeHizi = 100f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, 0, donmeHizi * Time.deltaTime);
    }
}
