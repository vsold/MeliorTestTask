using UnityEngine;
using GameModel;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace GameController
{
    public class MenuGUIController : MonoBehaviour
    {
        [SerializeField]
        private Button level1Button;
        [SerializeField]
        private Button level2Button;

        private ParamsFactory paramsFactory;

        private void Awake()
        {
            level1Button.onClick.AddListener(Level1ButtonOnClick);
            level2Button.onClick.AddListener(Level2ButtonOnClick);
        }

        private void Level1ButtonOnClick()
        {

            OnLevelButtonClick(level1Button);
        }

        private void Level2ButtonOnClick()
        {
            OnLevelButtonClick(level2Button);
        }

        private void OnLevelButtonClick(Button button)
        {
            SetParamsInfo(button);
            LoadGame();
        }

        private void SetParamsInfo(Button button)
        {
            ButtonParamsData data = button.GetComponent<ButtonParamsData>();
            if (data == null)
                return;

            if (paramsFactory == null)
            {
                paramsFactory = new ParamsFactory();
            }

            GameDataStorage.Instance.LevelParams = paramsFactory.GetParams(data.ParamType);
        }

        private void LoadGame()
        {
            SceneManager.LoadScene("Game");
        }
    }
}

