using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour {

    [SerializeField] GameObject Manager;
    
    private void OnTriggerEnter2D(Collider2D col) {
        Manager.GetComponent<Manager>().IncreaseScore();
        Destroy(gameObject);
    }
}
