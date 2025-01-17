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
            rb2D.velocity = Vector2.up * velocity; // Týklanýrsa kuþu havaya sýçrat
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ScoreArea")
        {
            managerGame.UpdateScore(); // Skoru güncelle
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathArea")
        {
            isDead = true;
            Time.timeScale = 0; // Oyun durduruluyor

            DeathScreen.SetActive(true); // Ölüm ekranýný aç

            // Skorun taþýnmasýný saðlayalým
            scoreUIManager.SetScorePosition(true);  // Ölüm ekranýnda doðru pozisyona taþý
            scoreUIManager.UpdateScore(managerGame.score);  // Skoru güncelle
            managerGame.CheckHighScore(); // En yüksek skoru kontrol et
            managerGame.UpdateDeathScreen(); // Ölüm ekranýndaki yüksek skoru güncelle
        }
    }
}
