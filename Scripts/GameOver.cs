using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

	public GameObject gameOverPanel1;

	//public float resetDelay;

	/*void onTriggerEnter(Collider other)
	{
		//Trigger win function
		//winningMsg.instance.Win();
		gameOverPanel.SetActive(true);
		//Time.timeScale = .5f;
	}*/

	void OnCollisionEnter(Collision col)
	{
		gameOverPanel1.SetActive (true);
	}

}
