using UnityEngine;
using System.Collections;
using System.IO;

public class GetData: MonoBehaviour {

	string[] list;
	string inputLine;
	public GameObject error;

	// Use this for initialization
	void Start () {
		if (File.Exists ("input.csv")) {
			using (StreamReader Reader = File.OpenText("input.csv")) {
				inputLine = Reader.ReadLine ();
			}
			GameObject.Find ("OverallController").GetComponent<BeginTest> ().list = inputLine.Split ("," [0]);
		} else {
			error.SetActive(true);
		}
	}
}
