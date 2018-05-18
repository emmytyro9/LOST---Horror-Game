using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMusic : MonoBehaviour {

	public void Awake() {
		DontDestroyOnLoad(transform.gameObject);
	}
}
