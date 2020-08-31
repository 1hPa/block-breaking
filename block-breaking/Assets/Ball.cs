using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 20.0f;

    private Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        // Get rigid body
        rigid = this.GetComponent<Rigidbody>();
        rigid.AddForce((transform.forward + transform.right) * speed,
                ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
