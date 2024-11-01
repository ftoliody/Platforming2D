using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class AutoReplay : MonoBehaviour
{
    float timer = 0;
    public TextMeshProUGUI info;
    void Start()
    {
        if (EnemyControl.EnemyKilled == 3)
        {
            info.text = "Congratulations \n You Win!";
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 5)
        {
            Data.score = 0;
            EnemyControl.EnemyKilled = 0;
            SceneManager.LoadScene("Gameplay");
        }
    }
}
