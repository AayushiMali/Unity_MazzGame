using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class changeScene : MonoBehaviour {

	public void ChangeScene(string sceneName)
	{
		//Application.LoadLevel (sceneName);
		SceneManager.LoadScene(sceneName);
	}
}
