using UnityEngine;

namespace LP
{
	[CreateAssetMenu(menuName ="LP/NPC Data",fileName ="NPC Data")]
	public class NPCData : ScriptableObject
	{
		[Header("NPC名稱")]
		public string NPCName;
		[Header("對話內容"),TextArea(3,10)]
		public string[] contents;
		[Header("攝影機名稱")]
		public string nameCamera;
	}
}

