using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FlappyBirdScript : MonoBehaviour

{
    Rigidbody2D rb2d;
    public float speed = 5f;
    public float flapForce = 20f;
    bool isDead;
    public GameObject replayButton,playButton;

    int score = 0;
    public TextMeshProUGUI scoreText;

    void OnCollisionEnter2D(Collision2D col)
    {
        isDead = true;
        rb2d.velocity = Vector2.zero;
        replayButton.SetActive(true);
        GetComponent<Animator>().SetBool("isdead", true);


    }


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = Vector2.right * speed;
        Time.timeScale = 0;
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = Vector2.right * speed;
        playButton.SetActive(true);
        replayButton.SetActive(false);
        
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isDead)
        {
            rb2d.velocity = Vector2.right * speed;
            rb2d.AddForce(Vector2.up * flapForce);

        }
    }
    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
    public void UnFreeze()
    {
        Time.timeScale=1;
        playButton.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Score")
        {
            score++;
            Debug.Log(score);
            scoreText.text = score.ToString();
        }
    }


    }









