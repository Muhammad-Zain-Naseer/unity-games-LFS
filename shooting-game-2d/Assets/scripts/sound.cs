using UnityEngine;

public class sound : MonoBehaviour
{
    // Static variable that holds the instance of the singleton
    public static sound Instance { get; private set; }

    // Awake is called when the script instance is being loaded
    void Awake()
    {
        // Check if an Instance already exists
        if (Instance == null)
        {
            // Assign this object to the Instance
            Instance = this;
            // Make sure this object persists across scene changes
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            // If an Instance already exists and it's not this instance, destroy this object
            if (Instance != this)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
