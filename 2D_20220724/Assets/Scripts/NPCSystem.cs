using UnityEngine;

namespace LP
{
    public class NPCSystem : MonoBehaviour
    {
        /// <summary>
        /// �e������
        /// </summary>
        private CanvasGroup grouptip;
        private string namePlayer;
        private void Awake()
        {
            grouptip = GameObject.Find("���ܵe��").GetComponent<CanvasGroup>();
        }
    }
}

