using UnityEngine;
using UnityEngine.UI;

public class Game_Manager : MonoBehaviour
{
    [SerializeField] GameObject gameOverMenu;
    [SerializeField] Text scoreText;
    public static float totalCoinPoints = 0f;

    public void EndGame()
    {
        gameOverMenu.SetActive(true);
        scoreText.enabled = false;

        GameObject yourScore = GameObject.Find("YourScore");
        yourScore.GetComponent<Text>().text += scoreText.text;

        GameObject highestScore = GameObject.Find("HighestScore");
        if (int.Parse(scoreText.text) >= PlayerPrefs.GetInt("HighestScore"))
        {
            PlayerPrefs.SetInt("HighestScore", int.Parse(scoreText.text));
            highestScore.GetComponent<Text>().text += scoreText.text;
        }
        else highestScore.GetComponent<Text>().text += PlayerPrefs.GetInt("HighestScore").ToString();

        totalCoinPoints = 0f;
    }
}
