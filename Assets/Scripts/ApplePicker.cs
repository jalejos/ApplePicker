using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ApplePicker : MonoBehaviour {

	int score;
	int lives;
	public Text scoreUI;

	void Start (){
		score = 0;
		lives = 3;
		scoreUI.text = score.ToString();
	}

	public void PlayerScored(){
		score += 100;
		scoreUI.text = score.ToString();
	}

	public void LoseLife() {
		lives--;
		if (lives == 0) {
		}
	}
}
