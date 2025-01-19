using UnityEngine;
using UnityEngine.UI;

public class ScoreUIManager : MonoBehaviour
{
    public Text scoreText;  // Skorun gösterileceði Text
    public Text highScoreText;  // En yüksek skorun gösterileceði Text
    private RectTransform scoreTextRectTransform;  // Skorun RectTransform'u

    // Baþlangýçta Text'in RectTransform'unu alýyoruz
    void Start()
    {
        scoreTextRectTransform = scoreText.GetComponent<RectTransform>();
    }

    // Skoru güncellemek için bir fonksiyon
    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();  // Skoru Text'e yaz
    }

    // En yüksek skoru güncellemek için bir fonksiyon
    public void UpdateHighScore(int highScore)
    {
        highScoreText.text = "En Yuksek Skor: " + highScore.ToString();  // En yüksek skoru Text'e yaz
    }

    // Ölüm ekranýnda skoru gösterme için pozisyon ayarlamasý
    public void SetScorePosition(bool isGameOver)
    {
        if (isGameOver)
        {
            // Ölüm ekranýnda farklý bir pozisyonda göster
            scoreTextRectTransform.anchoredPosition = new Vector2(0, -1127);
        }
        else
        {
            // Oyun sýrasýnda farklý bir pozisyonda göster
            scoreTextRectTransform.anchoredPosition = new Vector2(0, -290);
        }
    }
}
