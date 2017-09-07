using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody2D rb2d;
    public float PlayerSpeed = 10f;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

	void FixedUpdate()
    {
        float moveHortizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2 (moveHortizontal, moveVertical);
        rb2d.AddForce(movement * PlayerSpeed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false); 
        }
    }
}
