using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorController : MonoBehaviour
{
    public PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        GameObject go = GameObject.FindGameObjectWithTag("Player");
        player = go.GetComponent<PlayerController>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        player.Score += 5;
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
