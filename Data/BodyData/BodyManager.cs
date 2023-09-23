using UnityEngine;

public enum BodyType
{
    Obese,                                               // ��
    Diabetic,                                            // �索
    Athlete,                                             // � ����
    Underweight,                                         // ��ü��
    Basic                                                // �⺻
}

public class BodyManager : MonoBehaviour
{

    // �ʱ� ���� ����
    public BodyType basicBodyType = BodyType.Basic;

    private float height = 173f;
    private float weight = 74f;

    private void Start()
    {
        SetBodyType(basicBodyType);
    }

    // ü�� ���� �޼���
    public void SetBodyType(BodyType newBodyType)
    {
        basicBodyType = newBodyType;

        // ü���� ���� �ʱ� ���� ����
        switch (newBodyType)
        {
            case BodyType.Obese:
                height = 173f;
                weight = 90f;
                break;
            case BodyType.Diabetic:
                height = 173f;
                weight = 74f;
                break;
            case BodyType.Athlete:
                height = 173f;
                weight = 74f;
                break;
            case BodyType.Underweight:
                height = 173f;
                weight = 55f;
                break;
        }
    }

}