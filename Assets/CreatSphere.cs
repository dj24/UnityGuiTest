using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatSphere : MonoBehaviour {

    public Transform Sphere;
    
    public void createSphere()
    {
        Instantiate(Sphere, transform.position, transform.rotation);
    }

	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
