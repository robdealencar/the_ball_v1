using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class guiGame : MonoBehaviour {

	public RectTransform rect;
	public RectTransform rect2;

	static public bool playerHasDied = false;
	public AudioClip sndDie;
	
	// Use this for initialization
	void Start () {
		
	}
	
	IEnumerator GUIon()
	{
		
		
		for(float i = 0; i<=1; i += Time.deltaTime)
		{
			rect.localScale = new Vector3( 1.184142f*i, 1.184142f,1.184142f);
			rect2.localScale = new Vector3( 1.184142f*i, 1.184142f,1.184142f);
			yield return null;
		}
		yield return null;
	}
	
	// Update is called once per frame
	void Update () {
		if(playerHasDied)
		{
			if(PublicGamemode.canPlaySound)
			{
				GetComponent<AudioSource>().PlayOneShot(sndDie,1);
			}
			StartCoroutine("GUIon");
			playerHasDied = false;
		}
	}
}
