using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class customText : MonoBehaviour {

	public Text myText;
	int fps = 5;
	int i = 0;
	int maxDisplayCount = 5;
	List<string> stringList = new List<string>();

	// Use this for initialization
	void Start () {
		myText = GameObject.Find ("custom_text").GetComponent<Text> ();
		myText.text = "test";

		for (int k = 0; k < maxDisplayCount; k++) {
			stringList.Add (generateRandomString ());
		}
	}

	// Update is called once per frame
	void Update () {
		++i;
		if (i == fps){
			stringList.RemoveAt (0);
			stringList.Add (generateRandomString ());
			string displayString = "Receiving Data...";
			foreach(string str in stringList) {
				displayString = displayString + "\n" + str;
			}
			myText.text = displayString;
			i = 0;
		}
	}

	string generateRandomString() {
		string x = Random.Range(-100,100).ToString();
		string y = Random.Range(-100,100).ToString();
		string z = Random.Range(-100,100).ToString();
		return "(x,y,z) = (" + x + ", " + y + " ," + z + " )";
	}
}
