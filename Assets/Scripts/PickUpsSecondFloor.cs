using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpsSecondFloor : MonoBehaviour {
    public Transform pickUp;
	// Use this for initialization
	void Start () {
        for(int i=0; i < 10; i++)
        {
            Vector3 floorPosition = transform.position;
	        Vector3 position = new Vector3(Random.Range(-15.0f, 15.0f), 0.5f, Random.Range(-5.0f, 5.0f));
            Instantiate(pickUp, position + floorPosition, Quaternion.identity);
        }
        
	}
	
	// Update is called once per frame
	void Update () {

		
	}
}
