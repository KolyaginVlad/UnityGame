using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Vector3 vector;
    public float speed;
    public float rot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        vector.z =  Input.GetAxis("Vertical");
        vector.x = Input.GetAxis("Horizontal");
        transform.Translate(vector * speed);
    }
}
