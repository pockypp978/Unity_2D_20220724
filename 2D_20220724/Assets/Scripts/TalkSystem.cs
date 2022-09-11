using UnityEngine;
using TMPro;
using System.Collections;
using LP;
using UnityEngine.UI;

public class TalkSystem : MonoBehaviour
{
    //�e�����
    private CanvasGroup talkGroup;
    //NPC�W��
    private TextMeshProUGUI nameNPC;
    //��ܤ��e
    private TextMeshProUGUI talkContext;
    [SerializeField, Header("��ܮؤT����")]
    private GameObject goTriangle;
    [SerializeField, Header("��ܥ��r�ĪG���j"), Range(0, 0.5f)]
    private float intervalTypeEffect = 0.05f;
    [SerializeField, Header("��ܫ���")]
    private KeyCode keyDialogue = KeyCode.E;
    /// <summary>
    /// ��eNPC���
    /// </summary>
    private NPCData nPCData;

    public IEnumerator StartTalk(NPCData _nPCData)
    {
        nPCData = _nPCData;                                         //�N NPC �ǹL�Ӫ�����x�s
        nameNPC.text = nPCData.NPCName;                             //��s NPC �W��
        talkContext.text = "";                                      //�M�� NPC ��ܤ��e

        yield return StartCoroutine(fadeGroup());
        StartCoroutine(TypeEffect());
    }

    private void Awake()
    {
        talkGroup = GameObject.Find("�e�����").GetComponent<CanvasGroup>();
        nameNPC = GameObject.Find("NPC�W��").GetComponent<TextMeshProUGUI>();
        talkContext = GameObject.Find("��ܤ��e").GetComponent<TextMeshProUGUI>();
    }

    private IEnumerator fadeGroup(bool fade = true)
    {
        talkGroup.alpha = fade ? 0 : 1;
        float increase = fade ? 0.1f : -0.1f;
        for (int i = 0; i < 10; i++)
        {
            talkGroup.alpha += increase;
            yield return new WaitForSeconds(0.1f);
        }

    }

    private IEnumerator TypeEffect() 
    {
		for (int j = 0; j < nPCData.contents.Length; j++)         //�M�� �C�@�q���
		{
            string content = nPCData.contents[j];                 //���o �C�@����ܤ��e
            goTriangle.SetActive(false);                         
            talkContext.text = "";    
            for (int i = 0; i < content.Length; i++)              //�j��M���C�@�Ӧr
            {
                talkContext.text += content[i];                   //��ܤ��e �֥[ �C�@�Ӧr
                yield return new WaitForSeconds(0.1f);            //����
            }

            goTriangle.SetActive(true);

			while (!Input.GetKeyDown(keyDialogue))
			{
                yield return null;
			}

            StartCoroutine(fadeGroup(false));
        }
    }

}
