using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 2f;
    public Transform pivotPoint;
    
    // Update is called once per frame
    void FixedUpdate() {
        transform.position = Vector2.MoveTowards(transform.position, pivotPoint.position, moveSpeed * Time.deltaTime);
    }
    
}
