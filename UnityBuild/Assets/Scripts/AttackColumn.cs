using UnityEngine;
using System.Collections;

public class AttackColumn : MonoBehaviour {
       
    public bool isColliding; 
	// Use this for initialization
	void Start () 
    {
        isColliding = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnTriggerEnter(Collider collision)
    {
        isColliding = true;
    }

    void OnTriggerExit(Collider collisionInfo)
    {
        isColliding = false;
    }
}
