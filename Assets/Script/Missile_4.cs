using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile_4 : MonoBehaviour
{
    bool ksFlag = false;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
            if (ksFlag == true)
            {
                gameObject.transform.position = new Vector2(71, 28);
                ksFlag = false;
            }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ksFlag = true;
    }
}
