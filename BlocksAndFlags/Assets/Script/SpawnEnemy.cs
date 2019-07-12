using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public Transform enemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0, 0.5f);
    }
    
    void Spawn()
    {
        Instantiate(enemyPrefab, GetComponent<Manager>().enemies);
    }
}
