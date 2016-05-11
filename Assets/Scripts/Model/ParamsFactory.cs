using GameModel;

namespace GameModel
{
    public class ParamsFactory
    {
        public ILevelParams GetParams(ParamTypes level)
        {
            switch (level)
            {
                case ParamTypes.Level1:
                    return new LevelParams(1, "Under World", 20f, 2, 2);
                case  ParamTypes.Level2:
                    return new LevelParams(2, "Never Land", 40f, 12, 8);
                default:
                    return new LevelParams(0, "Empty Level");
            }
        }
    }
}
