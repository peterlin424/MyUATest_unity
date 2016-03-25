using UnityEngine;
using System.Collections;

public class page2 : MonoBehaviour {

	private string pageName = "page2";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ButtonClickEvent(string bt_name){
		Debug.Log (pageName + " : " + bt_name);
		switch (bt_name) {
		case "bt_back":
			break;
		case "bt_finish":
			break;	
		}
	}
}
