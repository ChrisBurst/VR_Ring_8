using UnityEngine;
using System.Collections;

public class Colors : MonoBehaviour {

	GameObject Light1;
	GameObject Board1;
	GameObject Light2;
	GameObject Board2;
	GameObject Light3;
	GameObject Board3;
	GameObject Light4;
	GameObject Board4;
	GameObject Light5;
	GameObject Board5;
	GameObject Light6;
	GameObject Board6;
	GameObject Light7;
	GameObject Board7;
	GameObject Light8;
	GameObject Board8;
	GameObject OverallController;
	public Material Illuminated;
	public Material Dark;


	// Use this for initialization
	void Start () {
		OverallController = GameObject.Find ("OverallController");
		Light1 = GameObject.Find ("Light1");
		Board1 = GameObject.Find ("Board1");
		Light2 = GameObject.Find ("Light2");
		Board2 = GameObject.Find ("Board2");
		Light3 = GameObject.Find ("Light3");
		Board3 = GameObject.Find ("Board3");
		Light4 = GameObject.Find ("Light4");
		Board4 = GameObject.Find ("Board4");
		Light5 = GameObject.Find ("Light5");
		Board5 = GameObject.Find ("Board5");
		Light6 = GameObject.Find ("Light6");
		Board6 = GameObject.Find ("Board6");
		Light7 = GameObject.Find ("Light7");
		Board7 = GameObject.Find ("Board7");
		Light8 = GameObject.Find ("Light8");
		Board8 = GameObject.Find ("Board8");
	}
	
	// Update is called once per frame
	//Changelog: LightEmitter no longer wanted.
	void Update () {
		if (Input.GetKey (KeyCode.Alpha1)) {
			Light1.renderer.material = Illuminated;
			//Light1.light.enabled = true;
			Light1.audio.Play ();
			OverallController.SendMessage ("LightOn", "Light1");
		}
		if (Input.GetKey (KeyCode.Alpha2)) {
			Light2.renderer.material = Illuminated;
			//Light2.light.enabled = true;
			Light2.audio.Play ();
			OverallController.SendMessage ("LightOn", "Light2");
		}
		if (Input.GetKey (KeyCode.Alpha3)) {
			Light3.renderer.material = Illuminated;
			//Light3.light.enabled = true;
			Light3.audio.Play ();
			OverallController.SendMessage ("LightOn", "Light3");
		}
		if (Input.GetKey (KeyCode.Alpha4)) {
			Light4.renderer.material = Illuminated;
			//Light4.light.enabled = true;
			Light4.audio.Play ();
			OverallController.SendMessage ("LightOn", "Light4");
		}
		if (Input.GetKey (KeyCode.Alpha5)) {
			Light5.renderer.material = Illuminated;
			//Light5.light.enabled = true;
			Light5.audio.Play ();
			OverallController.SendMessage ("LightOn", "Light5");
		}
		if (Input.GetKey (KeyCode.Alpha6)) {
			Light6.renderer.material = Illuminated;
			//Light6.light.enabled = true;
			Light6.audio.Play ();
			OverallController.SendMessage ("LightOn", "Light6");
		}
		if (Input.GetKey (KeyCode.Alpha7)) {
			Light7.renderer.material = Illuminated;
			//Light7.light.enabled = true;
			Light7.audio.Play ();
			OverallController.SendMessage ("LightOn", "Light7");
		}
		if (Input.GetKey (KeyCode.Alpha8)) {
			Light8.renderer.material = Illuminated;
			//Light8.light.enabled = true;
			Light8.audio.Play ();
			OverallController.SendMessage ("LightOn", "Light8");
		}
	}

	public void CastAt(string Name){
		if (Name == "Board1") {
			Light1.renderer.material = Dark;
			//Light1.light.enabled = false;
		}
		if (Name == "Board2") {
			Light2.renderer.material = Dark;
			//Light2.light.enabled = false;
		}
		if (Name == "Board3") {
			Light3.renderer.material = Dark;
			//Light3.light.enabled = false;
		}
		if (Name == "Board4") {
			Light4.renderer.material = Dark;
			//Light4.light.enabled = false;
		}
		if (Name == "Board5") {
			Light5.renderer.material = Dark;
			//Light5.light.enabled = false;
		}
		if (Name == "Board6") {
			Light6.renderer.material = Dark;
			//Light6.light.enabled = false;
		}
		if (Name == "Board7") {
			Light7.renderer.material = Dark;
			//Light7.light.enabled = false;
		}
		if (Name == "Board8") {
			Light8.renderer.material = Dark;
			//Light8.light.enabled = false;
		}
	}
}
