using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    /*
     * When the hero collides with coins (blue or red),
     * the score increases and the coin disappears
     */
    public void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "BlueCoin")
        {
            GameManager.instance.points += 3;
            col.gameObject.SetActive(false);
        }

        if (col.gameObject.tag == "RedCoin")
        {
            GameManager.instance.points += 5;
            col.gameObject.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
