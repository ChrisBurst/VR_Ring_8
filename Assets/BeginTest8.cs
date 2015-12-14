using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;

public class BeginTest8 : MonoBehaviour {
	
	public float timer=0;
	float timeBetween=0;
	float delay=0;
	public int arrayPosition=0;
	bool Started=false;
	bool isOn;
	string inputLine;
	int lightNum;
	int newFileNum = 1;
	//GameObject ThisLight;
	public string[] list;
	public Material ON;
	public Material OFF;
	public Material CORRECT;
	public GameObject StartPrompt;
	public GameObject EndPrompt;
	public GameObject[] Lights;
	int x;
	
	// Use this for initialization
	void Start () {
		StartPrompt.SetActive (true);
		EndPrompt.SetActive (false);
		Lights = new GameObject[8];
		x = 0;
		Debug.Log (Lights.Length);
		while(x<8) {
			Lights [x] = GameObject.Find ("Light" + (x + 1));
			x++;
		}
		//Load File
		Debug.Log ("Looking for file");
		if (File.Exists ("input.csv")) {
			Debug.Log("Found File");
			using (StreamReader Reader = File.OpenText("input.csv")) {
				inputLine = Reader.ReadLine ();
			}
			list = inputLine.Split ("," [0]);
		}

		//Setup Output
		while(File.Exists ("output ("+newFileNum+").csv")){
			newFileNum++;
		}
		using(StreamWriter writer = File.CreateText("output ("+newFileNum+").csv")){
			writer.WriteLine("Overall Time, Time since light, Action");
		}
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
			if(Lights[lightNum]!=null){
				if( Lights[lightNum].GetComponent<IsBeingLookedAt>().isLookedAt && Input.anyKeyDown){
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
		lightNum = int.Parse (number);
		while (lightNum>7)//Lower numbers so that they fit in the range
			lightNum -= 8;
		Lights[lightNum].renderer.material = ON;
		Lights[lightNum].audio.Play ();
	}
	
	public void TurnOff(){
		Lights[lightNum].renderer.material = OFF;
	}
	
	public void Output(string action){
		using (StreamWriter writer = File.AppendText("output ("+newFileNum+").csv")) {
			StringBuilder sb = new StringBuilder ();
			sb.Append (timer + "," + timeBetween + ","+action);
			writer.WriteLine (sb.ToString ());
		}
	}
}
