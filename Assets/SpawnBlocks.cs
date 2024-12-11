using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour
{
    public GameObject block;
    GameObject blockClone;
    Vector3 spawnPosition = new Vector3(8, 3.5f, 0);
    public Vector3 spawnDistance;
    public int rowAmount;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < rowAmount; i++)
        {
            if(spawnPosition.x < -8)
            {
                
            }
            else
            {
                CreateBlock(spawnPosition + new Vector3(-1, 0, 0));
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
