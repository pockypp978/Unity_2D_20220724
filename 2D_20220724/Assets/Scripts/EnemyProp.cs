using UnityEngine;
namespace LP
{
    /// <summary>
    /// 敵人道具:被目標碰到後回收到物件池內
    /// </summary>
    public class EnemyProp : MonoBehaviour
    {
        [SerializeField, Header("目標物件名稱")]
        private string nameTarget = "Knight";

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.name.Contains(nameTarget))
            {
                ObjectPoolEnemyProp.instance.ReleasePoolObject(gameObject);
            }
        }


    }

}
