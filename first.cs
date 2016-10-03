using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class first : MonoBehaviour 
{
	public GUISkin guiSkin;
	public Texture2D background, LOGO;
	public bool DragWindow = false;
	public string levelToLoadWhenClickedPlay = "";
	public string[] AboutTextLines = new string[0];
	public string input;
	public string s;


	public void Sad()
	{
		//System.Text.StringBuilder s = new System.Text.StringBuilder();
		//s.Append(input).Append("D");
		s = string.Concat(input,"D");
	}

	public void Peaceful()
	{
		s = string.Concat(input,"P");
	}

	public void Angry()
	{
		s = string.Concat(input,"Y");
	}

	public void Stressed()
	{
		s = string.Concat(input,"Z");

	}

	public void Energetic()
	{
		s = string.Concat(input,"E");
	}

	public void AmongPeople()
	{
		s = string.Concat(input,"R");
	}

	public void Curious()
	{
		s = string.Concat(input,"U");
	}

	public void changescene(string scene)
	{
		SceneManager.LoadScene(scene);
	}


	private string clicked = "", Empty = "";
	private Rect WindowRect = new Rect((Screen.width / 2) - 100, Screen.height / 2 - 100, 200, 200);
	private float volume = 1.0f;

	private void OnGUI()
	{
		if (background != null)
			GUI.DrawTexture(new Rect(0,0,Screen.width , Screen.height),background);
		if (LOGO != null && clicked != "about")
			GUI.DrawTexture(new Rect((Screen.width / 2) - 100, 30, 200, 200), LOGO);

		GUI.skin = guiSkin;
		switch (clicked)
		{
		case "":
			WindowRect = GUI.Window (0, WindowRect, menuFunc, "How U Feelin?? \n ");
			break;
		case "Sad":
			changescene ("2ndScene");
			Sad ();break;
		case "Peaceful":
			changescene ("2ndScene");
			Peaceful ();
			break;
		case "Angry":
			changescene ("2ndScene");
			Angry ();
			break;
		case "Stressed":
			changescene ("2ndScene");
			Stressed ();
			break;
		case "Energetic":
			changescene ("2ndScene");
			Energetic ();
			break;
		case "AmongPeople":
			changescene ("2ndScene");
			AmongPeople ();
			break;
		case "Curious":
			changescene ("2ndScene");
			Curious ();
			break;
		}
	}
	private void menuFunc(int id)
	{
		//buttons 
		if (GUILayout.Button("Sad"))
		{
			clicked = "Sad";
		} 
		if (GUILayout.Button("Peaceful"))
		{
			clicked = "Peaceful";
		}
		if (GUILayout.Button("Angry"))
		{
			clicked = "Angry";
		}
		if (GUILayout.Button("Stressed"))
		{
			clicked = "Stressed";
		}
		if (GUILayout.Button("Energetic"))
		{
			clicked = "Energetic";
		} 
		if (GUILayout.Button("AmongPeople"))
		{
			clicked = "AmongPeople";
		} 
		if (GUILayout.Button("Curious"))
		{
			clicked = "Curious";
		} 
		if (DragWindow)
			GUI.DragWindow(new Rect(0, 0, Screen.width, Screen.height));
	}
	private void Update()
	{
		if (clicked == "Sad" && Input.GetKey (KeyCode.Escape))
			clicked = "";
		if (clicked == "Peaceful" && Input.GetKey (KeyCode.Escape))
			clicked = "";
		if (clicked == "Angry" && Input.GetKey (KeyCode.Escape))
			clicked = "";
		if (clicked == "Stressed" && Input.GetKey (KeyCode.Escape))
			clicked = "";
		if (clicked == "Energetic" && Input.GetKey (KeyCode.Escape))
			clicked = "";
		if (clicked == "AmongPeople" && Input.GetKey (KeyCode.Escape))
			clicked = "";
		if (clicked == "Curious" && Input.GetKey (KeyCode.Escape))
			clicked = "";
	}
}