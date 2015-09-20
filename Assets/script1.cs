using UnityEngine;
using System.Collections;

public class script1 : MonoBehaviour {

	bool CubeSpawned = false;
	float timePassed = 0;
	float cubeBronzeCount = -3; 
	public float createBronzeTime = 3;
	public float switchToSilverTime = 12;
	public float stopSpawningTime = 6; 

	public GameObject bronzeCube;
	public GameObject silverCube;

	// Use this for initialization

	void Start () {
	
	}

	void SpawnCube (GameObject oreType) {
		Instantiate (oreType, new Vector3(cubeBronzeCount,0,0), Quaternion.identity);
		cubeBronzeCount = cubeBronzeCount + 1.2f ; 
		print (timePassed);
		timePassed = 0;
	}


	// I was unclear about whether after the 12 seconds (switchToSilverTime being 12 sec) a 4th bronze cube should appear or if it should go into a silver spawn because the instructions simply said "after 12 sec" (I went ahead and made it spawn a 4th bronze cube) 
	// Update is called once per frame
	void Update () {
		timePassed = timePassed + Time.deltaTime;
		if (timePassed >= createBronzeTime && Time.time <= switchToSilverTime + 0.3f  && Time.time < stopSpawningTime + switchToSilverTime) {
			SpawnCube (bronzeCube);

		} 
		else if (timePassed >= createBronzeTime && Time.time < stopSpawningTime + switchToSilverTime + 0.3f ){
			SpawnCube (silverCube); 
		}
	}
}
