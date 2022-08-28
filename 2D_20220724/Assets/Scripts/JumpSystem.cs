using UnityEngine;
namespace LP
{
	public class JumpSystem : MonoBehaviour
	{
		#region 資料
		[SerializeField, Header("跳躍高度"), Range(0, 100)]
		private float jump = 5;
		[SerializeField, Header("跳躍開關")]
		private string jumpbool = ("跳躍開關");
		private Rigidbody2D rig;
		private Animator ani;
		#endregion

		#region 地板
		[SerializeField, Header("檢查地板顏色")]
		private Color checkGroundColor = new Color(1, 0, 0.2f, 0.3f);
		[Header("檢查地板與尺寸")]
		[SerializeField] private Vector3 checkGroundSide;
		[SerializeField] private Vector3 checkGroundOffset;

		#endregion
		#region 事件
		private void Awake()
		{
			rig=GetComponent<Rigidbody2D>();
			ani=GetComponent<Animator>();
		}

		#endregion
	}
}

