using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour {
    private bool colliding = false;

    private void OnTriggerEnter2D(Collider2D col) {
        colliding = true;
        //Debug.Log(colliding);
    }

    private void OnTriggerExit2D(Collider2D other) {
        colliding = false;
        //Debug.Log(colliding);
    }

    public bool isGrounded() {
        return colliding;
    }
}
