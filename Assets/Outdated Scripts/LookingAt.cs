using UnityEngine;
using System.Collections;

public class LookingAt : MonoBehaviour {

	RaycastHit hit;
	GameObject GameController;

	// Use this for initialization
	void Start () {
		GameController = GameObject.Find ("OverallController");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.DrawLine(transform.position, Vector3.forward*5f, Color.red);
		if (Physics.Raycast (transform.position, Vector3.forward, out hit))
			GameController.SendMessage ("CastAt", hit.transform.name);
	}
}
