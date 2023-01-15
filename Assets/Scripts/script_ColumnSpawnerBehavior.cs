
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class script_ColumnSpawnerBehavior : MonoBehaviour
{
    public GameObject obj_Columns;

    public float respawnTime = 2;
    private float timer = 0;

    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        //spawnColumns();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < respawnTime) {
            timer += Time.deltaTime;
        } 
        else {
            spawnColumns();
            timer = 0;
        }
    }

    void spawnColumns()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(obj_Columns, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
