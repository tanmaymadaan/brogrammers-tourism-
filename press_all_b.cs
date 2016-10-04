using UnityEngine;
using System.Collections;

public class press_all_b : MonoBehaviour
{
	//public static string input;
	//string input;
	public static string inputOut(){
		press_all p = new press_all ();
		return press_all.retinput ();

	}

	static string input=inputOut();

	public static string retInput(){
		return input;
	}

	int a= 1,b=1,c=1,d=1,e=1,f=1;
	public void bandf(){
		if (a==1) {
			input += "B";
			a = 0;
		} else {
			for (int i = 0; i < input.Length; i++) {
				if (input [i] == 'B') {
					input = input.Remove (i, 1);
					break;
				}					
			}
			a = 1;
		} 
		Debug.Log(input);
	}

	public void adv(){
		if (b==1) {
			input += "A";
			b = 0;
		} else {
			for (int i = 0; i < input.Length; i++) {
				if (input [i] == 'A') {
					input = input.Remove (i, 1);
					break;
				}					
			}
			b = 1;
		} 
		Debug.Log(input);
	}
	public void food(){
		if (c==1) {
			input += "H";
			c = 0;
		} else {
			for (int i = 0; i < input.Length; i++) {
				if (input [i] == 'H') {
					input = input.Remove (i, 1);
					break;
				}					
			}
			c = 1;
		} 
		Debug.Log(input);
	}
	public void culture(){
		if (f==1) {
			input += "C";
			f = 0;
		} else {
			for (int i = 0; i < input.Length; i++) {
				if (input [i] == 'C') {
					input = input.Remove (i, 1);
					break;
				}					
			}
			f = 1;
		} 
		Debug.Log(input);
	}
	public void natwon(){
		if (d==1) {
			input += "L";
			d = 0;
		} else {
			for (int i = 0; i < input.Length; i++) {
				if (input [i] == 'L') {
					input = input.Remove (i, 1);
					break;
				}					
			}
			d = 1;
		} 
		Debug.Log(input);
	}
	public void shoping(){
		if (e==1) {
			input += "Z";
			e = 0;
		} else {
			for (int i = 0; i < input.Length; i++) {
				if (input [i] == 'Z') {
					input = input.Remove (i, 1);
					break;
				}					
			}
			e = 1;
		} 
		Debug.Log(input);
	}
	public void feell(){
		if (e==1) {
			input += "O";
			e = 0;
		} else {
			for (int i = 0; i < input.Length; i++) {
				if (input [i] == 'O') {
					input = input.Remove (i, 1);
					break;
				}					
			}
			e = 1;
		} 
		Debug.Log(input);
	}
}


