using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Initial velocity
    public float speed = 100;
    // Start is called before the first frame update
    void Start()
    {
        // Get rigid body
        this.GetComponent<Rigidbody>().AddForce(
            (transform.forward + transform.right) * speed,
            ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
