using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Vector3 vector;
    public Vector3 mouse;
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
        mouse = Input.mousePosition;
        if (Input.GetMouseButton(0))
        {
            if (Screen.width / 2 < mouse.x)
                transform.Rotate(Vector3.up * rot);
            else
                transform.Rotate(Vector3.up * rot * -1);
        }
    }
}
