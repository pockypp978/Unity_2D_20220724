using UnityEngine;

namespace LP
{
    /// <summary>
    /// �ǲ����Field�A�O�s�C�����
    /// </summary>
    public class LearnField : MonoBehaviour
    {
        #region ���򥻻y�k
        //�T�����
        [Header("�T���򥻸��"), Tooltip("�T��CC��")]
        public int Carcc = 2000;
        [Tooltip("�T�����q")]
        public float weight = 4.8763f;
        [Tooltip("�~�P�W��"), SerializeField]
        public string brand = "�{ģ�]��";
        [Tooltip("�O�_���O�O�I"), Header("�O�I"), SerializeField]
        public bool HasInsurance = false;
        #endregion
        #region Uniy���������
        //�x�s����
        [Header("�x�s����")]
        public GameObject Camera;

        //�C��B�y��
        [Header("�C��")]
        public Color colorblack;
        public Color ColorRed = Color.red;
        public Color ColorGreen = Color.green;
        public Color ColorCustom01 = new Color(0.8f, 0.4f, 0.2f);
        [SerializeField]
        public Color ColorCustom02 = new Color(0.5f, 0.5f, 0.5f, 0.1f);
        public Color ColorCustom03 = new Color(0.5f, 0.5f, 0.5f);
        [Header("�y��")]
        public Vector2 V2Right = Vector2.right;
        public Vector2 V2Left = Vector2.left;
        public Vector2 V2Up = Vector2.up;
        public Vector2 V2Down = Vector2.down;
        public Vector2 V2Custom =new Vector2(7, 7);

        //�h��P�C�|
        [Header("�ϼh")]
        public LayerMask Layer;
        [Header("��L")]
        public KeyCode KeyA = KeyCode.A;
        public KeyCode KeyJump = KeyCode.Space;
        public KeyCode KeyCustom;
        [Header("�O������")]
        public LightType LightType;

        //����
        [Header("����")]
        public Transform Transform;
        public Rigidbody2D Rigidbody;
        public Animator Animator;
        #endregion
    }
}

