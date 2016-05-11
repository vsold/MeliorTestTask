using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace GameController
{
    public class LevelGUIController : MonoBehaviour
    {
        [SerializeField] private Button backButton;

        private void Start()
        {
            backButton.onClick.AddListener(OnBackButtonClick);
        }

        private void OnBackButtonClick()
        {
            SceneManager.LoadScene("Main");
        }
    }
}
