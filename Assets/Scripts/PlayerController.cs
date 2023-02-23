using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   [SerializeField] PlayerInput inputmanager;
    [SerializeField] private float horizontal;
    [SerializeField] private float speed = 10f;
    float direction;
    [SerializeField] private Rigidbody2D rb;



    private void OnEnable()
    {
        inputmanager.OnSwipe += HandleSwipe; //subscribed to the event
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    /// <summary>
    /// Receives call back from the player input class regarding
    /// if player has swiped right or left. if data is true, player is swiping
    /// right, if false player is swiping left
    /// </summary>
    /// <param name="rightOrLeft"></param>
    private void HandleSwipe(bool rightOrLeft)
    {
       if(rightOrLeft == true)
        {
            rb.AddForce(Vector2.right * 1 * speed);
        }
        if (rightOrLeft == false)
        {
            rb.AddForce(Vector2.right * -1 * speed);

        }
    }
}
