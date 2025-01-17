using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI; 

public class MainMenu : MonoBehaviour
{
    public Text HighScoreText; // En y�ksek skor g�stergesi i�in Text

    void Start()
    {
        // Kaydedilmi� en y�ksek skoru y�kle ve sadece say�y� g�ster
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        HighScoreText.text = highScore.ToString(); // Sadece say� olarak g�ster
    }

    public void StartGame()
    {
        SceneManager.LoadSceneAsync(1); // Oyun sahnesine ge�i� yap
    }
}
