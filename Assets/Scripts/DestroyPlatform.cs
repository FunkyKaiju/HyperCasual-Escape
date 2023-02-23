using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Starting destroy platform!");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision!");

        if (collision.gameObject.CompareTag("Platform"))
        {
            Destroy(collision.gameObject);
        }
    }

}
