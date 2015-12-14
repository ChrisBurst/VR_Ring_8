using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;

public class BeginTest : MonoBehaviour {

	public float timer=0;
	float timeBetween=0;
	float delay=0;
	int arrayPosition=0;
	bool Started=false;
	bool isOn;
	GameObject ThisLight;
	public string[] list;
	public Material ON;
	public Material OFF;
	public Material CORRECT;
	public GameObject StartPrompt;
	public GameObject EndPrompt;
	public GameObject Dodeca;

	// Use this for initialization
	void Start () {
		StartPrompt.SetActive (true);
		EndPrompt.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown) {
			Started = true;
			StartPrompt.SetActive(false);
		}
		if (Started) {
			timer += Time.deltaTime;
			timeBetween += Time.deltaTime;
			delay += Time.deltaTime;
			if(delay>=1f && !isOn){
				TurnOn(list[arrayPosition]);
				isOn=true;
				timeBetween=0;
				Output("Light "+list[arrayPosition]+" turned on");
			}
			if(ThisLight!=null){
				if( ThisLight.GetComponent<IsBeingLookedAt>().isLookedAt && Input.anyKeyDown){
					TurnOff();
				 	Output("Participant Spotted Light "+list[arrayPosition]);
				 	arrayPosition++;
					if(arrayPosition>=list.Length){
						EndPrompt.SetActive(true);
					}else{
			 			delay=0;
						isOn=false;
					}
				}
			}

		}

			/*if delay>=1
			 * get first array value
			 * turn on light represented by that value
			 * save time and light value
			 */
	
	}

	//Light Manager
	public void TurnOn(string number){
		float num = float.Parse (number);
		if (Dodeca.activeSelf) {
			while (num>20) {
				num -= 20;
			}
		} else {
			while (num>60) {
				num -= 60;
			}
		}
		ThisLight = GameObject.Find ("Light" + num);
		ThisLight.renderer.material = ON;
		ThisLight.audio.Play ();
	}

	public void TurnOff(){
		ThisLight.renderer.material = OFF;
	}

	public void Output(string action){
		using (StreamWriter writer = File.AppendText("output.csv")) {
			StringBuilder sb = new StringBuilder ();
			sb.Append (timer + "," + timeBetween + ","+action);
			writer.WriteLine (sb.ToString ());
		}
	}
}
