using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject cubePrefab;
    [SerializeField] private float forceRange = 10f;
    [SerializeField] private float spawnIntervalRange = 15f;

    private GameObject cube;
    private Rigidbody cubeRigidbody;
    private float timer;

    void Start()
    {
        timer = Random.Range(5f, spawnIntervalRange);
    }

    void FixedUpdate()
    {
        timer += Time.deltaTime;

        if (timer > spawnIntervalRange)
        {
            cube = Instantiate(cubePrefab, transform.position + (new Vector3(0,1.5f,-7)), Quaternion.identity);
            cubeRigidbody = cube.GetComponent<Rigidbody>();
            cubeRigidbody.AddForce(new Vector3(Random.Range(2*-forceRange, 2*forceRange), Random.Range(-forceRange, forceRange), Random.Range(-forceRange, forceRange+1)), ForceMode.Impulse);

            timer = 0;
            Delete(cube);
        }
    }
    void Delete(GameObject cube)
    {
        Destroy(cube, 10);
    }
}