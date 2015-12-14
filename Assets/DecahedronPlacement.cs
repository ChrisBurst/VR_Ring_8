using UnityEngine;
using System.Collections;

public class DecahedronPlacement : MonoBehaviour {

	public GameObject target;
	GameObject putHere;
	GameObject PositionY;
	GameObject PositionX;

	// Use this for initialization
	void Start () {
		PositionY = GameObject.Find ("PositionerY");
		PositionX = GameObject.Find ("PositionerX");
		putHere = GameObject.Find ("Placer");

		//Start position
		PositionX.transform.Rotate (-83f, 0f, 0f);
		//begin
		Instantiate (target, putHere.transform.position, putHere.transform.rotation);
		PositionX.transform.Rotate (72f, 0f, 0f);
		PositionX.transform.Rotate (0f, -60f, 0f);
		Instantiate (target, putHere.transform.position, putHere.transform.rotation);
		PositionX.transform.Rotate (72f, 0f, 0f);
		PositionX.transform.Rotate (0f, 60f, 0f);
		Instantiate (target, putHere.transform.position, putHere.transform.rotation);
		PositionX.transform.Rotate (72f, 0f, 0f);
		PositionX.transform.Rotate (0f, 60f, 0f);
		Instantiate (target, putHere.transform.position, putHere.transform.rotation);
		PositionX.transform.Rotate (72f, 0f, 0f);
		PositionX.transform.Rotate (0f, 60f, 0f);
		Instantiate (target, putHere.transform.position, putHere.transform.rotation);
		PositionX.transform.Rotate (72f, 0f, 0f);
		PositionX.transform.Rotate (0f, -60f, 0f);
		Instantiate (target, putHere.transform.position, putHere.transform.rotation);
		PositionX.transform.Rotate (72f, 0f, 0f);
		PositionX.transform.Rotate (0f, -60f, 0f);
		Instantiate (target, putHere.transform.position, putHere.transform.rotation);
		PositionX.transform.Rotate (72f, 0f, 0f);
		PositionX.transform.Rotate (0f, -60f, 0f);
		Instantiate (target, putHere.transform.position, putHere.transform.rotation);
		PositionX.transform.Rotate (72f, 0f, 0f);
		PositionX.transform.Rotate (0f, 60f, 0f);
		Instantiate (target, putHere.transform.position, putHere.transform.rotation);
		PositionX.transform.Rotate (72f, 0f, 0f);
		PositionX.transform.Rotate (0f, -60f, 0f);
		Instantiate (target, putHere.transform.position, putHere.transform.rotation);
		PositionX.transform.Rotate (72f, 0f, 0f);
		PositionX.transform.Rotate (0f, 60f, 0f);
		Instantiate (target, putHere.transform.position, putHere.transform.rotation);
		PositionX.transform.Rotate (72f, 0f, 0f);
		PositionX.transform.Rotate (0f, -60f, 0f);
		Instantiate (target, putHere.transform.position, putHere.transform.rotation);
		PositionX.transform.Rotate (72f, 0f, 0f);
		PositionX.transform.Rotate (0f, 60f, 0f);
		Instantiate (target, putHere.transform.position, putHere.transform.rotation);
		PositionX.transform.Rotate (72f, 0f, 0f);
		PositionX.transform.Rotate (0f, 60f, 0f);
		Instantiate (target, putHere.transform.position, putHere.transform.rotation);
		PositionX.transform.Rotate (72f, 0f, 0f);
		PositionX.transform.Rotate (0f, 60f, 0f);
		Instantiate (target, putHere.transform.position, putHere.transform.rotation);
		PositionX.transform.Rotate (72f, 0f, 0f);
		PositionX.transform.Rotate (0f, -60f, 0f);
		Instantiate (target, putHere.transform.position, putHere.transform.rotation);
		PositionX.transform.Rotate (72f, 0f, 0f);
		PositionX.transform.Rotate (0f, -60f, 0f);
		Instantiate (target, putHere.transform.position, putHere.transform.rotation);
		PositionX.transform.Rotate (72f, 0f, 0f);
		PositionX.transform.Rotate (0f, -60f, 0f);
		Instantiate (target, putHere.transform.position, putHere.transform.rotation);
		PositionX.transform.Rotate (72f, 0f, 0f);
		PositionX.transform.Rotate (0f, 60f, 0f);
		Instantiate (target, putHere.transform.position, putHere.transform.rotation);
		PositionX.transform.Rotate (72f, 0f, 0f);
		PositionX.transform.Rotate (0f, -60f, 0f);
		Instantiate (target, putHere.transform.position, putHere.transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
