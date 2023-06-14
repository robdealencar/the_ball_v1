using UnityEngine;
using System.Collections;

public class flipper : MonoBehaviour {

	float scalex;
	// Use this for initialization
	void Start () {
	 scalex = transform.localScale.z;
	}
	
	// Update is called once per frame
	void Update () {
	
		if(GetComponent<Rigidbody2D>().velocity.x<0)
		{
			transform.localScale = new Vector3(transform.localScale.x,transform.localScale.y, scalex);
		}
		else if(GetComponent<Rigidbody2D>().velocity.x>0)
		{
			transform.localScale = new Vector3(transform.localScale.x,transform.localScale.y, -scalex);
		}
	}
}
