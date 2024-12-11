using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour
{
    public GameObject block;
    GameObject blockClone;
    Vector3 spawnPosition = new Vector3(8, 3.5f, 0);
    Vector3 firstRowSpawnPosition = new Vector3(8, 3.5f, 0);
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
                    if (spawnPosition.x > -8)
                    {
                        CreateBlock(spawnPosition + new Vector3(-spawnDistanceDifference.x, 0, 0));
                    }
                }
                spawnPosition.x = 8;
                CreateBlock(spawnPosition + new Vector3(0, -spawnDistanceDifference.y, 0));

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
