using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

namespace KID
{
    /// <summary>
    ///  �����޲z��
    /// </summary>
    public class FinalManager : MonoBehaviour
    {
        public static FinalManager instance;

        /// <summary>
        ///  �����e��
        /// </summary>
        private CanvasGroup groupFinal;
        /// /// <summary>
        ///  �������D
        /// </summary>
        private TextMeshProUGUI textTitle;
        /// /// <summary>
        ///  ���s�C��
        /// </summary>
        private Button btnReplay;

        private void Awake()
        {
            instance = this;

            groupFinal = GameObject.Find("�����e��").GetComponent<CanvasGroup>();
            textTitle = GameObject.Find("�������D").GetComponent<TextMeshProUGUI>();
            btnReplay = GameObject.Find("���s�C��").GetComponent<Button>();
            btnReplay.onClick.AddListener(Replay);
        }

        /// <summary>
        /// �C������
        /// </summary>
        /// <param name="title">�C�����D</param>
        public void GameOver(string title)
        {
            textTitle.text = title;
            StartCoroutine(FadeIn());
        }

        /// <summary>
        /// �H�J
        /// </summary>
        private IEnumerator FadeIn()
        {
            for (int i = 0; i < 10; i++)
            {
                groupFinal.alpha += 0.1f;
                yield return new WaitForSeconds(0.02f);
            }

            groupFinal.interactable = true;
            groupFinal.blocksRaycasts = true;
        }

        /// <summary>
        ///  ���s�C��
        /// </summary>
        private void Replay()
        {
            SceneManager.LoadScene("�}�Y���");
        }
    }

}

