using UnityEngine;
using System.Collections;

public class gardenerDestory : MonoBehaviour {
	public Component destroyer;
	//public GameObject objectToDestory2;
	//public Component objectThatDestroys;


	void OnTriggerEnter(Collider other) {
		print ("the object has entered the trigger");
		if (other == destroyer.collider) {
						Destroy (gameObject);
						//renderer.enabled = false;
				}
	}
}
