using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHit : MonoBehaviour
{
    GameObject manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindWithTag("Manager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            manager.GetComponent<Manager>().GetComponent<EndGame>().enabled = true;

            if (tag == "Flag")
            {
                manager.GetComponent<Manager>().endScreen.transform.GetChild(0).gameObject.SetActive(true);
            }
            else if(tag == "Water")
            {
                manager.GetComponent<Manager>().endScreen.transform.GetChild(1).gameObject.SetActive(true);
            }
        }
    }
}
