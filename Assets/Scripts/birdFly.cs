using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class birdFly : MonoBehaviour
{
    public bool isDead;
    public float velocity = 1f;
    public Rigidbody2D rb2D;

    public gameManager managerGame;
    public GameObject DeathScreen;
    public ScoreUIManager scoreUIManager;

    private void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isDead)
        {
            rb2D.velocity = Vector2.up * velocity; // T�klan�rsa ku�u havaya s��rat
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ScoreArea")
        {
            managerGame.UpdateScore(); // Skoru g�ncelle
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathArea")
        {
            isDead = true;
            Time.timeScale = 0; // Oyun durduruluyor

            DeathScreen.SetActive(true); // �l�m ekran�n� a�

            // Skorun ta��nmas�n� sa�layal�m
            scoreUIManager.SetScorePosition(true);  // �l�m ekran�nda do�ru pozisyona ta��
            scoreUIManager.UpdateScore(managerGame.score);  // Skoru g�ncelle
            managerGame.CheckHighScore(); // En y�ksek skoru kontrol et
            managerGame.UpdateDeathScreen(); // �l�m ekran�ndaki y�ksek skoru g�ncelle
        }
    }
}
