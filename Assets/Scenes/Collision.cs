using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    [SerializeField] float timeToDestroy = 1.0f;
    bool hasPackage;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Package"){
            Debug.Log("Package picked up");
            hasPackage = true;
            Destroy(other, timeToDestroy);
        }
        else if(other.tag == "Customer"){
            Debug.Log("Package delivered");
            hasPackage = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Fuck");
    }
}
