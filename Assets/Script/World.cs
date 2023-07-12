using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
    public enum Battle
    {
        Start,
        Scramble,
        Battle,
        End,
    }
    public enum TurnPlayer
    {
        None,
        Player,
        Enemy,
    }
    public enum Phase
    {
        None,
        Start,
        Draw,
        Future,
        Main,
        End,
    }
    public Battle battle;
    public TurnPlayer turnPlayer;
    public Phase phase;

    private void Start()
    {
        battle = Battle.Start;
        turnPlayer = TurnPlayer.None;
        phase = Phase.None;
    }


}
