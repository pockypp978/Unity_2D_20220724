using UnityEngine;

namespace LP 
{
	/// <summary>
	/// ¦å¶q¨t²Î
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
