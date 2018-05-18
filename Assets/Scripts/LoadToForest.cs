using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadToForest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LoadScene() {
//		SetCameraPositionOnStart.SetNextLocation(new Vector3(0,0.6,0));
		SceneManager.LoadScene("SampleScene");
		
	}
}
