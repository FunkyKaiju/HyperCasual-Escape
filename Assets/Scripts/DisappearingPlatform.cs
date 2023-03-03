using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingPlatform : MonoBehaviour
{
    [SerializeField] private float timeToTogglePaltform = 2;
    [SerializeField] private float currentTime = 0;
    public bool enabled = true;

    private void Start()
    {
        enabled = true;
    }

    private void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime >= timeToTogglePaltform)
        {
            currentTime = 0;
            TogglePaltform();
        }
    }

   void TogglePaltform()
    {
        enabled = !enabled;
        foreach(Transform child in gameObject.transform)
        {
            if(child.tag != "Player")
            {
                child.gameObject.SetActive(enabled);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.SetParent(transform);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.SetParent(null);
    }

}
