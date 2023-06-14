using UnityEngine;
using System.Collections;

public class nuker : MonoBehaviour {

	static public bool canDestroy = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	static public void destroyYes()
	{
		canDestroy = true;
	}
	
	static public void destroyNo()
	{
		canDestroy = false;
	}
	
	void OnTriggerStay2D(Collider2D other){
		if (canDestroy)
		{
			if(other.tag == "red")
			{
				Destroy(other.gameObject);
			}
		}
	}
}
