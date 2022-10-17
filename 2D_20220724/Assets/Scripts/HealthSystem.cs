using Unity.Collections;
using UnityEngine;

namespace LP
{
	/// <summary>
	/// ��q�t��
	/// </summary>
	public class HealthSystem : MonoBehaviour
	{
		[SerializeField, Header("��q���")]
		protected DataHealth dataHealth;
		[SerializeField, Header("�n����������")]
		private Behaviour[] behavioursToClose;

		protected float hp;
		protected float hpMax;

		private Animator ani;

		protected virtual void Awake()
		{
			hp = dataHealth.hp;
			hpMax = hp;
		}
		/// <summary>
		/// ����
		/// </summary>
		/// <param name="getDamage">�����쪺�ˮ`</param>
		public virtual void Hurt(float getDamage)
		{
			hp -= getDamage;
			if (hp <= 0) Dead();

			print(gameObject + "��q" + hp);
		}

		protected virtual void Dead() 
		{
			hp = 0;
			ani.SetBool(dataHealth.parDead, true);

			for(int i = 0; i < behavioursToClose.Length; i++)
            {
				behavioursToClose[i].enabled = false;
            }
		}
	}

	

}
