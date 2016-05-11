using UnityEngine;

namespace GameModel
{
    public class ButtonParamsData : MonoBehaviour
    {
        [SerializeField] private ParamTypes paramType;

        public ParamTypes ParamType 
        {
            get { return paramType; }
        }
    }
}
