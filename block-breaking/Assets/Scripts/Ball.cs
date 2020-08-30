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
        Rigidbody rb = this.GetComponent<Rigidbody>();

        // Setting forces
        Vector3 force = new Vector3(10.0f,10.0f,0.0f)*speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
