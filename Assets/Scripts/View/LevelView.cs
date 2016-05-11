using GameModel;
using UnityEngine;

namespace GameView
{
    public class LevelView : MonoBehaviour
    {
        [SerializeField] private Transform parent;
        [SerializeField] private GameObject textPrefab;

        [SerializeField] private float xPos = 50f;
        [SerializeField] private float yStartPos = 50f;
        [SerializeField] private float lineSpace = 50f;
        private int lineNum = 0;

        public void Init(ILevelParams levelParams)
        {

            CreateParamView("levelNumber", "Level " + levelParams.LevelNumber);
            CreateParamView("levelName", "Welcome to " + levelParams.LevelName);
            CreateParamView("levelDuration", "Time to complete: " + levelParams.LevelDuration);
            CreateParamView("tasksCount", "Tasks count: " + levelParams.TaskCount);
            CreateParamView("winCondition", "Complete at least " + levelParams.WinCondition + " tasks to finish level!");
        }

        private Vector2 GetNewParamPosition()
        {
            Vector2 pos = new Vector2(xPos, yStartPos - lineNum*lineSpace);
            lineNum ++;
            return pos;
        }

        private void CreateParamView(string name, string text)
        {
            GameObject go = Instantiate(textPrefab);
            go.name = name;
            Vector2 position = GetNewParamPosition();
            var goTransform = go.transform;
            if (parent != null)
            {
                goTransform.parent = parent;
            }
            goTransform.localPosition = new Vector3(position.x, position.y, goTransform.localPosition.z);

            TextMesh textMesh = go.GetComponent<TextMesh>();
            textMesh.text = text;
        }
    }
}
