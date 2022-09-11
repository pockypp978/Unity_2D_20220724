using UnityEngine;
using TMPro;
using System.Collections;
using LP;
using UnityEngine.UI;

public class TalkSystem : MonoBehaviour
{
    //畫布對話
    private CanvasGroup talkGroup;
    //NPC名稱
    private TextMeshProUGUI nameNPC;
    //對話內容
    private TextMeshProUGUI talkContext;
    [SerializeField, Header("對話框三角形")]
    private GameObject goTriangle;
    [SerializeField, Header("對話打字效果間隔"), Range(0, 0.5f)]
    private float intervalTypeEffect = 0.05f;
    [SerializeField, Header("對話按鍵")]
    private KeyCode keyDialogue = KeyCode.E;
    /// <summary>
    /// 當前NPC資料
    /// </summary>
    private NPCData nPCData;

    public IEnumerator StartTalk(NPCData _nPCData)
    {
        nPCData = _nPCData;                                         //將 NPC 傳過來的資料儲存
        nameNPC.text = nPCData.NPCName;                             //更新 NPC 名稱
        talkContext.text = "";                                      //清空 NPC 對話內容

        yield return StartCoroutine(fadeGroup());
        StartCoroutine(TypeEffect());
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

    private IEnumerator TypeEffect() 
    {
		for (int j = 0; j < nPCData.contents.Length; j++)         //遍巡 每一段對話
		{
            string content = nPCData.contents[j];                 //取得 每一筆對話內容
            goTriangle.SetActive(false);                         
            talkContext.text = "";    
            for (int i = 0; i < content.Length; i++)              //迴圈遍巡每一個字
            {
                talkContext.text += content[i];                   //對話內容 累加 每一個字
                yield return new WaitForSeconds(0.1f);            //等待
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
