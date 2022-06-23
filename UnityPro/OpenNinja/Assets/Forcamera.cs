using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forcamera : MonoBehaviour
{
    float offset;
    
    [SerializeField] GameObject PlayerPos;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position.x - PlayerPos.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(PlayerPos.transform.position.x + offset, transform.position.y,transform.position.z);
    }
}
