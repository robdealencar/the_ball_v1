using UnityEngine;
using System.Collections;

public class gizmo : MonoBehaviour {
	
	public float gSizex;
	public float gSizey;
	public float gSizez;
	public float lowHeight;
	public float highHeight;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnDrawGizmos(){
		Gizmos.DrawWireCube(transform.position, new Vector3(gSizex,gSizey,gSizez));
	}
}
