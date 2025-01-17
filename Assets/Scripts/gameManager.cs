using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public int score;
    public int highScore;

    public Text scoreText;  // Oyundaki skor
    public Text highScoreText; // En y�ksek skor
    public ScoreUIManager scoreUIManager; // �l�m ekran�ndaki skoru y�neten s�n�f

    void Start()
    {
        score = 0;
        highScore = PlayerPrefs.GetInt("HighScore", 0);  // Kay�tl� en y�ksek skoru y�kle
        UpdateUI();
    }

    void UpdateUI()
    {
        scoreText.text = score.ToString();  // Skorun say�s�n� yazd�r
        highScoreText.text = "En Yuksek Skor: " + highScore.ToString(); // En y�ksek skoru g�ster
    }

    public void UpdateScore()
    {
        score++;
        UpdateUI();  // Skor ve UI'yi g�ncelle
    }

    // En y�ksek skoru kontrol et ve kaydet
    public void CheckHighScore()
    {
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);  // Yeni en y�ksek skoru kaydet
            PlayerPrefs.Save();  // Kaydet
        }
    }

    // �l�m ekran�nda g�ncel skoru ve y�ksek skoru g�stermek i�in
    public void UpdateDeathScreen()
    {
        scoreUIManager.UpdateScore(score);  // �l�m ekran�ndaki ge�erli skoru g�ncelle
        scoreUIManager.UpdateHighScore(highScore);  // �l�m ekran�ndaki y�ksek skoru g�ncelle
    }

    // Oyun yeniden ba�lat�ld���nda
    public void RestartGame()
    {
        Time.timeScale = 1;  // Oyun zaman�n� ba�lat
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  // Ayn� sahneyi tekrar y�kle
    }

    // Ana men�ye d�n
    public void GoToMainMenu()
    {
        Time.timeScale = 1;  // Oyun zaman�n� ba�lat
        SceneManager.LoadScene(0);  // Ana men� sahnesine git
    }
}
