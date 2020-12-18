using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBOx : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(0.01f, 0,0 );
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(-0.01f, 0,0 );
        }

        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(0, 0.01f,0 );
        }

        if (Input.GetKey(KeyCode.E))
        {
            gameObject.transform.Rotate(10, 0,0);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            gameObject.transform.Rotate(-10, 0,0);
        }
    }
}
