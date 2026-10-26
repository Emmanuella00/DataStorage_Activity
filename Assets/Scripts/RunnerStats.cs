using TMPro;
using UnityEngine;

/// Temple Run style stats saved between sessions with PlayerPrefs.
public class RunnerStats : MonoBehaviour
{
    [SerializeField] private TMP_Text statsText;
    [SerializeField] private TMP_InputField nameInput;

    private int coins;            // int
    private float distance;       // float
    private string playerName;    // string

    private void Start() => Load();

    private void Load()
    {
        // 2nd argument = default value if the key was never saved
        coins = PlayerPrefs.GetInt("Coins", 0);
        distance = PlayerPrefs.GetFloat("Distance", 0f);
        playerName = PlayerPrefs.GetString("PlayerName", "Runner");
        nameInput.text = playerName;
    }

    private void Save()
    {
        PlayerPrefs.SetInt("Coins", coins);
        PlayerPrefs.SetFloat("Distance", distance);
        PlayerPrefs.SetString("PlayerName", playerName);
        PlayerPrefs.Save(); // write to disk now
    }

    private void Update()
    {
        distance += 5f * Time.deltaTime; // simulates running
        statsText.text = $"{playerName}\nCoins: {coins}\nDistance: {distance:F1} m";
    }

    // Hook these to UI events in the Inspector
    public void AddCoin() { coins++; Save(); }
    public void SetName(string newName) { playerName = newName; Save(); }
    public void ResetData() { PlayerPrefs.DeleteAll(); Load(); }

    private void OnApplicationQuit() => Save();
}
