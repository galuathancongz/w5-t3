using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
  public  float speed = 9999999999f;
   public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    { 
        rb.AddTorque(Vector3.down * speed , ForceMode.VelocityChange);
    }
}
