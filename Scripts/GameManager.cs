using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;

	public Text GameWonText;
	//public Text GameWonText;
	public GameObject GameOverPanel;


	public GameObject youWin;
	public float resetDelay;
	void Awake()
	{
		if (instance == null)
			instance = this;
		else if (instance != null)
			Destroy (gameObject);

	}

	public void Win()
	{
		youWin.SetActive (true);
		Time.timeScale = .5f;
		//Invoke ("Reset", resetDelay);
	}

	/*void Reset()
	{
		Time.timeScale = 1.0f;
		Application.LoadLevel (Application.LoadLevel);
		//SceneManager.LoadScene(SceneManager.LoadScene);

	}*/
}
