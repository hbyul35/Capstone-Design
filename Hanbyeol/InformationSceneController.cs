using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class InformationSceneController : MonoBehaviour
{
    public TMP_InputField weightInputField;
    public TMP_InputField heightInputField;
    public TMP_Dropdown purposeDropdown;

    public void CalculateBMIAndRecommend()
    {
        // ����ڷκ��� �Է¹��� �����Կ� Ű�� ������
        float weight, height;

        // float ���·� ��ȯ �� ����
        if (float.TryParse(weightInputField.text, out weight) && float.TryParse(heightInputField.text, out height))
        {
            // BMI ���
            float bmi = weight / (height * height);

            // � ������ ���� ��õ ü���� ����
            string recommendedPhysique = GetRecommendedPhysique(bmi, purposeDropdown.value);

            // ��õ ü���� PlayerPrefs�� ����
            PlayerPrefs.SetString("RecommendedPhysique", recommendedPhysique);
            PlayerPrefs.Save();
        }
        else
        {
            // ��ȿ���� ���� �Է��� ���� �� ó�� (��: ��� ǥ�� ��)
            Debug.LogWarning("Invalid input. Please enter valid weight and height.");
        }

    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("SelectScene");
    }

    private string GetRecommendedPhysique(float bmi, int purposeIndex)
    {
        // BMI�� � ������ ���� ��õ ü���� �����ϴ� ����
        if (purposeIndex == 0) // �ǰ�
        {
            return bmi < 18.5f ? "Underweight" : bmi < 24.9f ? "Normal" : "Obese";
        }
        else if (purposeIndex == 1) // ����
        {
            return "Athlete";
        }
        else if (purposeIndex == 2) // �� ����
        {
            return "Diabetic";
        }

        return "Normal";
    }
}