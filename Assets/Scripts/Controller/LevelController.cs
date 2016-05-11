using UnityEngine;
using GameModel;
using GameView;

namespace GameController
{
    public class LevelController : MonoBehaviour
    {
        [SerializeField] private LevelView levelView;

        void Start()
        {
            levelView.Init(GameDataStorage.Instance.LevelParams);
        }
    }
}

