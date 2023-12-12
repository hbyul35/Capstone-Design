using UnityEngine;
using System.Collections.Generic;

public class FoodSpawner : MonoBehaviour
{
    // ������ ���� �������� ���� �ִ� ����Ʈ
    public List<GameObject> carbohydratePrefabs = new List<GameObject>();
    public List<GameObject> proteinPrefabs = new List<GameObject>();
    public List<GameObject> fatPrefabs = new List<GameObject>();
    public List<GameObject> sugarPrefabs = new List<GameObject>();
    public List<GameObject> fiberPrefabs = new List<GameObject>();
    public List<GameObject> vitaminPrefabs = new List<GameObject>();

    // �� ���� �����յ��� ���� Ȯ��
    private float carbohydrateProbability = 0.15f;
    private float proteinProbability = 0.40f;
    private float fatProbability = 0.15f;
    private float sugarProbability = 0.15f;
    private float fiberProbability = 0.15f;
    private float vitaminProbability = 0.05f;

    void Start()
    {
        SpawnFood(carbohydratePrefabs, carbohydrateProbability);
        SpawnFood(proteinPrefabs, proteinProbability);
        SpawnFood(fatPrefabs, fatProbability);
        SpawnFood(sugarPrefabs, sugarProbability);
        SpawnFood(fiberPrefabs, fiberProbability);
        SpawnFood(vitaminPrefabs, vitaminProbability);
    }

    void SpawnFood(List<GameObject> foodPrefabs, float spawnProbability)
    {
        float randomValue = Random.value; // 0���� 1 ������ ���� �� ����

        // ���� ���� ���� Ȯ������ ���� �� �ش� ���� �������� ����
        if (randomValue <= spawnProbability)
        {
            int randomIndex = Random.Range(0, foodPrefabs.Count); // ������ �ε��� ����
            GameObject selectedFoodPrefab = foodPrefabs[randomIndex];

            // ���õ� ���� �������� ���� (��ġ�� ������ ������Ʈ�� ��ġ�� ����)
            Instantiate(selectedFoodPrefab, transform.position, Quaternion.identity);
        }
    }
}