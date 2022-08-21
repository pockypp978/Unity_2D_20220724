using UnityEngine;

namespace LP
{
    #region 資料
    public class MoveScript : MonoBehaviour
    {
        [Range(10, 100), Header("移動速度"), SerializeField]
        private int Speed = 10;
        [Header("移動動畫參數"), SerializeField]
        private string MoveAnimatoin = "跑步開關";
        private Rigidbody2D Rigidbody;
        private Animator Animator;

        #endregion
        #region 方法
        private void Move()
        {

        }
        #endregion
        #region 事件

        private void Awake()
        {

        }

        private void Update()
        {

        }
        #endregion
    }
}

