using UnityEngine;
using System.Collections;


public class third : MonoBehaviour 
{
	public GUISkin guiSkin;
	public Texture2D background, LOGO;
	public bool DragWindow = false;
	public string levelToLoadWhenClickedPlay = "";
	public string[] AboutTextLines = new string[0];
	public string input;
	public string s;


	public void ExploringCulture()
	{
		//System.Text.StringBuilder s = new System.Text.StringBuilder();
		//s.Append(input).Append("D");
		s = string.Concat(input,"C");
	}

	public void BooksnFilms()
	{
		s = string.Concat(input,"B");
	}

	public void Food()
	{
		s = string.Concat(input,"H");
	}

	public void Shopping()
	{
		s = string.Concat(input,"F");

	}

	public void NaturalWonders()
	{
		s = string.Concat(input,"L");
	}

	public void Spiritual()
	{
		s = string.Concat(input,"S");
	}

	public void TryYourLuck()
	{
		s = string.Concat(input,"O");
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
			WindowRect = GUI.Window (0, WindowRect, menuFunc, "wat u wanna do?? \n ");
			break;
		case "ExploringCulture":
			GUI.Box(new Rect (0,0,Screen.width,Screen.height),Empty);
			ExploringCulture ();break;
		case "BooksnFilms":
			GUI.Box (new Rect (0, 0, Screen.width, Screen.height),Empty);
			BooksnFilms ();
			break;
		case "Food":
			GUI.Box(new Rect (0,0,Screen.width,Screen.height),Empty);
			Food ();
			break;
		case "Shopping":
			GUI.Box(new Rect (0,0,Screen.width,Screen.height),Empty);
			Shopping ();
			break;
		case "NaturalWonders":
			GUI.Box(new Rect (0,0,Screen.width,Screen.height),Empty);
			NaturalWonders ();
			break;
		case "Spiritual":
			GUI.Box(new Rect (0,0,Screen.width,Screen.height),Empty);
			Spiritual ();
			break;
		case "TryYourLuck":
			GUI.Box(new Rect (0,0,Screen.width,Screen.height),Empty);
			TryYourLuck ();
			break;
		}
	}
	private void menuFunc(int id)
	{
		//buttons 
		if (GUILayout.Button("ExploringCulture"))
		{
			clicked = "ExploringCulture";
		} 
		if (GUILayout.Button("BooksnFilms"))
		{
			clicked = "BooksnFilms";
		}
		if (GUILayout.Button("Food"))
		{
			clicked = "Food";
		}
		if (GUILayout.Button ("Shopping")) 
		{
			clicked = "Shopping";
		}
		if (GUILayout.Button("NaturalWonders"))
		{
			clicked = "NaturalWonders";
		} 
		if (GUILayout.Button("Spiritual"))
		{
			clicked = "Spiritual";
		} 
		if (GUILayout.Button("TryYourLuck"))
		{
			clicked = "TryYourLuck";
		} 
		if (DragWindow)
			GUI.DragWindow(new Rect(0, 0, Screen.width, Screen.height));
	}
	private void Update()
	{
		if (clicked == "ExploringCulture" && Input.GetKey (KeyCode.Escape))
			clicked = "";
		if (clicked == "BooksnFilms" && Input.GetKey (KeyCode.Escape))
			clicked = "";
		if (clicked == "Food" && Input.GetKey (KeyCode.Escape))
			clicked = "";
		if (clicked == "Shopping" && Input.GetKey (KeyCode.Escape))
			clicked = "";
		if (clicked == "NaturalWonders" && Input.GetKey (KeyCode.Escape))
			clicked = "";
		if (clicked == "Spiritual" && Input.GetKey (KeyCode.Escape))
			clicked = "";
		if (clicked == "TryYourLuck" && Input.GetKey (KeyCode.Escape))
			clicked = "";
	}
}