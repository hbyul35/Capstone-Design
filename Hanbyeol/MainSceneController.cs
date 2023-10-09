using UnityEngine;

public class MainSceneController : MonoBehaviour
{
    public GameObject obeseCharacterPrefab;    // �� ü�� ĳ���� ������
    public GameObject diabeticCharacterPrefab; // �索 ü�� ĳ���� ������
    public GameObject athleteCharacterPrefab;  // � ���� ü�� ĳ���� ������
    public GameObject underweightCharacterPrefab; // ��ü�� ü�� ĳ���� ������
    public BodyManager bodyManager; // BodyManager ��ũ��Ʈ ����

    private void Start()
    {
        // BodyManager�� ����Ͽ� ���� ü���� �����ɴϴ�.
        BodyType currentBodyType = bodyManager.basicBodyType;

        // ���� ü���� ���� �ش� ĳ���͸� �����մϴ�.
        GameObject selectedCharacterPrefab = GetCharacterPrefab(currentBodyType);

        // ĳ���͸� �����ϰ� ��ġ�� �����մϴ�.
        Instantiate(selectedCharacterPrefab, Vector3.zero, Quaternion.identity);
    }

    private GameObject GetCharacterPrefab(BodyType bodyType)
    {
        // BodyType�� ���� ������ �������� ��ȯ�մϴ�.
        switch (bodyType)
        {
            case BodyType.Obese:
                return obeseCharacterPrefab;
            case BodyType.Diabetic:
                return diabeticCharacterPrefab;
            case BodyType.Athlete:
                return athleteCharacterPrefab;
            case BodyType.Underweight:
                return underweightCharacterPrefab;
            default:
                return null;
        }
    }
}