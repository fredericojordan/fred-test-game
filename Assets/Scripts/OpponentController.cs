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
	}

    void FixedUpdate()
	{
		Vector3 movement = center - transform.position;
		rb.AddForce(movement * speed);

		if (transform.position[1] <= -5.0F) {
		    gameObject.SetActive(false);
		}
	}

}