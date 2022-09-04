using UnityEngine;
using TMPro;
using System.Collections;

public class TalkSystem : MonoBehaviour
{
    //�e�����
    private CanvasGroup talkGroup;
    //NPC�W��
    private TextMeshProUGUI nameNPC;
    //��ܤ��e
    private TextMeshProUGUI talkContext;
    [SerializeField,Header("��ܮؤT����")]
    private GameObject goTriangle;

    public void StartTalk()
    {
        StartCoroutine(fadeGroup());
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

}
