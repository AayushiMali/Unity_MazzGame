using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToYellow : MonoBehaviour {

	//public GameObject player;
	public Transform target;

	void OnTriggerEnter(Collider other)
	{
		//Trigger win function
		if (other.tag == "teleportx2") {
			//player = other.transform.gameObject;
			////player = other.transform.parent.gameObject.transform.parent.gameObject;
			//player.transform.position = target.transform.position;
			this.transform.position = target.position;
		}

	}
}
