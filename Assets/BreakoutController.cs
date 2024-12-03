using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakoutController : MonoBehaviour
{
    [SerializeField]
    float playerSpeed;

    [SerializeField]
    KeyCode MoveLeft;

    [SerializeField]
    KeyCode MoveRight;

    Rigidbody2D PlayerRb;

    public bool movingRight;

    public bool movingLeft;

    // Start is called before the first frame update
    void Start()
    {
       PlayerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerRb.velocity = new Vector2(0, 0);
        if (Input.GetKey(MoveRight))
        {
            PlayerRb.velocity = new Vector2(1, 0) * playerSpeed;
            movingRight = true;
        }
        else if (Input.GetKey(MoveLeft))
        {
            PlayerRb.velocity = new Vector2(-1, 0) * playerSpeed;
            movingLeft = true;
        }
        else
        {
            movingLeft = false;
            movingRight = false;
        }
    }
}
