using UnityEngine;
using UnityEngine.UI;

public class ScoreUIManager : MonoBehaviour
{
    public Text scoreText;  // Skorun g�sterilece�i Text
    public Text highScoreText;  // En y�ksek skorun g�sterilece�i Text
    private RectTransform scoreTextRectTransform;  // Skorun RectTransform'u

    // Ba�lang��ta Text'in RectTransform'unu al�yoruz
    void Start()
    {
        scoreTextRectTransform = scoreText.GetComponent<RectTransform>();
    }

    // Skoru g�ncellemek i�in bir fonksiyon
    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();  // Skoru Text'e yaz
    }

    // En y�ksek skoru g�ncellemek i�in bir fonksiyon
    public void UpdateHighScore(int highScore)
    {
        highScoreText.text = "En Yuksek Skor: " + highScore.ToString();  // En y�ksek skoru Text'e yaz
    }

    // �l�m ekran�nda skoru g�sterme i�in pozisyon ayarlamas�
    public void SetScorePosition(bool isGameOver)
    {
        if (isGameOver)
        {
            // �l�m ekran�nda farkl� bir pozisyonda g�ster
            scoreTextRectTransform.anchoredPosition = new Vector2(0, -1127);
        }
        else
        {
            // Oyun s�ras�nda farkl� bir pozisyonda g�ster
            scoreTextRectTransform.anchoredPosition = new Vector2(0, -290);
        }
    }
}
