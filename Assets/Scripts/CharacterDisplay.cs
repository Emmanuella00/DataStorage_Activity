using TMPro;
using UnityEngine;


public class CharacterDisplay : MonoBehaviour
{
    [SerializeField] private CharacterData character;
    [SerializeField] private TMP_Text nameText;       
    [SerializeField] private TMP_Text speedText;
    [SerializeField] private TMP_Text coinsText;

    private void Start()
    {
        nameText.text  = character.characterName;
        speedText.text = "Run Speed: " + character.runSpeed;
        coinsText.text = "Coins: " + character.startingCoins;
    }
}
