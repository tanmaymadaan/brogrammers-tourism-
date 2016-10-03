using UnityEngine;
using System.Collections;
using System.Text.StringBuilder;

public class menu : MonoBehaviour 
{
	public GUISkin guiSkin;
	public Texture2D background, LOGO;
	public bool DragWindow = false;
	public string levelToLoadWhenClickedPlay = "";
	public string[] AboutTextLines = new string[0];
	public string input;

	System.Text.StringBuilder s = new System.Text.StringBuilder();
	s.Append(input).Append("D");

	public void Sad()
	{
		System.Text.StringBuilder s = new System.Text.StringBuilder();
		s.Append(input).Append("D");
	}

	public void Peaceful()
	{
		System.Text.StringBuilder s = new System.Text.StringBuilder();
		s.Append(input).Append("D");
	}

	public void Angry()
	{
		System.Text.StringBuilder s = new System.Text.StringBuilder();
		s.Append(input).Append("D");
	}

	public void Stressed()
	{
		System.Text.StringBuilder s = new System.Text.StringBuilder();
		s.Append(input).Append("D");

	}

	public void Energetic()
	{
		System.Text.StringBuilder s = new System.Text.StringBuilder();
		s.Append(input).Append("D");
	}

	public void AmongPeople()
	{
		System.Text.StringBuilder s = new System.Text.StringBuilder();
		s.Append(input).Append("D");
	}

	public void mood7()
	{
		System.Text.StringBuilder s = new System.Text.StringBuilder();
		s.Append(input).Append("D");
	}




	private string clicked = "", MessageDisplayOnAbout = "mood \n ";
	private Rect WindowRect = new Rect((Screen.width / 2) - 100, Screen.height / 2 - 100, 200, 200);
	private float volume = 1.0f;

	private void Start()
	{
		for (int x = 0; x < AboutTextLines.Length;x++ )
		{
			MessageDisplayOnAbout += AboutTextLines[x] + " \n ";
		}
	}

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
			WindowRect = GUI.Window (0, WindowRect, menuFunc, "Main Menu");
			break;
		case "Sad":
			GUI.Box(new Rect (0,0,Screen.width,Screen.height), MessageDisplayOnAbout);
			Sad ();break;
		case "Peaceful":
			GUI.Box (new Rect (0, 0, Screen.width, Screen.height), MessageDisplayOnAbout);
			Peaceful ();
			break;
		case "Angry":
			GUI.Box(new Rect (0,0,Screen.width,Screen.height), MessageDisplayOnAbout);
			Angry ();
			break;
		case "Stressed":
			GUI.Box(new Rect (0,0,Screen.width,Screen.height), MessageDisplayOnAbout);
			Stressed ();
			break;
		case "Energetic":
			GUI.Box(new Rect (0,0,Screen.width,Screen.height), MessageDisplayOnAbout);
			Energetic ();
			break;
		case "AmongPeople":
			GUI.Box(new Rect (0,0,Screen.width,Screen.height), MessageDisplayOnAbout);
			AmongPeople ();
			break;
		case "mood7":
			GUI.Box(new Rect (0,0,Screen.width,Screen.height), MessageDisplayOnAbout);
			mood7 ();
			break;
		default:GUI.Box(new Rect (0,0,Screen.width,Screen.height), MessageDisplayOnAbout);
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
		if (GUILayout.Button("mood7"))
		{
			clicked = "mood7";
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
		if (clicked == "mood7" && Input.GetKey (KeyCode.Escape))
			clicked = "";
	}
}
