using UnityEngine;
using System.Collections;

public class TriggerBox : MonoBehaviour {

	GameObject GameController;

	// Use this for initialization
	void Start () {
		GameController = GameObject.Find ("OverallController");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay(Collider other){
		GameController.SendMessage ("CastAt", this.name);
		//Debug.Log ("Hit " + other.name);
	}
}
