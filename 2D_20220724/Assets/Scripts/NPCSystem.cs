using UnityEngine;

namespace LP
{
    public class NPCSystem : MonoBehaviour
    {
        /// <summary>
        /// 畫布提示
        /// </summary>
        private CanvasGroup grouptip;
        private string namePlayer;
        private void Awake()
        {
            grouptip = GameObject.Find("提示畫布").GetComponent<CanvasGroup>();
        }
    }
}

