using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Showscore : MonoBehaviour
{
    // Start is called before the first frame update
    void FixedUpdate()
    {
        this.GetComponent<TextMeshProUGUI>().text = Data.score.ToString("000");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
