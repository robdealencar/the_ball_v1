using UnityEngine;
using System.Collections;

public class _GameEditor : MonoBehaviour {

	//Title
	public string gameName = "Mobile Game Template";
	public static string _gameName;
	public string gameInstructions = "Dodge the red balls while trying to collect powerups and coins. Touch the screen to move your player towards or away from balls.";
	public static string _gameInstructions;
	public Sprite titleBackGround;
	public static Sprite _titleBackGround;
	
	//Textures
	public Sprite enemyBall;
	public static Sprite _enemyBall;
	
	public Sprite _5pointBall;
	public static Sprite __5pointBall;
	
	public Sprite _10pointBall;
	public static Sprite __10pointBall;
	
	public Sprite _25pointBall;
	public static Sprite __25pointBall;
	
	public Sprite nukeBall;
	public static Sprite _nukeBall;
	
	public Sprite shieldBall;
	public static Sprite _shieldBall;
	
	public Sprite player;
	public static Sprite _player;
	
	public Sprite ground;
	public static Sprite _ground;
	
	public Sprite GameBackGround;
	public static Sprite _backGround;
	
	public float moveSpeed = move.moveSpeed;
	public static float _moveSpeed;
	
	public float PracticeSpawnRate = 0.76f;
	public static float _PracticeSpawnRate;
	
	public float MediumSpawnRate = 0.76f;
	public static float _MediumSpawnRate;
	
	
	public float EasySpawnRate = 1.1f;
	public static float _EasySpawnRate;
	
	public float HardSpawnRate = 0.525f;
	public static float _HardSpawnRate;
	
	
	public float InsaneSpawnRate = 0.3975f;
	public static float _InsaneSpawnRate;
	
	//Ads
	public bool AreYouUsingUnityAds = false;
	public static bool _AreYouUsingUnityAds;
	
	public string UnityAdsNumber = "If you are not using Unity ads, ignore this";
	public static string _UnityAdsNumber;
	
	void Awake()
	{
		Object.DontDestroyOnLoad(gameObject);
		
		_gameName = gameName;
		_gameInstructions = gameInstructions;
		__5pointBall = _5pointBall;
		__10pointBall = _10pointBall;
		__25pointBall = _25pointBall;
		_player = player;
		_nukeBall = nukeBall;
		_shieldBall = shieldBall;
		_ground = ground;
		_moveSpeed = moveSpeed;
		_PracticeSpawnRate = PracticeSpawnRate;
		_EasySpawnRate = EasySpawnRate;
		_MediumSpawnRate = MediumSpawnRate;
		_HardSpawnRate = HardSpawnRate;
		_InsaneSpawnRate = InsaneSpawnRate;
		_AreYouUsingUnityAds = AreYouUsingUnityAds;
		_UnityAdsNumber = UnityAdsNumber;
		_enemyBall = enemyBall;
		_backGround = GameBackGround;
		_titleBackGround = titleBackGround;
	}	
	
	void Update()
	{
		move.moveSpeed = moveSpeed;
		PublicGamemode.averageEasy = EasySpawnRate;
		PublicGamemode.averageHard = HardSpawnRate;
		PublicGamemode.averageMedium = MediumSpawnRate;
		PublicGamemode.averageInsane = InsaneSpawnRate;
		PublicGamemode.averagePractice = PracticeSpawnRate;
	}
	
}



































