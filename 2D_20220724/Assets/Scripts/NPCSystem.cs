using UnityEngine;

namespace LP
{
    public class NPCSystem : MonoBehaviour
    {
        /// <summary>
        /// �e������
        /// </summary>
        private CanvasGroup grouptip;
        private string namePlayer = "Knight";
        private void Awake()
        {
            grouptip = GameObject.Find("���ܵe��").GetComponent<CanvasGroup>();
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

