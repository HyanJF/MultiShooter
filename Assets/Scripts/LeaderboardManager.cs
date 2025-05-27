using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Mirror;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

public class LeaderboardManager : NetworkManager
{
    public static LeaderboardManager singleton;
    private List<Jugador> players = new List<Jugador>();


    private void Awake()
    {
        if (singleton != null && singleton != this) { Destroy(this); } else { singleton = this; }
    }

    public void RegisterPlayer(Jugador elPlayer)
    {
        players.Add(elPlayer);
    }

    public List<(string name, int kills)> GetSortedScore()
    {
        return players
            .OrderByDescending(p => p.kill)
            .Select(p => (p.name, p.kill))
            .ToList();
    }
}
