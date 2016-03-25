using UnityEngine;
using System.Collections;

public class page1 : MonoBehaviour {

	private string pageName = "page1";

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
		case "bt_next":
			break;	
		}
	}
}
