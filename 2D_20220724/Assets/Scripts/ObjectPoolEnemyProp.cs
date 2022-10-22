using LP;
using UnityEngine;
namespace LP
{
    /// <summary>
    /// 敵人掉落道具
    /// </summary>
    public class ObjectPoolEnemyProp : ObjectPoolBase
    {
        /// <summary>
        /// 靜態實體欄位
        /// </summary>
        public static ObjectPoolEnemyProp instance;

        private void Start()
        {
            //指定為此類別
            instance = this;
        }
    }

}
