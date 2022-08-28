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
            float h = Input.GetAxis("Horizontal");
            print("水平方向按鍵值" + h);
            Rigidbody.velocity = new Vector2(h * Speed, Rigidbody.velocity.y);
            Animator.SetBool(MoveAnimatoin, h != 0);

            if (Mathf.Abs(h) < 0.1f) { return; };

            float yangle = h > 0 ? 0 : 180;
            transform.eulerAngles = new Vector3(0, yangle, 0);
        }
        #endregion
        #region 事件

        private void Awake()
        {
            Animator = GetComponent<Animator>();
            Rigidbody = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            Move();
        }
        #endregion
    }
}

