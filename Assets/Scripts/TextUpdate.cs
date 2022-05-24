using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdate : MonoBehaviour
{
    public Text scoreText;
    public Text durationText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "SCORE: " + GameManager.instance.points;
        durationText.text = "TIME: " + GameManager.instance.timerInSec;
    }
}
