using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ArmyPooler : MonoBehaviour {

    public GameObject soldier;
    public AttackColumn attackInstance;
    public int armySize = 1;
    private float spawnTimer = 0.0f;

    List<GameObject> army; 

	void Start () 
    {
        army = new List<GameObject>();
        for (int i = 0; i < armySize; i++)
        {
            GameObject obj = (GameObject)Instantiate(soldier);
            obj.SetActive(false);
            army.Add(obj);
        }
	}

    void Update()
    {
        if (Time.time > spawnTimer) 
        {
            Spawn();
           // spawnTimer = Time.time + 2.0f;
        }
    }

    public GameObject GetSoldier()
    {
        for (int i = 0; i < army.Count; i++)
        {

            if (!army[i].activeInHierarchy)
            {
                return army[i];
            }
        }

        return null;
    }

    void Spawn()
    {
        if (!attackInstance.isColliding)
        {
            GameObject obj = (GameObject)GetSoldier();
            if (obj != null)
            {
                obj.transform.position = attackInstance.transform.position;
                obj.transform.rotation = attackInstance.transform.rotation;
                obj.SetActive(true);
                return;
            }
        }
    }
}
