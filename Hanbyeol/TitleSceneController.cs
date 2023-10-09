using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneController : MonoBehaviour
{
    // Ÿ��Ʋ ȭ�鿡�� "Start" ��ư�� ���� �� ȣ��� �Լ�
    public void StartGame()
    {
        // "InformationScene" ������ �̵�
        SceneManager.LoadScene("InformationScene");
    }

    // Ÿ��Ʋ ȭ�鿡�� "Quit" ��ư�� ���� �� ȣ��� �Լ�
    public void QuitGame()
    {
        // ���� ���� (�����Ϳ����� �������� ���� �� �ֽ��ϴ�)
        Application.Quit();
    }
}