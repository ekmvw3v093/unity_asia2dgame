using UnityEngine;

namespace KID
{
    /// <summary>
    /// ���a�o�g�t��
    /// </summary>
    public class PlayerFire : FireSystem
    {
        //�������a�欰:��L�A�ƹ��AĲ���P�n��
        private void Update()
        {
            // �p�G ���a���U �ťի� �N�ͦ��l�u
            if (Input.GetKey(KeyCode.Space))
            {
                SpawnBullet();


            }

        }
    }
}
