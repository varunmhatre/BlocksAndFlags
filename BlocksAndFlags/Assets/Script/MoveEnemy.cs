using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    [Range(3, 6)] public float movSpeed;
    [Range(-2, 3)] public float startPosY;

    // Start is called before the first frame update
    void Start()
    {
        movSpeed = Random.value * 3 + 3;

        startPosY = Random.value * 5 - 2;
        transform.position += new Vector3(0, startPosY, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(movSpeed * Time.deltaTime, 0, 0);

        if (transform.position.x < -15)
        {
            Destroy(gameObject);
        }
    }
}
