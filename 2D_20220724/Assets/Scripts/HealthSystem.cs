using Unity.Collections;
using UnityEngine;

namespace LP
{
	/// <summary>
	/// 血量系統
	/// </summary>
	public class HealthSystem : MonoBehaviour
	{
		[SerializeField, Header("血量資料")]
		protected DataHealth dataHealth;
		[SerializeField, Header("要關閉的元件")]
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
		/// 受傷
		/// </summary>
		/// <param name="getDamage">接收到的傷害</param>
		public virtual void Hurt(float getDamage)
		{
			hp -= getDamage;
			if (hp <= 0) Dead();

			print(gameObject + "血量" + hp);
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
