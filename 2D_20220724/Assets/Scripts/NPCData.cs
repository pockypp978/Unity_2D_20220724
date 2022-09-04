using UnityEngine;

namespace LP
{
	[CreateAssetMenu(menuName ="LP/NPC Data",fileName ="NPC Data")]
	public class NPCData : ScriptableObject
	{
		[Header("NPC�W��")]
		public string NPCName;
		[Header("��ܤ��e"),TextArea(3,10)]
		public string[] contents;
		[Header("��v���W��")]
		public string nameCamera;
	}
}

