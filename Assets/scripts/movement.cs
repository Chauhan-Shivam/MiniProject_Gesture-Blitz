using UnityEngine;
using System.Collections;

public class CarMovement : MonoBehaviour
{
    [SerializeField] private float speed=15;
	[SerializeField] private float maxspeed=15;
    [SerializeField] private float brakeForce=5;
    [SerializeField] private float sidewaysForce=10f;
    [SerializeField] private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
		StartCoroutine(Delay());
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(5);
    }

    void FixedUpdate ()
	{
		// Add a forward force
        rb.AddForce(0, 0, speed * Time.deltaTime);

        if (Input.GetKey("s"))	// If the player is pressing the "d" key
		{
			// Add a force to the right
			rb.AddForce(0, 0, -brakeForce * Time.deltaTime);
		}
		if (Input.GetKey("d"))	// If the player is pressing the "d" key
		{
			// Add a force to the right
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (Input.GetKey("a"))  // If the player is pressing the "a" key
		{
			// Add a force to the left
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
        if(rb.velocity.magnitude>maxspeed)
        {
			rb.velocity=Vector3.ClampMagnitude(rb.velocity,maxspeed);
		}
	}
}