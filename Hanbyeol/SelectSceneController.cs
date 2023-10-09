using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SelectSceneController : MonoBehaviour
{
    private void Start()
    {
        // PlayerPrefs���� ��õ ü�� ������ �о�ɴϴ�.
        string recommendedPhysique = PlayerPrefs.GetString("RecommendedPhysique");

        // ��õ ü���� �ش��ϴ� ���� ������Ʈ�� Ȱ��ȭ�մϴ�.
        GameObject recommendedObject = GameObject.Find(recommendedPhysique); // ��õ ü�� ������Ʈ�� �̸��� �����ϰ� ����
        recommendedObject.SetActive(true);
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}