using UnityEngine;
using System.Collections;

public class Sample : MonoBehaviour {

	private Sdkbox.IAP _iap;
	private Sdkbox.GoogleAnalytics _ga;

	// Use this for initialization
	void Start () {
		_ga = FindObjectOfType<Sdkbox.GoogleAnalytics>();
		if (_ga == null) {
			Debug.Log ("Failed to find GoogleAnalytics instance");
		} else {
			_ga.startSession();
		}
		_iap = FindObjectOfType<Sdkbox.IAP>();
		if (_iap == null) {
			Debug.Log("Failed to find IAP instance");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
