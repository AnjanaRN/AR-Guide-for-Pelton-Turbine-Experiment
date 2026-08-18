using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARPlaneLockManager : MonoBehaviour
{
    public ARPlaneManager planeManager;
    public ARTrackedImageManager imageManager;

    private bool isLocked = false;

    void OnEnable()
    {
        imageManager.trackedImagesChanged += OnTrackedImagesChanged;
    }

    void OnDisable()
    {
        imageManager.trackedImagesChanged -= OnTrackedImagesChanged;
    }

    void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs args)
    {
        if (isLocked)
            return;

        if (args.added.Count > 0)
        {
            isLocked = true;

            planeManager.enabled = false;

            foreach (var plane in planeManager.trackables)
                plane.gameObject.SetActive(false);

            Debug.Log("Plane locked after QR detection!");
        }
    }
}