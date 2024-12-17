using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteWhenOutOfBounds : MonoBehaviour
{
    public Vector3 Bounds;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > Bounds.x || transform.position.y > Bounds.y || transform.position.x < -Bounds.x || transform.position.y < -Bounds.y)
        {
            Destroy(gameObject);
        }
    }
}
