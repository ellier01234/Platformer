using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Using statement for the unity UI code
using UnityEngine.UI;

public class HighScores : MonoBehaviour {

    // text components used to display the high scores 
    public List<Text> highScoreDisplays = new List<Text>();

    // internal data for score values 
    private List<int> highScoreData = new List<int>();

	// Use this for initialization
	void Start () {
        // load the high score data from the player prefs
        LoadHighScoreData();

        // update the visual display
        UpdateVisualDisplay(); 

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void LoadHighScoreData()
    {
        for (int i = 0; i < highScoreDisplays.Count; ++i)
        {
            // using the loop index get the name for our playerPrefs key 
            string prefsKey = "highScore" + i.ToString();

            // use this key to get the high score value from PlayerPrefs
            int highScoreValue = PlayerPrefs.GetInt(prefsKey, 0);

            // store this score value in our internal data list 
            highScoreData.Add(highScoreValue);
            

        }
    }

    private void UpdateVisualDisplay()
    {
        for (int i = 0; i < highScoreDisplays.Count; ++i)
        {
            // find the specific text and numbers in our list 
            // set the text to the numerical score
            highScoreDisplays[i].text = highScoreData[i].ToString();
        }
    }

}
