using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayrtControl : MonoBehaviour
{
    Rigidbody2D rb;
    public bool hiding;
    
    // Start is called before the first frame update
    void Start()
    {
        hiding = false;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.W))
        {
            hiding = false;
            transform.position = new Vector3(0, -2, 0);
        }
        if (hiding == false)
        {
            transform.Translate(0.05f, 0, 0);
            Movement();
        }
        
    }
    void Movement()
    {
        float speedDown = Input.GetAxis("Horizontal");
        transform.Translate(0.025f * speedDown, 0, 0);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Window")
        {
            if (Input.GetKey(KeyCode.W))
            {
                hiding = true;
                transform.position = collision.gameObject.transform.position;
            }
            
        }
        
    }
}
