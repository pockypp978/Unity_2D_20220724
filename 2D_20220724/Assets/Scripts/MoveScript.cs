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

        }
        #endregion
        #region �ƥ�

        private void Awake()
        {

        }

        private void Update()
        {

        }
        #endregion
    }
}

