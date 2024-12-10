using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballstart : MonoBehaviour
{
    [SerializeField]
    float ballSpeed;

    public Rigidbody2D ballRb;

    public BreakoutController breakoutController;

    [SerializeField]
    float forceAdder;
    // Start is called before the first frame update
    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
        ballRb.velocity = new Vector2(0, -1) * ballSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        ballRb.velocity = new Vector2(ballRb.velocity.x, ballRb.velocity.y).normalized * ballSpeed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            if (breakoutController.movingRight == true)
            {
                ballRb.velocity = new Vector2(forceAdder, ballRb.velocity.y);

                print("moving right and colliding with player");
            }
            if (breakoutController.movingLeft == true)
            {
                ballRb.velocity = new Vector2(-forceAdder, ballRb.velocity.y);

                print("moving left and colliding with player");
            }
        }
    }
}
