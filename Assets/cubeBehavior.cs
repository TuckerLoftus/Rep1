using UnityEngine;
using System.Collections;

public class cubeBehavior : MonoBehaviour {

	// holds sound effect that plays on destroy cube 
	public AudioSource sfx ; 

	// controls speed of cube rotation 
	public float scale = 4f ; 


	void Start () {
	}
	
	// Update is called once per frame
	// controls spawned cube's rotation. Change "Vector3.right" to change the direction of the rotation 
	void Update () {
		transform.Rotate (Vector3.right * Time.deltaTime * scale);
	}


	// searches GO for name and reduces cube[Ore]Count by one as well as increasing totalScore by [ore]Points. "masterScript.instance." points the variables out in the MAsterScript script.  
	void OnMouseDown () {
	if (gameObject.name.Contains ("Bronze")) {
			masterScript.instance.cubeBronzeCount = masterScript.instance.cubeBronzeCount - 1 ;
			masterScript.instance.totalScore += masterScript.instance.bronzePoints;
			print ("total score is " + masterScript.instance.totalScore);

		} else if (gameObject.name.Contains ("Silver")) {
			masterScript.instance.cubeSilverCount = masterScript.instance.cubeSilverCount - 1;
			masterScript.instance.totalScore += masterScript.instance.silverPoints;
			print ("total score is " + masterScript.instance.totalScore);
		}
		else if (gameObject.name.Contains ("Gold")) {
			masterScript.instance.cubeGoldCount = masterScript.instance.cubeGoldCount - 1;
			masterScript.instance.totalScore += masterScript.instance.goldPoints;
			print ("total score is " + masterScript.instance.totalScore);
		}
		else if (gameObject.name.Contains ("Kryptonite")) {
			masterScript.instance.cubeKryptoniteCount = masterScript.instance.cubeKryptoniteCount - 1;
			masterScript.instance.totalScore += masterScript.instance.kryptonitePoints;
			print ("total score is " + masterScript.instance.totalScore);
		}
		Destroy (gameObject);
		sfx.Play (); 
	}
}
