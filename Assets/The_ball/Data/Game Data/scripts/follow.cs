using UnityEngine;
using System.Collections;

public class follow : MonoBehaviour {
//#pragma warning disable 0216
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			gameObject.transform.position = new Vector3( g1.y.x, transform.position.y,transform.position.z);
		
	}
}
