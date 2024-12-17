using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public Transform blockContainer;
    public int score;
    public int scoreMultiplier;
    int previousChildCount;
    // Start is called before the first frame update
    void Start()
    {
        score = 0 - 1 * scoreMultiplier;
        previousChildCount = blockContainer.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        if (previousChildCount > blockContainer.childCount)
        {
            score += 1 * scoreMultiplier;
           
        }
        previousChildCount = blockContainer.childCount;
    }
}
