
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Text scoreText;
    public int score;

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

}
