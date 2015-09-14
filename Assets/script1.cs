using UnityEngine;
using System.Collections;

public class script1 : MonoBehaviour {

	bool CubeSpawned = false;

	public GameObject cube;
	// Use this for initialization
	void Start () {
	
	}

	void SpawnCube () {
		Instantiate (cube, new Vector3(0,0,0), Quaternion.identity); 
	}

	// Update is called once per frame
	void Update () {
		if (Time.time > 3 && CubeSpawned == false) {
			SpawnCube ();
			CubeSpawned = true;
		}
	
	}
}
