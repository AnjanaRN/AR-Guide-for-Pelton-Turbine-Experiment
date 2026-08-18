using UnityEngine;

public class NavigationManager : MonoBehaviour
{
    [Header("Arrow")]
    public Transform arrow;

    [Range(1f, 15f)]
    public float rotationSpeed = 8f;

    [Range(1f, 10f)]
    public float moveSpeed = 5f;

    [Range(0.1f, 0.9f)]
    public float movePercentage = 0.3f;

    public float floatHeight = 0.02f;
    public float floatSpeed = 2f;

    [Header("Targets")]
    public Transform startTarget;
    public Transform stopTarget;
    public Transform valveTarget;
    public Transform motorTarget;
    public Transform inletTarget;

    private Transform currentTarget;

    private Vector3 desiredLocalPosition;
    private Vector3 currentBasePosition;

    void Start()
    {
        currentBasePosition = arrow.localPosition;
        desiredLocalPosition = currentBasePosition;

        arrow.gameObject.SetActive(false);
    }

    void Update()
    {
        if (arrow == null)
            return;

        // Smooth movement
        currentBasePosition = Vector3.Lerp(
            currentBasePosition,
            desiredLocalPosition,
            moveSpeed * Time.deltaTime
        );

        // Floating animation
        Vector3 floatingPosition = currentBasePosition;
        floatingPosition.y += Mathf.Sin(Time.time * floatSpeed) * floatHeight;

        arrow.localPosition = floatingPosition;

        // Smooth rotation
        if (currentTarget != null)
        {
            Vector3 direction = currentTarget.position - arrow.position;

            if (direction.sqrMagnitude > 0.0001f)
            {
                Quaternion targetRotation = Quaternion.LookRotation(direction);

                arrow.rotation = Quaternion.Slerp(
                    arrow.rotation,
                    targetRotation,
                    rotationSpeed * Time.deltaTime
                );
            }
        }
    }

    void PointArrow(Transform target)
    {
        currentTarget = target;

        if (!arrow.gameObject.activeSelf)
            arrow.gameObject.SetActive(true);

        // Move only part of the way toward the target
        Vector3 worldPosition = Vector3.Lerp(
            arrow.parent.position,
            target.position,
            movePercentage
        );

        desiredLocalPosition = arrow.parent.InverseTransformPoint(worldPosition);
    }

    public void GoToStart()
    {
        PointArrow(startTarget);
    }

    public void GoToStop()
    {
        PointArrow(stopTarget);
    }

    public void GoToValve()
    {
        PointArrow(valveTarget);
    }

    public void GoToMotor()
    {
        PointArrow(motorTarget);
    }

    public void GoToInlet()
    {
        PointArrow(inletTarget);
    }
}