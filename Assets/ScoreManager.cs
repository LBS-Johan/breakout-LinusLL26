using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public BreakWhenCollision blockHealth;
    public int score;
    public int scoreMultiplier;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score = blockHealth.gotDestroyedCount * scoreMultiplier;
    }
}
