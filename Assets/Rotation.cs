using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rotation : MonoBehaviour
{
    
    public float rotateSpeed = 10f;
    public Transform pivotPoint;

    private int direction = 1;

    // Update is called once per frame
    void Update() {
        
        if (Input.GetKeyDown(KeyCode.Space)) {
            direction = direction == 1 ? -1 : 1;
        }


        transform.RotateAround(pivotPoint.transform.localPosition, Vector3.back, rotateSpeed * direction * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag.Equals("Square")) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
