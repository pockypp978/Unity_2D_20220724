using UnityEngine;
namespace LP 
{
	/// <summary>
	/// 攻擊資料
	/// </summary>
	[CreateAssetMenu(menuName ="LP/Attack Data",fileName = "Attack Data")] 
	public class AttackData : ScriptableObject
	{
		[Header("攻擊資料"), Range(0, 1000)]
		public int attack = 30;
		public Color attackAreaColor = new Color(1, 0.2f, 0.5f, 0.3f);
		public Vector3 attackAreaSize = Vector3.one;
		public Vector3 attackAreaOffset;
		public LayerMask attackAreaLayer;
		public string parAttack = "攻擊觸發";
		[Range(0, 3)]
		public float attackTime = 1.5f;
		[Range(0, 2)]
		public float delaySendDmage = 0.4f;
	}

}

