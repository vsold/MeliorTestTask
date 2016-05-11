using UnityEngine;
namespace GameModel
{
    public interface ILevelParams
    {
        int LevelNumber { get; }
        string LevelName { get; }
        float LevelDuration { get; }
        int TaskCount { get; }
        int WinCondition { get; }
    }
}

