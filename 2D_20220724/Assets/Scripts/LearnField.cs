using UnityEngine;

namespace LP
{
    /// <summary>
    /// 學習欄位Field，保存遊戲資料
    /// </summary>
    public class LearnField : MonoBehaviour
    {
        #region 欄位基本語法
        //汽車資料
        [Header("汽車基本資料"), Tooltip("汽車CC數")]
        public int Carcc = 2000;
        [Tooltip("汽車重量")]
        public float weight = 4.8763f;
        [Tooltip("品牌名稱"), SerializeField]
        public string brand = "閃耀魔眼";
        [Tooltip("是否有保保險"), Header("保險"), SerializeField]
        public bool HasInsurance = false;
        #endregion
        #region Uniy內資料類型
        //儲存物件
        [Header("儲存物件")]
        public GameObject Camera;

        //顏色、座標
        [Header("顏色")]
        public Color colorblack;
        public Color ColorRed = Color.red;
        public Color ColorGreen = Color.green;
        public Color ColorCustom01 = new Color(0.8f, 0.4f, 0.2f);
        [SerializeField]
        public Color ColorCustom02 = new Color(0.5f, 0.5f, 0.5f, 0.1f);
        public Color ColorCustom03 = new Color(0.5f, 0.5f, 0.5f);
        [Header("座標")]
        public Vector2 V2Right = Vector2.right;
        public Vector2 V2Left = Vector2.left;
        public Vector2 V2Up = Vector2.up;
        public Vector2 V2Down = Vector2.down;
        public Vector2 V2Custom =new Vector2(7, 7);

        //多選與列舉
        [Header("圖層")]
        public LayerMask Layer;
        [Header("鍵盤")]
        public KeyCode KeyA = KeyCode.A;
        public KeyCode KeyJump = KeyCode.Space;
        public KeyCode KeyCustom;
        [Header("燈光類型")]
        public LightType LightType;

        //元件
        [Header("元件")]
        public Transform Transform;
        public Rigidbody2D Rigidbody;
        public Animator Animator;
        #endregion
    }
}

