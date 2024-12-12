using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakWhenCollision : MonoBehaviour
{
    public int blockHealth;
    public int blocksGone;
    // Start is called before the first frame update
    void Start()
    {
        blocksGone = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (blockHealth <= 0)
        {
            Destroy(gameObject); 
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("block got hit");
        blockHealth-= 1;
        blocksGone-= 1;
    }
}
