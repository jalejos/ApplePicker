using UnityEngine;
using System.Collections;

public class TreeScript : MonoBehaviour {

	public float speed;
	public float limitLeft, limitRight;
	bool isMovingRight;
	public float chanceOfTurn, chanceOfApple;
	public GameObject apple;


	// Use this for initialization
	void Start () {
		isMovingRight = true;
	}
	
	// Update is called once per frame
	void Update () {
		MoveTree ();
		ChangeDirection ();
		GenerateApple ();
	}

	void MoveTree () {
		Vector3 position = this.transform.position;
		if (isMovingRight) {
			position.x += speed * Time.deltaTime;
		} else {
			position.x -= speed * Time.deltaTime;
		}
		this.transform.position = position;
			
	}

	void ChangeDirection () {
		if (this.transform.position.x > limitRight) {
			isMovingRight = false;
		} else if (this.transform.position.x < limitLeft) {
			isMovingRight = true;
		} else {
			float randomNumber = Random.Range (0f, 1f);
			if (chanceOfTurn > randomNumber) {
				isMovingRight = !isMovingRight;
			}
		}
	}

	void GenerateApple () {
		float randomNumber = Random.Range (0f, 1f);
		if (chanceOfApple > randomNumber) {
			GameObject appleInstance = Instantiate (apple) as GameObject;
			appleInstance.transform.position = this.transform.position;
		}
	}
}
