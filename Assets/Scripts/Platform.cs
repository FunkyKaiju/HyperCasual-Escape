using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour
{

    [SerializeField] private float moveSpeed;
    private void Update()
    {
        Move();
    }

    void Move()
    {
        Vector2 temp = transform.position;
        temp.y += moveSpeed * Time.deltaTime;
        transform.position = temp;

    }
}
   
