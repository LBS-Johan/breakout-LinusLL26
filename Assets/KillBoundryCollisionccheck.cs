using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class KillBoundryCollisionccheck : MonoBehaviour
{
    public int collisionCount;
    public int damageTaken;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collisionCount += damageTaken;
    }
}
