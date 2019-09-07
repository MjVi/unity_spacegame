using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Transform Bullet;
    public Transform CannonPosition;
    public int Score;
    public Text ScoreText;
    public float timeLeft;
    public Text timerText;
    public Slider Life;

    // Start is called before the first frame update
    void Start()
    {
        UpdateTimer();
        ScoreText.text = "Score: ";
        Life.value = 100;
    }

    void FixedUpdate()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            timeLeft = 0;
        }
        UpdateTimer();
    }

    void UpdateTimer()
    {
        timerText.text = "Time Left... " + Mathf.RoundToInt(timeLeft);
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score: " + Score;
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        gameObject.transform.Translate(new Vector3(h*.3f, v*.3f, 0));

        if (Input.GetKeyDown(KeyCode.Space)) {
            Shoot();
        }
    }

    void Shoot() {
        Instantiate(Bullet, CannonPosition.position, Quaternion.identity);
    }

    void OnTriggerEnter2D(Collider other)
    {
        if (other.GameObject = GameObject.FindGameObjectWithTag("Player"))
        {

        }
        Life.value -=5;
        Debug.Log(Life.value);
    }
}
