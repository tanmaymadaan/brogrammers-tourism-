using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Sad : MonoBehaviour {
	public void SadString(){
		string input1="";
		input1=input1+"D";
	}
	private Button mybutton=null;
	void Start() {
		mybutton.onClick.AddListener (() => {
			SadString ();
		});
		mybutton.interactable = false;
	}


}
