using UnityEngine;

namespace LP
{
	/// <summary>
	/// �ĤH��q�t��
	/// </summary>
	[CreateAssetMenu(menuName ="LP/Data Health Enemy")]
	public class DataHealthEnemy : DataHealth
	{
		[Header("�������v"), Range(0f, 1f)]
		public float dropProbility;
		[Header("��������")]
		public GameObject prefabProp;
	}

}
