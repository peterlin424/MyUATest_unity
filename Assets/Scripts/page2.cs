using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class page2 : MonoBehaviour {

	private AndroidJavaObject activity;
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
			SceneManager.LoadScene ("index");

			/** Bridge_Index Activty */
			AndroidJavaClass jc = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");
			activity = jc.GetStatic<AndroidJavaObject> ("currentActivity");
			activity.Call("StartActivityByUnity", activity);
			break;
		case "bt_finish":
			break;	
		}
	}
}
