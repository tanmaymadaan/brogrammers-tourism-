using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class nextscene : MonoBehaviour
{
	public void NextScene(string scene)
	{
		SceneManager.LoadScene("Scene4");
	}
	//NextScene("Scene");
}
