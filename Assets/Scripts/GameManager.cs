using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int points = 0;
    public float timer = 0.0f;
    public float timerInSec = 0; // time in seconds rounded up to 2 decimal places

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
            instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        timerInSec = (Mathf.Round(timer*100)) / 100.0f;
    }
}
