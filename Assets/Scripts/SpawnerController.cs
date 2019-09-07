using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public Transform ObjectToSpawn;
    public Transform leftLimit;
    public Transform rightLimit;

    void Start()
    {
        InvokeRepeating("Spawn", 0, 2);
    }

    // Update is called once per frame
    void Spawn() {
        Instantiate(ObjectToSpawn,
            gameObject.transform.position,
            Quaternion.identity);

        Vector3 newPosition = gameObject.transform.position;
        newPosition.x = Random.Range(leftLimit.position.x,
            rightLimit.position.x);
        gameObject.transform.position = newPosition;
    }
}
