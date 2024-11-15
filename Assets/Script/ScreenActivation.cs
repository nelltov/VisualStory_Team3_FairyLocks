using UnityEngine;

public class ScreenActivation : MonoBehaviour
{
    public static ScreenActivation Instance { get; private set; }
    public bool dontDestroyOnLoad;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            if (dontDestroyOnLoad)
            {
                DontDestroyOnLoad(gameObject);
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        // Activate the main display (Display 1)
        if (Display.displays.Length > 0)
        {
            Display.displays[0].Activate();
        }

        RefreshRate refreshRate = new RefreshRate();
        refreshRate.numerator = 60;
        refreshRate.denominator = 1;

        // Activate the second display (Display 2) with a 480x800 resolution
        if (Display.displays.Length > 1)
        {
            Display.displays[1].Activate(480, 800, refreshRate);
        }
    }
}
