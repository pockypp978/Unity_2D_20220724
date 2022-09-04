using UnityEngine;
using System.Collections;

namespace LP
{
    public class NPCSystem : MonoBehaviour
    {
        /// <summary>
        /// �e������
        /// </summary>

        #region ���}���
        private KeyCode keyStartContent = KeyCode.E;
        private bool isArea;
        private bool isTalk;
        #endregion
        #region �n�������
        private MoveScript moveScript;
        private JumpSystem jumpSystem;
        #endregion
        #region ���ܵe��
        private CanvasGroup grouptip;
        private string namePlayer = "Knight";
        
        private void Awake()
        {
            grouptip = GameObject.Find("���ܵe��").GetComponent<CanvasGroup>();
            moveScript = FindObjectOfType<MoveScript>();
            jumpSystem = FindObjectOfType<JumpSystem>();
        }

        private void Update()
        {
            InputAndStartTalk();
        }

        private void InputAndStartTalk()
        {
            if (isTalk) return;
            if(isArea && Input.GetKeyDown(keyStartContent))
            {
                isTalk = true;
                moveScript.enabled = false;
                jumpSystem.enabled = false;

                StopAllCoroutines();
                StartCoroutine(fadeGroup(false));
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name.Contains(namePlayer))
            {
                isArea = true;
                StopAllCoroutines();
                StartCoroutine(fadeGroup());
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.name.Contains(namePlayer))
            {
                isArea = false;
                StopAllCoroutines();
                StartCoroutine(fadeGroup(false));
            }
        }

        private IEnumerator fadeGroup(bool fade = true)
        {
            grouptip.alpha = fade ? 0 : 1;
            float increase = fade ? 0.1f : -0.1f;
            for (int i = 0; i < 10; i++)
            {
                grouptip.alpha += increase;
                yield return new WaitForSeconds(0.1f);
            }
        }
        #endregion
    }
}

