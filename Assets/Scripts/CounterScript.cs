using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterScript : MonoBehaviour
{
    public static CounterScript Instance;

    public float point;

    void Start()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    
    void Update()
    {
        
    }
}
