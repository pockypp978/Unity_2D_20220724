using UnityEngine;

namespace LP 
{
	/// <summary>
	/// ��q�t��
	/// </summary>
	public class PlayerHealth : HealthSystem
	{
        protected override void Dead()
        {
            base.Dead();
            gameObject.layer = 8;
        }
    }
}
