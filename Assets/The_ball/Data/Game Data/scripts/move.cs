using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class move : MonoBehaviour {
#pragma warning disable 0414
	public static float moveSpeed = 17;
	static bool hasSheild = false;
	static public bool godMode = false;
	static public float averageSpawn;
	static public bool isDead = false;
	static public bool isDeadRly = false;
	
	float mobileAxis = 0;
	
	public SpriteRenderer s;
	
	public AudioClip sndMoney;
	public AudioClip sndSheildHit;
	public AudioClip sndNuke;
	public AudioClip sndSheild;
	
	// Use this for initialization
	void Start () {
	
		//advertisment #
		if(_GameEditor._AreYouUsingUnityAds)
		{
			Advertisement.Initialize (_GameEditor._UnityAdsNumber);
		}
		
	
		isDead = false;
		isDeadRly = false;
//		print(PublicGamemode.gameMode);
		
		changeBest.showGameOver = false;
		changeBest.showNewRecord = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		PublicGamemode.canPlaySound = true;
		transform.position =  new Vector3(transform.position.x  + (Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed),
		transform.position.y, transform.position.z);
		
		///transform.position =  new Vector3(transform.position.x  + (mobileAxis * Time.deltaTime * moveSpeed),/////////////MOBILE MOVEMENT//////////////////
		//                                  transform.position.y, transform.position.z);
		
		Vector3 viewPosition = Camera.main.WorldToViewportPoint(transform.position);
		viewPosition.x = Mathf.Clamp01(viewPosition.x);
		viewPosition.y = Mathf.Clamp01(viewPosition.y);
		transform.position = Camera.main.ViewportToWorldPoint(viewPosition);
		
		if (hasSheild)
		{
			s.color = Color.blue;
		}
		if (!hasSheild)
		{
			s.color = Color.white;
		}
		
	}
	
	IEnumerator onNuker()
	{
		yield return new WaitForSeconds(.1f);
		nuker.destroyNo();
		yield return null;
	}

	
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "yellow")
		{
			Destroy(other.gameObject);
			changescore.addScore(5);
			if (true)//PublicGamemode.canPlaySound)
			{
				GetComponent<AudioSource>().PlayOneShot(sndMoney,1);
			}
			
		}
		else if (other.tag == "red")
		{
			if(!hasSheild)
			{
				if(!godMode)
				{
					Destroy(gameObject);
					isDead = true;
					isDeadRly = true;
					guiGame.playerHasDied = true;
					//SHOW AD -------------------------------------------------------------------------------------------------------------------
					
					int adRand = Random.Range(1,5);
					
					if(adRand == 2)
					{
						if(_GameEditor._AreYouUsingUnityAds)
						{
							if(Advertisement.isReady()){
								Advertisement.Show();
							}
						}
					}
					
					changeBest.checkScore();
					
				}
			}
			else
			{
				hasSheild = false;
				if (true)//PublicGamemode.canPlaySound)
				{
					GetComponent<AudioSource>().PlayOneShot(sndSheildHit,1f);
				}
			}
		}
		else if (other.tag == "orange")
		{
			Destroy(other.gameObject);
			changescore.addScore(10);
			if (true)//PublicGamemode.canPlaySound)
			{
				GetComponent<AudioSource>().PlayOneShot(sndMoney,1);
			}
		}
		else if (other.tag == "green")
		{
			Destroy(other.gameObject);
			changescore.addScore(25);
			if (true)//PublicGamemode.canPlaySound)
			{
				GetComponent<AudioSource>().PlayOneShot(sndMoney,1);
			}
		}
		else if (other.tag == "blue")
		{
			Destroy(other.gameObject);
			//Sheild
			hasSheild = true;
			if (true)//PublicGamemode.canPlaySound)
			{
				GetComponent<AudioSource>().PlayOneShot(sndSheild,1);
			}
		}
		else if (other.tag == "nuke")
		{
			Destroy(other.gameObject);
			nuker.destroyYes();
			StartCoroutine("onNuker");
			//nukeif (PublicGamemode.canPlaySound)
			if (true)//PublicGamemode.canPlaySound)
			{
				GetComponent<AudioSource>().PlayOneShot(sndNuke,1);
			}
		}
	}
}
















































