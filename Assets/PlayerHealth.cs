using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public KillBoundryCollisionccheck killBoundryCollisioncheck;
    public int playerHealth;
    public bool isDead;
    public int damageTaken;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        damageTaken = killBoundryCollisioncheck.collisionCount;
        if (damageTaken >= playerHealth)
        {
            isDead = true;
            print("Player health = 0");
        }
    }
}
