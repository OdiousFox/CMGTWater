using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public GameObject player;
    public float offset = -3.5f;
    
    void Update() {
        this.transform.position = new Vector3(0, player.transform.position.y + offset, -10);
    }
}
