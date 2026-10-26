using TMPro;
using UnityEngine;

public class RunnerStats : MonoBehaviour
{
    [SerializeField] private TMP_Text statsText;
    [SerializeField] private TMP_InputField nameInput;

    private int coins;            
    private float distance;       
    private string playerName;    

    private void Start() => Load();

    private void Load()
    {
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
        PlayerPrefs.Save(); 
    }

    private void Update()
    {
        distance += 5f * Time.deltaTime; 
        statsText.text = $"{playerName}\nCoins: {coins}\nDistance: {distance:F1} m";
    }


    public void AddCoin() { coins++; Save(); }
    public void SetName(string newName) { playerName = newName; Save(); }
    public void ResetData() { PlayerPrefs.DeleteAll(); Load(); }

    private void OnApplicationQuit() => Save();
}
