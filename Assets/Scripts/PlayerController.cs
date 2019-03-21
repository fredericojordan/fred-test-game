using UnityEngine;

using UnityEngine.UI;

using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public float speed;
	public Rigidbody rb;
	public Text killText;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		killText.text = "";
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		rb.AddForce(movement * speed);

		if (transform.position[1] <= -3.0f) {
		    Kill();
		}
	}

	void Kill()
	{
        rb.isKinematic = true;
		killText.text = "U DED MA FREND";
	}
}