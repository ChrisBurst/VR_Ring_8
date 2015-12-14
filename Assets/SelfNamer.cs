using UnityEngine;
using System.Collections;

public class SelfNamer : MonoBehaviour {

	GameObject search;
	bool invalid=false;

	// Use this for initialization
	void Awake () {
		int x = 0;
		search = GameObject.Find ("OverallController");//Fills the variable so that it is not null and loop will start
		while (search!=null) {
			x++;
			search = GameObject.Find ("Light" + x);
			if(search!=null && this.transform.position == search.transform.position){ //New system creates unnessesary duplicates. this destroys duplicates
				Destroy(gameObject);
				invalid=true;
			}
		}
		if(!invalid)
			this.name = "Light" + x;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
