using UnityEngine;

namespace KID
{
    /// <summary>
    /// �ˮ`�t��
    /// </summary>
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("�|�y���ˮ`���ؼ�")]
        private string nameTarget;
        [SerializeField, Header("�z���w�s��")]
        private GameObject prefabExplosion;
        [Header("���˻P�z������")]
        [SerializeField]
        private AudioClip soundHit;
        [SerializeField]
        private AudioClip soundExplosion;

        // �I���}�l�ƥ� �@��
        private void OnCollisionEnter2D(Collision2D collision)
        {
            // print ("�I���G" + collision.gameObject);

            // �p�G �I�쪫�󪺦W�� �]�t �ľ� �N�z��
            if (collision.gameObject.name.Contains(nameTarget))
            {
                Instantiate(prefabExplosion, transform.position, transform.rotation);

                SoundManager.instance.PlaySound(soundHit, new Vector2(0.7f, 0.9f));
                SoundManager.instance.PlaySound(soundExplosion, new Vector2(1.2f, 1.5f));

                // Destroy �R��
                // gameObject ������
                Destroy(gameObject);
            }

        }

        // �I�����}�ƥ� �@��
        private void OnCollisionExit2D(Collision2D collision)
        {

        }

        // �I������ƥ�
        private void OnCollisionStay2D(Collision2D collision)
        {

        }
    }
}
