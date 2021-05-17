using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToBlueScene1 : MonoBehaviour {
	public GameObject player1;
	public Transform target1;

	void OnTriggerEnter(Collider other)
	{
		//Trigger win function
		if (other.tag == "teleportx") {
			player1 = other.transform.gameObject;
			player1.transform.position = target1.transform.position;
			//this.transform.position = target1.position;
		}

	}
}
