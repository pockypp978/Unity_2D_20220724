using UnityEngine;
namespace LP 
{
	public class AttackData : ScriptableObject
	{
		[Header("§ðÀ»¸ê®Æ"), Range(0, 1000)]
		public int attack = 30;
		public Color attackAreaColor = new Color(1, 0.2f, 0.5f, 0.3f);
		public Vector3 attackAreaSize = Vector3.one;
		public Vector3 attackAreaOffset;


	}

}

