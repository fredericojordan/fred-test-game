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

		if (transform.position[1] <= -5.0f) {
			Kill();
		}
	}

	void Kill()
	{
		killText.text = "U DED MA FREND";
		rb.isKinematic = true;
		Renderer rend = GetComponent<Renderer>();
		rend.material.SetColor("_Color", new Color(0.5f, 0.5f, 0.5f, 1.0f));
	}
}