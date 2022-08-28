using UnityEngine;

namespace LP
{
    #region ���
    public class MoveScript : MonoBehaviour
    {
        [Range(10, 100), Header("���ʳt��"), SerializeField]
        private int Speed = 10;
        [Header("���ʰʵe�Ѽ�"), SerializeField]
        private string MoveAnimatoin = "�]�B�}��";
        private Rigidbody2D Rigidbody;
        private Animator Animator;

        #endregion
        #region ��k
        private void Move()
        {
            float h = Input.GetAxis("Horizontal");
            print("������V�����" + h);
            Rigidbody.velocity = new Vector2(h * Speed, Rigidbody.velocity.y);
            Animator.SetBool(MoveAnimatoin, h != 0);

            if (Mathf.Abs(h) < 0.1f) { return; };

            float yangle = h > 0 ? 0 : 180;
            transform.eulerAngles = new Vector3(0, yangle, 0);
        }
        #endregion
        #region �ƥ�

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

