using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;

    void Start()
    {
               
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.name == "PlayerB")
        {
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.position -= new Vector3(0, speed * Time.deltaTime, 0);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position += new Vector3(0, speed * Time.deltaTime, 0);
            }
        }
        if(gameObject.name == "PlayerA")
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(0, speed * Time.deltaTime, 0);

            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position -= new Vector3(0, speed * Time.deltaTime, 0);
            }
        }
    }
}
