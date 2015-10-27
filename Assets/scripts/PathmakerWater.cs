using UnityEngine;
using System.Collections;

public class PathmakerWater : MonoBehaviour {

	int counter = 0;
	public Transform floorPrefab;
	public Transform pathmakerPrefab;
	
	// Update is called once per frame
	void Update () {
		
		if (counter < 35) {
			
			float rand = Random.Range (0.0f, 1.0f);
			
			if (rand < 0.25f) { 
				transform.Rotate (0f, 90f, 0f);
			}
			else if (rand < 0.25f && rand < 0.5f) { 
				transform.Rotate (0f, -90f, 0f);
			}
			else if (rand > 0.98f) { 
				Instantiate (pathmakerPrefab, transform.position, transform.rotation);
			}
			
			Instantiate (floorPrefab, transform.position, transform.rotation);
			transform.Translate (0f, 0f, 5f);
			counter++;
		}
		
		else {
			Destroy (this.gameObject); 
		}
	}

}
