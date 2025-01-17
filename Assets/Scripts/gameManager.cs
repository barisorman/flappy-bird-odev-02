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
    public Text highScoreText; // En yüksek skor
    public ScoreUIManager scoreUIManager; // Ölüm ekranýndaki skoru yöneten sýnýf

    void Start()
    {
        score = 0;
        highScore = PlayerPrefs.GetInt("HighScore", 0);  // Kayýtlý en yüksek skoru yükle
        UpdateUI();
    }

    void UpdateUI()
    {
        scoreText.text = score.ToString();  // Skorun sayýsýný yazdýr
        highScoreText.text = "En Yuksek Skor: " + highScore.ToString(); // En yüksek skoru göster
    }

    public void UpdateScore()
    {
        score++;
        UpdateUI();  // Skor ve UI'yi güncelle
    }

    // En yüksek skoru kontrol et ve kaydet
    public void CheckHighScore()
    {
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);  // Yeni en yüksek skoru kaydet
            PlayerPrefs.Save();  // Kaydet
        }
    }

    // Ölüm ekranýnda güncel skoru ve yüksek skoru göstermek için
    public void UpdateDeathScreen()
    {
        scoreUIManager.UpdateScore(score);  // Ölüm ekranýndaki geçerli skoru güncelle
        scoreUIManager.UpdateHighScore(highScore);  // Ölüm ekranýndaki yüksek skoru güncelle
    }

    // Oyun yeniden baþlatýldýðýnda
    public void RestartGame()
    {
        Time.timeScale = 1;  // Oyun zamanýný baþlat
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  // Ayný sahneyi tekrar yükle
    }

    // Ana menüye dön
    public void GoToMainMenu()
    {
        Time.timeScale = 1;  // Oyun zamanýný baþlat
        SceneManager.LoadScene(0);  // Ana menü sahnesine git
    }
}
