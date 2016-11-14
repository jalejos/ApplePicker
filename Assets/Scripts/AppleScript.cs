using UnityEngine;
using System.Collections;

public class AppleScript : MonoBehaviour {

	public float limitDown;
	ApplePicker script;

	void Start () {
		script = Camera.main.GetComponent<ApplePicker> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.y < limitDown) {
			Destroy (this.gameObject);
			script.LoseLife ();
		}
	}

	void OnCollisionEnter (Collision col){
		if (col.gameObject.tag == "Basket") {
			Destroy (this.gameObject);
			script.PlayerScored();
		}
	}
}
