using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Rigidbody rb;
	private Vector3 offset;

	private float speed_offset_factor = 0.5f;
	private float damping_factor = 10.0f;

	void Start ()
	{
		rb = player.GetComponent<Rigidbody>();
		offset = transform.position - player.transform.position;
	}

	void LateUpdate ()
	{
	    Vector3 desired_position = player.transform.position + offset + (rb.velocity * speed_offset_factor);
	    Vector3 delta_position = desired_position - transform.position;
	    
		transform.position += delta_position * (1.0f/damping_factor);
	}
}