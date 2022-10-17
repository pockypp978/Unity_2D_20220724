using UnityEngine;
using TMPro;

namespace LP
{
	public class MissionSystem : MonoBehaviour
	{
		public static MissionSystem instance;

		[SerializeField, Header("���ȻݨD�ƶq"), Range(1, 100)]
		private int countMax = 30;
		[SerializeField, Header("�n��s��NPC")]
		private NPCSystem npcTarget;
		[SerializeField, Header("�n��s����ܸ��")]
		private NPCData nPCData;

		private int countCurrent;
		private TextMeshProUGUI textMission;

		private void Awake()
		{
			instance = this;
			textMission = GameObject.Find("����").GetComponent<TextMeshProUGUI>();
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
