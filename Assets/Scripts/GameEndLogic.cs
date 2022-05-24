using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEndLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    /*
     * Whenever the hero collides with a collider tagged as "Obstacle",
     * GameOver scene is loaded and the game ends
     */
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
