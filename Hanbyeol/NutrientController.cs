using UnityEngine;
using UnityEngine.UI;

public class NutrientController : MonoBehaviour
{
    // �÷��̾��� ����� ����
    public float carbohydrates = 0f;                                      // ź��ȭ��
    public float protein = 0f;                                            // �ܹ���
    public float fats = 0f;                                               // ����
    public float sugar = 0f;                                              // ���
    public float dietaryFiber = 0f;                                       // ���̼���
    public float vitamins = 0f;                                           // ��Ÿ��

    // ����� ǥ�ÿ� UI �ؽ�Ʈ ��
    public TextMesh nutritionText; // UI �ؽ�Ʈ ������Ʈ�� ����

    private void Start()
    {
        // ���� ���� �� �ʱ� ����� ���� �����մϴ�.
        ResetNutrition();
    }

    // ����� �ʱ�ȭ
    public void ResetNutrition()
    {
        carbohydrates = 0f;
        protein = 0f;
        fats = 0f;
        sugar = 0f;
        dietaryFiber = 0f;
        vitamins = 0f;
    }

    public void UpdateNutrients(float carb, float prot, float fat, float sugar, float fiber, float vit)
    {
        carbohydrates += carb;
        protein += prot;
        this.fats += fat;
        this.sugar += sugar;
        dietaryFiber += fiber;
        vitamins += vit;

        // ���⼭ ����� ��ȭ�� ���� ó���� �� �� ����
        // ��: UI ������Ʈ, ����� ���� üũ, ���� ���� ���¿� ���� �ֱ� ��
    }
}