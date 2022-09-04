using UnityEngine;

namespace LP
{
    public class NPCSystem : MonoBehaviour
    {
        /// <summary>
        /// 畫布提示
        /// </summary>
        private CanvasGroup grouptip;
        private string namePlayer = "Knight";
        private void Awake()
        {
            grouptip = GameObject.Find("提示畫布").GetComponent<CanvasGroup>();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name.Contains(namePlayer))
            {
                grouptip.alpha = 1;
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.name.Contains(namePlayer))
            {
                grouptip.alpha = 0;
            }
        }
    }
}

