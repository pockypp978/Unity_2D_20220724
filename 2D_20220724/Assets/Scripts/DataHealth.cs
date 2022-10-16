using UnityEngine;

namespace LP
{
	[CreateAssetMenu(menuName = "LP/Data Health", fileName = "Data Health")]
	public class DataHealth : ScriptableObject
	{
		[Header("��q"), Range(0, 1000)]
		public float hp;
		[Header("���`�ʵe�Ѽ�")]
		public string parDead;

	}

}
