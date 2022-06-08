using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    { if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddForce(Vector2.left * Time.deltaTime, ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddForce(Vector2.right * Time.deltaTime, ForceMode2D.Force );
        }
    }
    
}
