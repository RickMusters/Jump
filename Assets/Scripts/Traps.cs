using UnityEngine;
using System.Collections;

public class Traps : MonoBehaviour {
	
	void OnCollisionEnter(Collision col){
		if(col.collider.name == "Player")
		{
			Destroy(col.gameObject);
		}
	}
}
