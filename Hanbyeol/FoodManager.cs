using UnityEngine;

public class FoodObject : MonoBehaviour
{
    public float carbohydrates;
    public float protein;
    public float fat;
    public float sugar;
    public float dietaryFiber;
    public float vitamins;
}

public class FoodManager : MonoBehaviour
{
    public NutrientController nutrientController;

    // ���� �浹 �̺�Ʈ ó��
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Food"))
        {
            // FoodObject ��ũ��Ʈ���� ����� ���� ������
            FoodObject food = collision.gameObject.GetComponent<FoodObject>();

            // ������ ����� ���� NutrientController�� �����Ͽ� ������Ʈ
            nutrientController.UpdateNutrients(food.carbohydrates, food.protein, food.fat, food.sugar, food.dietaryFiber, food.vitamins);

            // ���� ������Ʈ�� ����
            Destroy(collision.gameObject);
        }
    }
}