using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public InputManager inputManager;

    private int scorePlayer = 0;
    private int scoreComputer = 0;
    private RpsType computerRpsType;

    public void TryScore(RpsType type)
    {
        inputManager.DisplayPlayerRpsImage(type);

        var computerRps = ChooseNewComputerRpsType();

        if (type == RpsType.Paper)
        {
            if (computerRps == RpsType.Rock)
            {
                scorePlayer++;
            }
            else if (computerRps == RpsType.Scissors)
            {
                scoreComputer++;
            }
        }

        if (type == RpsType.Rock)
        {
            if (computerRps == RpsType.Scissors)
            {
                scorePlayer++;
            }
            else if (computerRps == RpsType.Paper)
            {
                scoreComputer++;
            }
        }

        if (type == RpsType.Scissors)
        {
            if (computerRps == RpsType.Paper)
            {
                scorePlayer++;
            }
            else if (computerRps == RpsType.Rock)
            {
                scoreComputer++;
            }
        }

        inputManager.UpdateScore(scorePlayer, scoreComputer);
    }

    public RpsType ChooseNewComputerRpsType()
    {
        int randomValue = Random.Range(0, 3);

        switch (randomValue)
        {
            case 0:
                computerRpsType = RpsType.Rock;
                break;
            case 1:
                computerRpsType = RpsType.Paper;
                break;
            case 2:
                computerRpsType = RpsType.Scissors;
                break;
        }

        inputManager.DisplayComputerRpsImage(computerRpsType);
        return computerRpsType;
    }

    public enum RpsType
    {
        Rock,
        Paper,
        Scissors
    }
}
