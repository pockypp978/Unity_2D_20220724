using UnityEngine;

namespace LP
{
	/// <summary>
	/// 敵人血量系統
	/// </summary>
	[CreateAssetMenu(menuName ="LP/Data Health Enemy")]
	public class DataHealthEnemy : DataHealth
	{
		[Header("掉落機率"), Range(0f, 1f)]
		public float dropProbility;
		[Header("掉落物件")]
		public GameObject prefabProp;
	}

}
