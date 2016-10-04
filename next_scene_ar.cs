using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class next_scene_ar : MonoBehaviour
{
	public void NextScene(string scene)
	{
		SceneManager.LoadScene("scene_ar");
	}
	//NextScene("Scene");
}
