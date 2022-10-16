using UnityEngine;
using TMPro;

namespace LP
{
	public class MissionSystem : MonoBehaviour
	{
		public static MissionSystem instance;

		[SerializeField, Header("任務需求數量"), Range(1, 100)]
		private int countMax = 30;
		[SerializeField, Header("要更新的NPC")]
		private NPCSystem npcTarget;
		[SerializeField, Header("要更新的對話資料")]
		private NPCData nPCData;

		private int countCurrent;
		private TextMeshProUGUI textMission;

		private void Awake()
		{
			instance = this;
			textMission = GameObject.Find("任務").GetComponent<TextMeshProUGUI>();
			textMission.text = $"{countCurrent}/{countMax}";
			UpdateCountAndUI();
		}

		public void UpdateCountAndUI(int increase = 0)
		{
			countCurrent += increase;
			textMission.text = $"{countCurrent}/{countMax}";

			if (countCurrent >= countMax) MissionComplete();
		}

		private void MissionComplete()
        {
			npcTarget.nPCData = nPCData;
        }
	}

}
