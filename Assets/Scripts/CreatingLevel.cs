using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingLevel : MonoBehaviour
{
    public GameObject[] lands;
    public int landNum = 0;
    public int zPos = 80;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    /*
     * Whenever the hero hits the "Mark" (transparent line), a new land is instantiated randomly
     * among the 3 different types of lands
     */
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Mark")
        {
            landNum = Random.Range(0, lands.Length);
            Instantiate(lands[landNum], new Vector3(0, 0, zPos), Quaternion.identity);
            zPos += 40;
        }
    }
}
