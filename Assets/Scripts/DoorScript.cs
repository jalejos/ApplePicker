using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour {

	const string childName = "Door";
	static GameObject doorGameObject;
	/* Para que On Trigger funcione, nuestro objeto DoorTriggerObject o nuestro objeto Basket necesita tener un rigidBody
	*  es decir, necesita respetar la fisica. Lo agregamos a Basket y para que no caiga el objeto ni salga volando por 
	*  las manzanas, chequen los restraints que impiden rotación y movimiento en el eje y
	*/
	void OnTriggerEnter(Collider collider) {
		if (collider.gameObject.tag == "Basket") {
			doorGameObject = this.transform.FindChild (childName).gameObject;
			doorGameObject.SetActive (false);
		}
	}

	void OnTriggerExit(Collider collider) {
		if (collider.gameObject.tag == "Basket") {
			doorGameObject.SetActive (true);
		}
	}
}
