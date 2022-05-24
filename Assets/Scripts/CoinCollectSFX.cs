using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollectSFX : MonoBehaviour
{
    public AudioClip _coinSound;

    /*
     * Plays an audioclip when the coin is on trigger
     */
    private void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(_coinSound, transform.position);
        Destroy(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
