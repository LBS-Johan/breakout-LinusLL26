using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public GameObject Block1;

    public int Blockamount;

    float BlockSpacingX;

    float BlockSpacingY;

    // Start is called before the first frame update
    void Start()
    {
        BlockSpacingX = 16 / Blockamount;
        BlockSpacingY = 8 / Blockamount;
        Vector2 BlockStartPos = new Vector2(16 - BlockSpacingX, 8 - BlockSpacingY);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
