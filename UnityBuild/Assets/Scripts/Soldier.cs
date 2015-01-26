using UnityEngine;
using System.Collections;


public class Soldier : MonoBehaviour {
    CharacterController m_characterController;
    int m_speed;

	// Use this for initialization
	void Start ()
    {
        m_speed = 1;
        m_characterController = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        m_characterController.Move(transform.forward * m_speed * Time.deltaTime);
	}

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.CompareTag("Wall"))
        {
            m_speed = 0;
        }

    }
    
}
