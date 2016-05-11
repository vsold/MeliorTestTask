namespace GameModel
{
    public class GameDataStorage
    {
        private static GameDataStorage instance;

        public static GameDataStorage Instance
        {
            get { return instance ?? (instance = new GameDataStorage()); }
        }

        public ILevelParams LevelParams { get; set; }
    }
}

