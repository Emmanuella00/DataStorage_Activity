# Runner Data Storage (Unity 6)

Demonstrates two ways to store data in Unity: **ScriptableObjects** and **PlayerPrefs**. 

## How to Run
1. Open the project in Unity. 
2. Open `Assets/Scenes/ClassActivityScene.unity` and press **Play**.

## Task 1: ScriptableObjects
- `CharacterData.cs`: ScriptableObject with `string` name, `string` ability, `float` runSpeed, `int` startingCoins, `bool` isUnlocked. Create assets via **Assets > Create > Runner > Character Data**.
- `CharacterDisplay.cs`: control script that reads the asset and shows each value in TMP labels.

**Test:** Press Play and check the labels match the asset. Stop, edit a value on the asset, press Play again and see it update.

## Task 2: PlayerPrefs
`RunnerStats.cs` saves and loads different values: coins, distance and playername

How it works:
- `Load()` runs on start and reads saved values (with defaults on first launch).
- `Save()` writes all three values whenever coins or the name change, and on quit.
- `Update()` increases distance every frame so the stored data changes over time.

**Add Coin**, the name input and **Reset** are UI-driven.

**Test:** Press Play, add coins and change the name, then stop and press Play again. Values are restored. **Reset** clears them.
