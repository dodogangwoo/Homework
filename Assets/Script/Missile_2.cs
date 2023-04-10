using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile_2 : MonoBehaviour
{
    float gravityScale = 0;
    bool kisFlag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gravityScale = 0.3f;
        if (kisFlag == true)
        {
            gameObject.transform.position = new Vector2(51, 22);
            kisFlag = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        kisFlag = true;
    }
}
