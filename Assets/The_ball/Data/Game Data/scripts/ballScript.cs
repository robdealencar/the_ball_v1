using UnityEngine;
using System.Collections;

public class ballScript : MonoBehaviour {
	
	//public GameObject prefab;
	public float xLaunch;
	public float yLaunch;
	
	public float size;
	public AudioClip sndBigThud;
	
	void OnCollisionEnter2D()
	{
		if(!move.isDeadRly)
		{
			
			GetComponent<AudioSource>().PlayOneShot(sndBigThud,.4f);
		}
	}
	//public float 
	
	// Use this for initialization
	void Start () {
		xLaunch = Random.Range(95f,320f);
		GetComponent<Rigidbody2D>().AddForce(new Vector2(xLaunch, yLaunch));
		if(gameObject.tag == "yolo")
		{
			size = Random.Range(8.0f,9.0f);
		}
		else
		{
			size = Random.Range(.35f,.58f);
		}
		
		transform.localScale = new Vector3(size, size, 0);
			
	}
	

	
	// Update is called once per frame
	void Update () {
	
	}
}
