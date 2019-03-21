using UnityEngine;

using UnityEngine.UI;

using System.Collections;

public class OpponentController : MonoBehaviour {
	
	public Rigidbody rb;
	private const float speed = 1.0f;

	private Vector3 center = new Vector3(0.0f, 0.0f, 0.0f);

	void Start()
	{
		rb = GetComponent<Rigidbody>();

		float rand_x = -6.0f + (12.0f*Random.value);
		float rand_z = -6.0f + (12.0f*Random.value);
		rb.position = new Vector3(rand_x, 0.5f, rand_z);
	}

	void FixedUpdate()
	{
		Vector3 movement = center - transform.position;
		movement[1] = 0.0f;
		rb.AddForce(movement * speed);

		if (transform.position[1] <= -5.0f) {
			Kill();
		}
	}

	void Kill()
	{
		rb.isKinematic = true;
		Renderer rend = GetComponent<Renderer>();
		rend.material.SetColor("_Color", new Color(0.25f, 0.0f, 0.0f, 1.0f));
	}

}