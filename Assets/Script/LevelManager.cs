using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic; // Required for List
using TMPro;

public class LevelManager : MonoBehaviour
{
    public TMP_Dropdown levelDropdown;
    public Button playButton;

    private List<string> levelNames = new List<string>(); // Store level names

    void Start()
    {
        // Populate level names (replace with your actual level names)
        levelNames.Add("Test Scene1"); // Scene name: Level1
        levelNames.Add("Test Scene2"); // Scene name: Level2
        levelNames.Add("Test Scene3"); // Scene name: Level2
        levelNames.Add("Test Scene4"); // Scene name: Level2


        // Populate dropdown options
        levelDropdown.ClearOptions();
        levelDropdown.AddOptions(levelNames);

        // Set up button click listener
        playButton.onClick.AddListener(LoadSelectedLevel);
    }

    void LoadSelectedLevel()
    {
        int selectedIndex = levelDropdown.value;
        string selectedLevelName = levelNames[selectedIndex];

        // Load the selected level
        SceneManager.LoadScene(selectedLevelName);
    }
}