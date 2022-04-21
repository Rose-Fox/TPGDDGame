using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Data", menuName = "Scriptable Objects/Combat Template", order = 1)]
public class CombatTemplate : ScriptableObject
{
    public string combatName;
    public string combatDescription;
    public List<Vector3Int> playerTilePositions;
    public List<Vector3Int> enemyTilePositions;
    public List<EnemySo> enemies;
}
