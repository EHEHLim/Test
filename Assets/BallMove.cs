using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private float x;
    private float y;
    void Start()
    {
        x = Random.Range(-0.7f, 0.7f);
        if(x > 0.1)
        {
            y = Random.Range((1 - x) * -1, 1 - x);
        }
        else if(x < -0.1)
        {
            y = Random.Range((1 + x) * -1, 1 + x);
        }
        else
        {
            x = 0.1f;
            y = Random.Range((1 - x) * -1, 1 - x);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(x * speed * Time.deltaTime , y * speed * Time.deltaTime, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            y *= -1;
        }
        if (collision.gameObject.tag == "Foul")
        {
            Destroy(gameObject);
        }
        if(collision.gameObject.name == "PlayerA")
        {
            x = Random.Range(0.1f, 0.9f);
            y = 1 - x;
        }
        if(collision.gameObject.name == "PlayerB")
        {
            x = Random.Range(-0.9f, -0.1f);
            y = (x + 1)*-1;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "ASiteFoul")
        {
            Debug.Log("B Win");
            Destroy(gameObject);
        }
        if (collision.name == "BSiteFoul")
        {
            Debug.Log("A Win");
            Destroy(gameObject);
        }
    }
}
