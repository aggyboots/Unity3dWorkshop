using UnityEngine;
using System.Collections;

public class YourComponent : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Start");
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.LogFormat ("Time={0}", Time.time);
	
	}
}
