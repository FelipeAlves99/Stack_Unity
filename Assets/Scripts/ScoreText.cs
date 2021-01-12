using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    private int score;
    private TextMeshProUGUI text;

    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        GameManager.OnCubeSpawn += GameManager_OnCubeSpawn;
    }

    private void OnDestroy()
    {
        GameManager.OnCubeSpawn -= GameManager_OnCubeSpawn;
    }

    private void GameManager_OnCubeSpawn()
    {
        score++;
        text.text = "Score: " + score;
    }
}
