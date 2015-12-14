using UnityEngine;
using System.Collections;
using System.Text;
using System.IO;

public class Output : MonoBehaviour {

	/*public float time;
	string button;*/
	int newFileNum = 1;

	// Use this for initialization
	void Start () {
		while(File.Exists ("output ("+newFileNum+").csv")){
			newFileNum++;
		}
		using(StreamWriter writer = File.CreateText("output ("+newFileNum+").csv")){
			writer.WriteLine("Overall Time, Time since light, Action");
		}
	}
	/*
	public void LightOn (string LightID){
		using(StreamWriter writer = File.AppendText("output.csv")){
			StringBuilder sb = new StringBuilder ();
			sb.Append (time+","+LightID+" turned on");
			writer.WriteLine(sb.ToString());
		}
	}
	public void SawLight(){
		using(StreamWriter writer = File.AppendText("output.csv")){
			StringBuilder sb = new StringBuilder ();
			sb.Append (time+","+"Participant saw Light");
			writer.WriteLine(sb.ToString());
		}
	}

	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (Input.anyKeyDown) {
			SawLight();
		}
	}*/
}

