using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D rb;
    public float jumpAmount = 10;
    public GameObject groundChecker;
    public List<Sprite> sprites;
    public SpriteRenderer sr;
    private bool buttonPressed = false;
    void Update() {

        if (rb.velocity != Vector2.zero) {
            if (rb.velocity.normalized.x < 0) {
                sr.sprite = sprites[1];
            } else {
                sr.sprite = sprites[2];
            }
            
        } else {
            if (!buttonPressed) {
                sr.sprite = sprites[3];
            }
            if (Input.GetMouseButton(0)) {

                sr.sprite = sprites[0];
                buttonPressed = true;
            } else if (Input.GetMouseButtonUp(0)) {
            
                if (groundChecker.GetComponent<GroundChecker>().isGrounded() && rb.velocity == Vector2.zero){ 
                    // Get the mouse position in world space
                    Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    mousePosition.z = 0f; // Make sure the z-axis is 0

                    // Calculate the direction from the cube to the mouse position
                    Vector2 direction = mousePosition - transform.position;

                    // Apply force to the cube in the direction of the mouse
                    rb.AddForce(new Vector2(direction.normalized.x * jumpAmount, direction.normalized.y * jumpAmount), ForceMode2D.Impulse);
                }

                buttonPressed = false;
            }
        }

        //Debug.Log(buttonPressed);
        
        
    } 
    
    
}
