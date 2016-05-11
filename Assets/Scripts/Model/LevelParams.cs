namespace GameModel
{
    public class LevelParams : ILevelParams
    {
        public LevelParams(int number, string name, float duration = 1f, int taskCount = 1, int winCondition = 1)
        {
            LevelNumber = number;
            LevelName = name;
            LevelDuration = duration;
            TaskCount = taskCount;
            WinCondition = winCondition;
        }

        public int LevelNumber { get; private set; }

        public string LevelName { get; private set; }

        public float LevelDuration { get; private set; }

        public int TaskCount { get; private set; }

        public int WinCondition { get; private set; }
    }

    public enum ParamTypes
    {
        Level1,
        Level2
    }
}
