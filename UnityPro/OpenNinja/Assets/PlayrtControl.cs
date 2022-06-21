using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayrtControl : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.05f, 0, 0);
        Movement();
    }
    void Movement()
    {
        float speedDown = Input.GetAxis("Horizontal");
        transform.Translate(0.025f * speedDown, 0, 0);
    }
}
