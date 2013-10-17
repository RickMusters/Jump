using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	private bool jumped = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.S))
		{
			rigidbody.AddRelativeForce(new Vector3(0, -1, 0));	
		}
		
		if (Input.GetKey(KeyCode.A))
		{
			rigidbody.transform.Translate(new Vector3(-0.2f, 0, 0));
		}
		if (Input.GetKey(KeyCode.D))
		{
			rigidbody.transform.Translate(new Vector3(0.2f, 0, 0));
		}
		
		if (Input.GetKey(KeyCode.W))
		{
			if(jumped == false)
			{
				jumped = true;
				rigidbody.AddForce(new Vector3(10,0,0));
			}
		}
	}
	void OnCollisionEnter(Collision col)
	{
		if(col.collider.name == "Platforms")
		{
			jumped = false;
		}
	}
}