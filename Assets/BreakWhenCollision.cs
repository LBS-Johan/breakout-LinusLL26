using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakWhenCollision : MonoBehaviour
{
    public int blockHealth;
    // Start is called before the first frame update
    void Start()
    {
        
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
        blockHealth-= 1;
    }
}