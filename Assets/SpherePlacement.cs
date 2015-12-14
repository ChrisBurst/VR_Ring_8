using UnityEngine;
using System.Collections;

public class SpherePlacement : MonoBehaviour {

	public GameObject target;
	GameObject putHere;
	GameObject PositionY;
	GameObject PositionX;

	// Use this for initialization
	void Start () {
		PositionY = GameObject.Find ("PositionerY");
		PositionX = GameObject.Find ("PositionerX");
		putHere = GameObject.Find ("Placer");
		PositionX.transform.Rotate (-80f, 0f, 0f);
		int instances = 5;
		int x = 0;
		int y = 0;

		//Places lights in every row of a sphere, doubling the number per row every other row
		while (y<17) {
			if(y==8)
				instances=instances/2;
			while (x<instances && y!=8) { //Does not go when y=8 because that line always acts strangely
				Instantiate (target, putHere.transform.position, putHere.transform.rotation);
				PositionY.transform.Rotate (0f, 360/instances, 0f);
				x++;
			}
			//Debug.Log(y+" "+instances);
			PositionX.transform.Rotate (10f, 0f, 0f);
			y++;
			x = 0;
			if(y==8)
				instances=instances*2;
			if(y<=8 && y%2==0)
				instances=instances*2;
			else if(y>8 && y%2==1)
				instances=instances/2;

		}
		//Debug.Break ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
