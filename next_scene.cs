using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class next_scene : MonoBehaviour
{
	public void NextScene(string scene)
	{
		SceneManager.LoadScene("Scene3");
	}
	//NextScene("Scene3");
}
