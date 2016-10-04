using UnityEngine;
using System.Collections;

public class press_all : MonoBehaviour
{
	
	public static string input = ""; 
	int a= 1,b=1,c=1,d=1,e=1,f=1;
	public void sad(){
		if (a==1) {
			input += "D";
			a = 0;
		} else {
			for (int i = 0; i < input.Length; i++) {
				if (input [i] == 'D') {
					input = input.Remove (i, 1);
					break;
				}					
			}
			a = 1;
		} 
		Debug.Log(input);
	}

	public void energetic(){
		if (b==1) {
			input += "E";
			b = 0;
		} else {
			for (int i = 0; i < input.Length; i++) {
				if (input [i] == 'E') {
					input = input.Remove (i, 1);
					break;
				}					
			}
			b = 1;
		} 
		Debug.Log(input);
	}
	public void angry(){
		if (c==1) {
			input += "Y";
			c = 0;
		} else {
			for (int i = 0; i < input.Length; i++) {
				if (input [i] == 'Y') {
					input = input.Remove (i, 1);
					break;
				}					
			}
			c = 1;
		} 
		Debug.Log(input);
	}
	public void peaceful(){
		if (f==1) {
			input += "P";
			f = 0;
		} else {
			for (int i = 0; i < input.Length; i++) {
				if (input [i] == 'P') {
					input = input.Remove (i, 1);
					break;
				}					
			}
			f = 1;
		} 
		Debug.Log(input);
	}
	public void lonely(){
		if (d==1) {
			input += "R";
			d = 0;
		} else {
			for (int i = 0; i < input.Length; i++) {
				if (input [i] == 'R') {
					input = input.Remove (i, 1);
					break;
				}					
			}
			d = 1;
		} 
		Debug.Log(input);
	}
	public void curious(){
		if (e==1) {
			input += "U";
			e = 0;
		} else {
			for (int i = 0; i < input.Length; i++) {
				if (input [i] == 'U') {
					input = input.Remove (i, 1);
					break;
				}					
			}
			e = 1;
		} 
		Debug.Log(input);
	}
}

