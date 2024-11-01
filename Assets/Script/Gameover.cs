using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Gameover : MonoBehaviour
{
    public TextMeshProUGUI txScore;
    public TextMeshProUGUI txHighScore;
    TextMeshProUGUI txSelamat;
    int highscore;
    
    void Start()
    {
        highscore = PlayerPrefs.GetInt("HS", 0);
        if (Data.score > highscore )
        {
            highscore = Data.score;
            PlayerPrefs.SetInt("HS", highscore);
        }
        else if (EnemyControl.EnemyKilled == 3)
        {
            SceneManager.LoadScene("Congratulations");
        }
        txHighScore.text = "Highscores: " + highscore;
        txScore.text = "Scores: " + Data.score;
    }
    public void replay()
    {
        Data.score = 0;
        EnemyControl.EnemyKilled = 0;
        SceneManager.LoadScene("Level1");
    }
}
