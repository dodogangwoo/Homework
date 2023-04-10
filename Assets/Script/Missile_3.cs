using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile_3 : MonoBehaviour
{
    float gravityScale = 0;
    bool kiFlag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gravityScale = 0.3f;
        if (kiFlag == true)
        {
            gameObject.transform.position = new Vector2(61, 25);
            kiFlag = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        kiFlag = true;
    }
}
