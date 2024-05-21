using UnityEngine;

public class HighScoreResetter : MonoBehaviour
{
    public void ResetHighScore()
    {
        PlayerPrefs.SetInt("high_score", 0); // Reset high score to zero
        PlayerPrefs.Save(); // Save changes to PlayerPrefs
        
    }
}
