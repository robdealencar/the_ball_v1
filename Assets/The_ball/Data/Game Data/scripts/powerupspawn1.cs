using UnityEngine;
using System.Collections;

public class powerupspawn1 : MonoBehaviour {
	
	public GameObject prefab;
	public float xLaunch = 300f;
	public float yLaunch;
	public float smooth = 2f;
	public Vector3 newPosition = new Vector3(-15,1,0);
	public float spawnRange = .5f;
	public float averageSpawn;
	public int odds;
	
	public float xLerp;
	public float yLerp;
	public float rateLerp;
	
	public float lowHeight = 2.1f;
	public float highHeight = 7.5f;
	
	void SpawnBall(){
		if(!move.isDead){
			float randomNum = Random.Range(1, odds + 1);
			if (randomNum == 1){
				Instantiate(prefab, transform.position, Quaternion.identity);
//				print ("orange");
			}
		}
	}
	
	IEnumerator RandomBalls(){
		while (true)
		{
			SpawnBall();
			float spawnRangeRandom = Random.Range(-spawnRange ,spawnRange );
			//print (spawnRangeRandom);
			float spawnWait = averageSpawn + spawnRangeRandom;
			yield return new WaitForSeconds(spawnWait);
		}
	}
	
	// Use this for initialization
	void Start () {
		//InvokeRepeating("SpawnBall", .0001f, 2f);
		averageSpawn =  PublicGamemode.averageSpawn;
		
		StartCoroutine("RandomBalls");
		InvokeRepeating("ChangePosVariables", .0001f, averageSpawn);
		
	}
	
	void ChangePosVariables(){
		xLerp = Random.Range(9.85f, 18.78f );
		xLerp = xLerp * -1;
		yLerp = Random.Range( 7.45f,2.15f );
		
	}
	
	void ChangePos(){
		transform.position = Vector3.Lerp(transform.position, new Vector3(xLerp, yLerp, 0), smooth * Time.deltaTime);
	}
	// Update is called once per frame
	void Update () {
		ChangePos ();
	}
}
