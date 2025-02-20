using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("UI Components")]
    public TMP_Text coinUIText;

    private int totalCoins;
    private int collectedCoins = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        totalCoins = GameObject.FindGameObjectsWithTag("Coin").Length;
        UpdateCoinUI();
    }

    public void CoinCollected()
    {
        collectedCoins++;
        UpdateCoinUI();
    }

    void UpdateCoinUI()
    {
        if (coinUIText != null)
        {
            coinUIText.text = " Coins Collected: " + collectedCoins + " / " + totalCoins;
        }
        else
        {
            Debug.LogWarning("coinUIText not assigned!");
        }
    }

    // 新增 AllCoinsCollected 方法
    public bool AllCoinsCollected()
    {
        return collectedCoins >= totalCoins;
    }

    public void LevelComplete()
    {
        Debug.Log("Level Complete!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

