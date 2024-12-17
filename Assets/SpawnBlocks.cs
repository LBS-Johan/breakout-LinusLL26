using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour
{
    public BreakWhenCollision whenCollision;
    public GameObject block;
    GameObject blockClone;
    Vector3 spawnPosition = new Vector3(7, 4.2f, 0);
    public Vector3 spawnPositionLimit;
    public Vector3 spawnDistanceDifference;
    public int maxCollumAmount;
    int rowAmount;
    public int maxRowAmount;
    public bool isCodeRunning;
    // Start is called before the first frame update
    void Start()
    {
        if (isCodeRunning == true)
        {
            for (rowAmount = 0; rowAmount < maxRowAmount; rowAmount++)
            {
                for (int i = 0; i < maxCollumAmount; i++)
                {
                    CreateBlock(new Vector3(i * spawnDistanceDifference.x - spawnDistanceDifference.x * maxRowAmount / 2, rowAmount * spawnDistanceDifference.y));
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
    void CreateBlock(Vector3 spawnpoint)
    { 
        blockClone = Instantiate(block, spawnpoint, Quaternion.identity);
        spawnPosition = blockClone.transform.position;
        blockClone.transform.parent = transform;
    }
}
