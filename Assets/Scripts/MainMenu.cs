using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI; 

public class MainMenu : MonoBehaviour
{
    public Text HighScoreText; // En yüksek skor göstergesi için Text

    void Start()
    {
        // Kaydedilmiþ en yüksek skoru yükle ve sadece sayýyý göster
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        HighScoreText.text = highScore.ToString(); // Sadece sayý olarak göster
    }

    public void StartGame()
    {
        SceneManager.LoadSceneAsync(1); // Oyun sahnesine geçiþ yap
    }
}
