using UnityEngine;
using System.Collections;

public class EverythingIsFine : MonoBehaviour {

	public GameObject Cam;
	public GameObject Oculus;
	float toggleTimer;
	//Christopher Burst created this!
	// Use this for initialization
	void Start () {
		//Cam.SetActive (true);
		Oculus.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.LogWarning ("EVERYTHING IS FINE!");
		toggleTimer += Time.deltaTime;
		/*if (Input.GetKey (KeyCode.Z)&&toggleTimer>.5f) {
			Cam.SetActive (!Cam.activeSelf);
			Oculus.SetActive (!Oculus.activeSelf);
			Debug.Log ("OCULUS IS "+Oculus.activeSelf);
			toggleTimer=0;
		}*/
		if (Input.GetKey (KeyCode.Escape)) {
			//Cam.SetActive (true);
			//Oculus.SetActive (false);
			Application.Quit ();
		}
	}
}
