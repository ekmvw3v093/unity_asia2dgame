using UnityEngine;

namespace KID
{ 
    /// <summary>
    /// �ĤH�o�g�t��
    /// </summary>
    public class EnemyFire : FireSystem
    {
        [SerializeField, Header("�ͦ��l�u�y��"), Range(0, 3)]
        private float interval = 1.5f;

        private void Awake()
        {
            InvokeRepeating("SpawnBullet", 0, interval);
        }           
    } 
}
