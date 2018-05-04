using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpsFirstFloor : MonoBehaviour {
    public Transform pickUp;
	// Use this for initialization
	void Start () {
        Vector3 floorPosition = transform.position;
        for(int i=0; i< 10; i++)
        {
            Vector3 position = new Vector3(Random.Range(-10.0f,10.0f),0.5f,Random.Range(-10.0f, 10.0f));
            Instantiate(pickUp, position + floorPosition, Quaternion.identity);
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
