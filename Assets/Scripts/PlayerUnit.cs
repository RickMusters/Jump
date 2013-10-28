using UnityEngine;
using System.Collections;

public class PlayerUnit : Unit
{
	private bool firepress = false;

	// Use this for initialization
	public override void Start ()
	{
		base.Start ();
	}
	
	// Update is called once per frame
	public override void Update ()
	{
		
		//movement
		
		move = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
		
		move.Normalize();
		
		if(Input.GetKeyDown(KeyCode.W)&& control.isGrounded)
		{
			jump = true;	
		}
		
		running = Input.GetKey(KeyCode.LeftShift);
		
		base.Update ();
		
		//shoot
		if (Input.GetAxis("Fire1") == 1)
		{
			if(firepress == false)
			{
				GameObject bullet =  Instantiate(Resources.Load("Bullet"),transform.position,transform.rotation) as GameObject;
				firepress = true;
			}
		}
		else
		{
			firepress = false;
		}
	}
}
