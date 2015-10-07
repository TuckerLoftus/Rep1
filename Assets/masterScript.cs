using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class masterScript : MonoBehaviour {

	// to point to variabes in this script from cubeBehavior  
	public static masterScript instance ;
	
	float timePassed = 0;

	public Text score; 

	public GameObject bronzeCube;
	public GameObject silverCube;
	public GameObject goldCube;
	public GameObject kryptoniteCube;

	public int cubeBronzeCount = 0;
	public int cubeSilverCount = 0;
	public int cubeGoldCount = 0;
	public int cubeKryptoniteCount = 0; 

	// time to spawn 
	public float spawnTime = 3;

	public int bronzePoints = 1;
	public int silverPoints = 10;
	public int goldPoints = 100;
	public int kryptonitePoints = 1000;
	
	public int totalScore = 0; 

	void Start () {
		instance = this;
	}

	// spawns cube within range, sets timePassed to zero again 
	void SpawnCube (GameObject oreType) {
		Instantiate (oreType, new Vector3 (Random.Range(-10.3f,10.3f),Random.Range(-4.8f,4.8f),0), Quaternion.identity); 
		print (timePassed);
		timePassed = 0;
	}
	
	// Update is called once per frame
	void Update () {

		//based on the instructions from the GD document, the kryptonite can be clicked on and exploited indefinetly.    

		timePassed += Time.deltaTime;

		// used an OR statment to implement kyrptonite ore as a wild card when spawning more Kryptonite. 
		// the cubeKryptoniteCount being set to two lets the player collect two kryptonite in succession, with a silver in between.

		if ((timePassed >= spawnTime && cubeSilverCount  == cubeGoldCount + (cubeKryptoniteCount) && cubeKryptoniteCount < 2 && cubeSilverCount != 0) || (timePassed >= spawnTime && cubeSilverCount + (cubeKryptoniteCount) == cubeGoldCount && cubeKryptoniteCount < 3 && cubeSilverCount != 0))  {
			SpawnCube(kryptoniteCube);
			cubeKryptoniteCount++;
		}
		else if (timePassed >= spawnTime && cubeBronzeCount == 2 && cubeSilverCount == 2 && cubeGoldCount < 1 ) {
			SpawnCube (goldCube);
			cubeGoldCount++;
		}
		else if (timePassed >= spawnTime && cubeBronzeCount > 3 ){
			SpawnCube (silverCube);
			cubeSilverCount++;
		}

		// I chose to make the bronze cubes count up to 4 and then spawn silver, instead of when there are 5 (4+) 

		else if  (timePassed >= spawnTime && cubeBronzeCount <= 3 ) {
			SpawnCube (bronzeCube);
			cubeBronzeCount++;
		} 
		score.text = totalScore.ToString();
		// sends totalScore to be dispalyed as Text canvas 
	}
}
