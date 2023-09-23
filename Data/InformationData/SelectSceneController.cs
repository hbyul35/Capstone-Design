using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SelectSceneController : MonoBehaviour
{
    public Text recommendedPhysiqueText;

    void Start()
    {
        // PlayerPrefs���� ��õ ü�� ������ �����ɴϴ�.
        string recommendedPhysique = PlayerPrefs.GetString("RecommendedPhysique", "Normal");

        // ������ ������ UI Text�� ǥ���մϴ�.
        recommendedPhysiqueText.text = "Recommended Physique: " + recommendedPhysique;
    }
}