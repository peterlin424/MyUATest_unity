using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

public class index : MonoBehaviour {

	private AndroidJavaObject activity;
	object[] args = new object[2];

	// Use this for initialization
	void Start () {
	
		/** Bridge_Index Activty */
		AndroidJavaClass jc = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");
		activity = jc.GetStatic<AndroidJavaObject> ("currentActivity");
		activity.Call("StartActivityByUnity", activity);
		args [0] = activity;
		args [1] = "index is called";
		activity.Call("ToastMessage", args);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void ToastMessage(string message){
		args [0] = activity;
		args [1] = message;
		activity.Call("ToastMessage", args);
	}
	void goUnityPage1(){
		SceneManager.LoadScene ("UnityPage1");
	}
	void goUnityPage2(){
		SceneManager.LoadScene ("UnityPage2");
	}
}
