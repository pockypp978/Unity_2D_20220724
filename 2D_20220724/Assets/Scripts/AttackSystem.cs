using UnityEngine;
using System.Collections;
namespace LP
{
	public class AttackSystem : MonoBehaviour
	{
		[SerializeField, Header("攻擊資料")]
		private AttackData attackData;

		private Animator ani;
		private bool isAttacking;
		private void OnDrawGizmos()
		{
			Gizmos.color = attackData.attackAreaColor;
			Gizmos.DrawCube(
				transform.position + 
				transform.TransformDirection(attackData.attackAreaOffset),
				attackData.attackAreaSize);
		}

		private void CheckAttackArea() 
		{
			Collider2D hit = Physics2D.OverlapBox(
				transform.position +
				transform.TransformDirection(attackData.attackAreaOffset),
				attackData.attackAreaSize,0,attackData.attackAreaLayer);
			print("攻擊到" + hit);
		}

		protected virtual void Awake()
		{
			ani = GetComponent<Animator>();
		}
		// virtual 虛擬：允許子類別使用複寫關鍵字 override
		/// <summary>
		/// 開始攻擊
		/// </summary>
		public virtual void StartAttack() 
		{
			if (isAttacking) return;

			isAttacking = true;
			ani.SetTrigger(attackData.parAttack);
			StartCoroutine(Attacking());
		}
		/// <summary>
		/// 攻擊中
		/// </summary>
		private IEnumerator Attacking() 
		{
			yield return new WaitForSeconds(attackData.delaySendDmage);
			CheckAttackArea();
			yield return new WaitForSeconds(attackData.attackTime);
			isAttacking = false;
			StopAttack();
		}
		//protected 保護級別：允許子類別存取或複寫
		protected virtual void StopAttack()
        {

        }
	}

}
