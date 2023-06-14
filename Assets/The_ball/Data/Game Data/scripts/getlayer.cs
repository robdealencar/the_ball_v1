using UnityEngine;
using System.Collections;

public class getlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
			gameObject.layer = LayerMask.NameToLayer("ball");

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
