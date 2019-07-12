using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Manager>().player.GetComponent<Move>().enabled = false;
        GetComponent<Manager>().player.GetComponent<Jump>().enabled = false;

        GetComponent<Manager>().enemies.gameObject.SetActive(false);
    }

}
