using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballstart : MonoBehaviour
{
    [SerializeField]
    float ballSpeed;

    Rigidbody2D ballRb;
    // Start is called before the first frame update
    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
        ballRb.velocity = new Vector2(0, -1) * ballSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
