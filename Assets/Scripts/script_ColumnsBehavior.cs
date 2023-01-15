
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class script_ColumnsBehavior : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZoneX = -35;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        transform.position += moveSpeed * Time.deltaTime * Vector3.left;

        if (transform.position.x < deadZoneX)
        {
            Debug.Log("Columns destoyed");
            Destroy(gameObject);
        }
    }
}
