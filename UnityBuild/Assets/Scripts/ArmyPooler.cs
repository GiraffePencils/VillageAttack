using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ArmyPooler : MonoBehaviour {

    public GameObject soldier;
    public int armySize = 5;

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
}
