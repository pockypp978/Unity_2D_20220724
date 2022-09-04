using UnityEngine;
using TMPro;
using System.Collections;

public class TalkSystem : MonoBehaviour
{
    //畫布對話
    private CanvasGroup talkGroup;
    //NPC名稱
    private TextMeshProUGUI nameNPC;
    //對話內容
    private TextMeshProUGUI talkContext;
    [SerializeField,Header("對話框三角形")]
    private GameObject goTriangle;

    public void StartTalk()
    {
        StartCoroutine(fadeGroup());
    }

    private void Awake()
    {
        talkGroup = GameObject.Find("畫布對話").GetComponent<CanvasGroup>();
        nameNPC = GameObject.Find("NPC名稱").GetComponent<TextMeshProUGUI>();
        talkContext = GameObject.Find("對話內容").GetComponent<TextMeshProUGUI>();
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
