using UnityEngine;
using System.Collections;

public class gardenerPlant : MonoBehaviour {

	public Transform myObject1; // assign in inspector
	public Transform myObject2; // assign in inspector
	public float nextPlantingTime; //time between plantings
	
	void Start () {
		//nextPlantingTime = Time.time + 5f; // when I am born, set my next plant time later
		nextPlantingTime += Time.time + 5f;;
	}
	
	// Update is called once per frame
	void Update () {
		// check if it is time to plant
		//Use a random number to decide which one to plant
		if (Time.time > nextPlantingTime ) {
			if (Random.Range (0f, 1f) > 0.1f ) { 
				Instantiate (myObject1, transform.position, Quaternion.identity );
			} else{
				Instantiate(myObject2, transform.position, Quaternion.identity);
			}
			nextPlantingTime += (nextPlantingTime + Random.Range( 2f, -2f)); // set the next planting time
		}	
	}
}
