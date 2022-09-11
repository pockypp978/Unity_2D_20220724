using UnityEngine;
namespace LP
{
	public class JumpSystem : MonoBehaviour
	{
		#region 資料
		[SerializeField, Header("跳躍高度"), Range(0, 100)]
		private float jump = 6;
		[SerializeField, Header("跳躍開關")]
		private string jumpbool = ("跳躍開關");
		private Rigidbody2D rig;
		private Animator ani;
		[SerializeField, Header("地板圖層")]
		private LayerMask groundLayerCheck;
		private bool isground;
		#endregion

		#region 地板
		[SerializeField, Header("檢查地板顏色")]
		private Color checkGroundColor = new Color(1, 0, 0.2f, 0.3f);
		[Header("檢查地板與尺寸")]
		[SerializeField] private Vector3 checkGroundSize;
		[SerializeField] private Vector3 checkGroundOffset;



		#endregion
		#region 事件
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
		#region 方法

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

