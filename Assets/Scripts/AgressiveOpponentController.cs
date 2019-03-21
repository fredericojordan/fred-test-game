using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AgressiveOpponentController : MonoBehaviour {

	public Rigidbody rb;
	public GameObject player;

	private const float speed = 1.0f;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	    player = GameObject.Find("Player");

		float rand_x = -6.0f + (12.0f*Random.value);
		float rand_z = -6.0f + (12.0f*Random.value);
		rb.position = new Vector3(rand_x, 0.5f, rand_z);
	}

	void FixedUpdate()
	{
		Vector3 movement = player.transform.position - transform.position;
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
		rend.material.SetColor("_Color", new Color(0.5f, 0.5f, 0.0f, 1.0f));
	}

}