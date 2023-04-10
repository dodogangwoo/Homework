using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    float gravityScale = 0;
    bool kissFlag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gravityScale = 0.3f;
        if (kissFlag == true)
        {
            gameObject.transform.position = new Vector2(41, 19);
            kissFlag = false;
            
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        kissFlag = true;
    }
}
