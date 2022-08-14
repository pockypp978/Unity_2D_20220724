using UnityEngine;

namespace LP
{
    #region 移動腳本
    public class MoveScript : MonoBehaviour
    {
        [Range(10, 100), Header("移動速度"), SerializeField]
        private int Speed = 10;
        [Header("移動動畫參數"), SerializeField]
        private string MoveAnimatoin = "跑步開關";
        private Rigidbody2D Rigidbody;
        private Animator Animator;
    }
    #endregion
}

