using UnityEngine;
namespace LP
{
	public class JumpSystem : MonoBehaviour
	{
		#region ���
		[SerializeField, Header("���D����"), Range(0, 100)]
		private float jump = 6;
		[SerializeField, Header("���D�}��")]
		private string jumpbool = ("���D�}��");
		private Rigidbody2D rig;
		private Animator ani;
		[SerializeField, Header("�a�O�ϼh")]
		private LayerMask groundLayerCheck;
		private bool isground;
		#endregion

		#region �a�O
		[SerializeField, Header("�ˬd�a�O�C��")]
		private Color checkGroundColor = new Color(1, 0, 0.2f, 0.3f);
		[Header("�ˬd�a�O�P�ؤo")]
		[SerializeField] private Vector3 checkGroundSize;
		[SerializeField] private Vector3 checkGroundOffset;



		#endregion
		#region �ƥ�
		private void Awake()
		{
			rig=GetComponent<Rigidbody2D>();
			ani=GetComponent<Animator>();
		}

		private void OnDrawGizmos()
		{
			Gizmos.color = checkGroundColor;
			Gizmos.DrawCube(transform.position + checkGroundOffset,
				checkGroundSize);
		}

		private void Update()
		{
			checkGroud();
			Jump();
		}



		#endregion
		#region ��k

		private void checkGroud()
		{
			Collider2D hit = Physics2D.OverlapBox(transform.position + checkGroundOffset,
				checkGroundSize, 0,groundLayerCheck);
			isground = hit;
		}

		private void Jump()
		{
			if (isground && Input.GetKeyDown(KeyCode.Space))
			{
				rig.AddForce(new Vector2(0, jump * 15));
			}
		}
		#endregion
	}
}

