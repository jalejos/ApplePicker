using UnityEngine;
using System.Collections;

public class BasketScript : MonoBehaviour {
	
	void FixedUpdate (){
		Vector3 basketPosition = this.transform.position;
		Vector3 mouseLocation = Input.mousePosition;
		Vector3 mousePosition = Camera.main.ScreenToWorldPoint (mouseLocation);
		basketPosition.x = mousePosition.x;
		this.transform.position = basketPosition;
	}
}
