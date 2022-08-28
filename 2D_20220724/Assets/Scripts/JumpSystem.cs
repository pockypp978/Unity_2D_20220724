using UnityEngine;
namespace LP
{
	public class JumpSystem : MonoBehaviour
	{
		#region ���
		[SerializeField, Header("���D����"), Range(0, 100)]
		private float jump = 5;
		[SerializeField, Header("���D�}��")]
		private string jumpbool = ("���D�}��");
		private Rigidbody2D rig;
		private Animator ani;
		#endregion

		#region �a�O
		[SerializeField, Header("�ˬd�a�O�C��")]
		private Color checkGroundColor = new Color(1, 0, 0.2f, 0.3f);
		[Header("�ˬd�a�O�P�ؤo")]
		[SerializeField] private Vector3 checkGroundSide;
		[SerializeField] private Vector3 checkGroundOffset;

		#endregion
		#region �ƥ�
		private void Awake()
		{
			rig=GetComponent<Rigidbody2D>();
			ani=GetComponent<Animator>();
		}

		#endregion
	}
}

