using UnityEngine;

namespace KID
{
    /// <summary>
    /// 2D�������
    /// </summary>
    public class AirplaneContral : MonoBehaviour
    {
        [Header("���ʳt��")]
        [SerializeField, Range(0, 10)]
        private float speedVertical = 3.5f;
        [SerializeField, Range(0, 10)]
        private float speedHorizontal = 4f;
        [Header("�Ϥ�")]
        [SerializeField] private Sprite pictureUp;
        [SerializeField] private Sprite pictureMiddle;
        [SerializeField] private Sprite pictureDown;
        [SerializeField, Header("�Ϥ���V����")]
        private SpriteRenderer spr;

        private void Update()
        {
            // �W�U WS - Vertical
            // �W W +1
            // �U S -1
            //�S�� 0
            // ��J.���o�b�V��(�b�V�W��) - ���o���a���U���䪺��
            float v = Input.GetAxis("Vertical");
            //print("<color=red>���a�W�U����:" + v + "</color>");

            // ���k AD - Horizontal
            float h = Input.GetAxis("Horizontal");

            transform.Translate(
                speedHorizontal * Time.deltaTime * h,
                speedVertical * Time.deltaTime * v,
                0);

            // �p�G v �j�� 0 �N ���W
            if (v > 0)
            {
                //print("���W");
                spr .sprite = pictureUp;
            }
            //�p�G v �p�� 0 �N ���U
            if (v < 0)
            {
                //print("���U");

                spr.sprite = pictureDown;
            }
            //�p�G v ���� 0 �N ����
            if (v == 0)
            {
                //print("����");

                spr.sprite = pictureMiddle;

            }
        }
    }
}
