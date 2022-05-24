using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement : MonoBehaviour
{
    [SerializeField] private Animator _animator = default;
    [SerializeField] private KeyCode _slideKey = KeyCode.K;
    [SerializeField] private KeyCode _jumpKey = KeyCode.J;
    [SerializeField] private AudioClip _jumpSound;
    [SerializeField] private AudioClip _slideSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    /*
     * Update hero's movement including animation, speed, and position
     */
    void HeroMovementUpdate()
    {
        if (_animator != null)
        {
            if (Input.GetKeyDown(_slideKey))
            {
                _animator.SetTrigger("Slide");

                // Slide sound
                AudioSource.PlayClipAtPoint(_slideSound, transform.position);
            }

            if (Input.GetKeyDown(_jumpKey))
            {
                _animator.SetTrigger("Jump");

                // Jump sound
                AudioSource.PlayClipAtPoint(_jumpSound, transform.position);
            }
        }
        IncreaseRunSpeed();
        StayMiddle();
    }

    /*
     * Method to set hero's x position to be 0
     */
    void StayMiddle()
    {
        Vector3 heroPos = this.gameObject.transform.position;

        // When the hero's x position goes out of range between -0.4 and 0.4, goes back to 0 pos
        if ((heroPos.x > 0.4) || (heroPos.x < -0.4))
            heroPos = new Vector3(0, heroPos.y, heroPos.z);
    }

    /*
     * Method to increase the speed of running (depends on the score)
     */
    void IncreaseRunSpeed()
    {
        int points = GameManager.instance.points;
        if (points >= 100 && points < 200)
        {
            _animator.SetFloat("runSpeed", 1.2f);
        }
        else if (points >= 200 && points < 400)
        {
            _animator.SetFloat("runSpeed", 1.4f);
        }
        else if (points >= 400 && points < 500)
        {
            _animator.SetFloat("runSpeed", 1.5f);
        }
        else if (points >= 500)
        {
            _animator.SetFloat("runSpeed", 2.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        HeroMovementUpdate();
    }
}
