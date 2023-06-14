using UnityEngine;
using System.Collections;

public class ballScript1 : MonoBehaviour {
	
	//public GameObject prefab;
	public float xLaunch;
	public float yLaunch;
	
	public float size;
	public AudioClip sndThud;
	
	void OnCollisionEnter2D()
	{
		if(!move.isDeadRly)
		{
			GetComponent<AudioSource>().PlayOneShot(sndThud,1f);
		}
	}
	
	//public float 
	void Awake(){
		size = .15f;
	}
	// Use this for initialization
	void Start () {
		xLaunch = Random.Range(95f,320f);
		GetComponent<Rigidbody2D>().AddForce(new Vector2(xLaunch, yLaunch));
		
		transform.localScale = new Vector3(size, size, 0);
			
		}
	void OnTriggerEnter2D(Collider2D other)
	{
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
