using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAxis : MonoBehaviour
{
    float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        


        translation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
    }
}
