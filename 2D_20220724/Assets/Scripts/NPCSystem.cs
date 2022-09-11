using UnityEngine;
using System.Collections;
using Cinemachine;

namespace LP
{
    public class NPCSystem : MonoBehaviour
    {
        /// <summary>
        /// �e������
        /// </summary>

        #region ���}���
        [SerializeField,Header("�}�l��ܫ���")]
        private KeyCode keyStartContent = KeyCode.E;
        [SerializeField, Header("NPC���")]
        public NPCData NPCData;
        private bool isArea;
        private bool isTalk;

        private TalkSystem talkSystem;
        #endregion
        #region �n�������
        private MoveScript moveScript;
        private JumpSystem jumpSystem;
        #endregion
        /// <summary>
        /// NPC CM ��v��
        /// </summary>
        private CinemachineVirtualCamera cvcCM;
        #region ���ܵe��
        private CanvasGroup grouptip;
        private string namePlayer = "Knight";
        
        private void Awake()
        {
            cvcCM = GameObject.Find(NPCData.nameCamera).GetComponent<CinemachineVirtualCamera>();
            grouptip = GameObject.Find("���ܵe��").GetComponent<CanvasGroup>();
            moveScript = FindObjectOfType<MoveScript>();
            jumpSystem = FindObjectOfType<JumpSystem>();
            talkSystem = FindObjectOfType<TalkSystem>();
        }
        #endregion

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
                cvcCM.Priority = 11;

                StopAllCoroutines();
                StartCoroutine(fadeGroup(false));
                StartCoroutine(talkSystem.StartTalk(NPCData,DialogueEND));
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
        /// <summary>
        /// ��ܵ�����B�z
        /// </summary>
        private void DialogueEND() 
        {
            isTalk = false;
            moveScript.enabled = true;
            jumpSystem.enabled = true;
            cvcCM.Priority = 9;
            //StartCoroutine(fadeGroup(true));
        }
    }
}

