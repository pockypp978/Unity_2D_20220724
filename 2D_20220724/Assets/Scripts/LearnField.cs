using UnityEngine;

namespace LP
{
    /// <summary>
    /// 學習欄位Field，保存遊戲資料
    /// </summary>
    public class LearnField : MonoBehaviour
    {
        //汽車資料
       [Header("汽車基本資料")]
       public int Carcc = 2000;
       public float weight = 4.8763f;
       public string brand = "閃耀魔眼";
       [Tooltip("是否有保保險")]
       public bool HasInsurance = false;
    }
}

