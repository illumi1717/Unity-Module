using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneBehavior : MonoBehaviour
{
    public float speed = 2f; 
    public float radius = 5f;

    private Vector3 center; 
    private float angle;
    public GameObject cubePrefab;

    void Start()
    {
        center = Vector3.zero;
    }

    void Update()
    {
        angle += speed * Time.deltaTime; 
        float x = Mathf.Sin(angle) * radius; 
        float y = 0; 
        float z = Mathf.Cos(angle) * radius; 
        transform.position = center + new Vector3(x, y, z);

        if (Input.GetKeyDown("space")) {
            GameObject cube = Instantiate(cubePrefab); 
            cube.AddComponent<Rigidbody>();
            cube.transform.position = center + new Vector3(x, y, z);
        }
    }
}
