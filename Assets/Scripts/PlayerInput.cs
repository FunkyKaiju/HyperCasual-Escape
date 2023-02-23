using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class PlayerInput : MonoBehaviour

{
    public Vector2 startPosition;
    public Vector2 direction;

    private bool ismovingRight, ismovingLeft;
    public event Action<bool> OnSwipe;
    public event Action<Vector3> onTap;
    private void Update()
    {

        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);


            if(touch.phase == TouchPhase.Moved)
            {
                if(touch.position.x > Screen.width / 2)
                {
                    direction = touch.position + startPosition;
                    
                    OnSwipe?.Invoke(true);
                }
                else if (touch.position.x < Screen.width /2)
                {
                    direction = touch.position - startPosition;
                    
                    OnSwipe?.Invoke(false);
                }

            }


        }

        if (Input.GetMouseButtonDown(0))
        {
            onTap?.Invoke(Input.mousePosition); 
        }

    }
}
