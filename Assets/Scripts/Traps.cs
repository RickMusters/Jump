using UnityEngine;
using System.Collections;

public class Traps : MonoBehaviour {
	
	void OnCollisionEnter(Collision col){
		if(col.collider.name == "Player")
		{
			Debug.Log("sup");
			Destroy(col.gameObject);
			Application.LoadLevel(1);
		}
	}
}
