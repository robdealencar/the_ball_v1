using UnityEngine;
using System.Collections;

public class OBallSpawn : MonoBehaviour {
	
	public GameObject prefab;
	public float xLaunch;
	public float yLaunch;
	public float smooth;
	public Vector3 newPosition;
	public float spawnRange;
	static public float averageSpawn;
	
	public float xLerp;
	public float yLerp;
	public float rateLerp;
	
	public float lowHeight;
	public float highHeight;
	
	
	
	void SpawnBall(){
		if(!move.isDead){
//			print("red");
			Instantiate(prefab, transform.position, Quaternion.identity);
		}
	}
	
	IEnumerator RandomBalls(){
		while (true)
		{
			SpawnBall();
			float spawnRangeRandom = Random.Range(-spawnRange ,spawnRange );
			float spawnWait = averageSpawn + spawnRangeRandom;
			yield return new WaitForSeconds(spawnWait);
		}
	}
	
	// Use this for initialization
	void Start () {
		//InvokeRepeating("SpawnBall", .0001f, 2f);
		averageSpawn = PublicGamemode.averageSpawn;
//		print(move.averageSpawn);
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
