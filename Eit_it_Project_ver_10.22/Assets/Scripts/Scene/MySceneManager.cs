using UnityEngine;
using UnityEngine.SceneManagement;

public class MySceneManager : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }
    public void UserInformationSceneLoad()
    {
        SceneManager.LoadScene("UserInformationScene");
    }
    public void CharacterSelectSceneLoad()
    {
        GameManager.Instance.Calculate_BMI_And_Recommend(); // GameManager�� ����� ������ �Է���

        if (GameManager.Instance.Flag)
        {           
            SceneManager.LoadScene("CharacterSelectScene");
            GameManager.Instance.Flag = false; // ��� �� ��ȯ
        }        
    }

    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
