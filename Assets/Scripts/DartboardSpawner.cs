using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class DartboardSpawner : MonoBehaviour
{
    public GameObject dartboardPrefab; 
    private ARTrackedImageManager imageManager;

    void Awake()
    {
        imageManager = GetComponent<ARTrackedImageManager>();
    }

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
        foreach (var trackedImage in args.added)
        {
            if (trackedImage.referenceImage.name == "ImageTargetQR") 
            {
                Instantiate(dartboardPrefab, trackedImage.transform.position, trackedImage.transform.rotation);
            }
        }

        foreach (var trackedImage in args.updated)
        {
            
        }

        foreach (var trackedImage in args.removed)
        {
            
        }
    }
}
