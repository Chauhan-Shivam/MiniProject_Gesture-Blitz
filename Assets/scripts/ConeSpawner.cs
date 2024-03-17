using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject conePrefab;
    [SerializeField] private float forceRange = 10f;
    [SerializeField] private float spawnIntervalRange = 15f;

    private GameObject cone;
    private Rigidbody coneRigidbody;
    private float timer;

    void Start()
    {
        timer = Random.Range(5f, spawnIntervalRange);
		StartCoroutine(Delay());
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(5);
    }

    void FixedUpdate()
    {
        timer += Time.deltaTime;

        if (timer > spawnIntervalRange)
        {
            cone = Instantiate(conePrefab, transform.position + (new Vector3(0,1.5f,-7)), Quaternion.identity);
            coneRigidbody = cone.GetComponent<Rigidbody>();
            coneRigidbody.AddForce(new Vector3(Random.Range(2*-forceRange, 2*forceRange), Random.Range(-forceRange, forceRange), Random.Range(-forceRange, forceRange+1)), ForceMode.Impulse);

            timer = 0;
            Delete(cone);
        }
    }
    void Delete(GameObject cone)
    {
        Destroy(cone, 10);
    }
}