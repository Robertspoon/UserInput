using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKeyDown : MonoBehaviour
{
    float speed = 15.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        if (Input.GetKeyDown("s"))
        {
            gameObject.transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        if (Input.GetKeyDown("a"))
        {
            gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKeyDown("d"))
        {
            gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
