using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    public Text scoreText;
    public Image computerSprite;
    public Image playerSprite;
    public GameManager gameManager;

    public void UpdateScore(int playerScore, int computerScore)
    {
        scoreText.text = $"{playerScore} - {computerScore}";
    }

    internal void DisplayComputerRpsImage(GameManager.RpsType computerRpsType)
    {
        computerSprite.sprite = Resources.Load<Sprite>(computerRpsType.ToString());
    }

    internal void DisplayPlayerRpsImage(GameManager.RpsType playerRpsType)
    {
        playerSprite.sprite = Resources.Load<Sprite>(playerRpsType.ToString());
    }

    public void RockButtonClick()
    {
        gameManager.TryScore(GameManager.RpsType.Rock);
    }

    public void PaperButtonClick()
    {
        gameManager.TryScore(GameManager.RpsType.Paper);
    }

    public void ScissorsButtonClick()
    {
        gameManager.TryScore(GameManager.RpsType.Scissors);
    }
}
