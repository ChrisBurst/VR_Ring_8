using UnityEngine;
using System.Collections;

public class PolyPlacement : MonoBehaviour {

	//place this script on a polygon to place objects at each vertex of the model

	public GameObject lightbulb;
	public float scale;

	// Use this for initialization
	void Start () {
		Mesh mesh = GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		int x = 0;
		while (x<vertices.Length){
			Instantiate(lightbulb, new Vector3(vertices[x].x*scale,vertices[x].y*scale,vertices[x].z*scale), Quaternion.identity);
			x++;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
