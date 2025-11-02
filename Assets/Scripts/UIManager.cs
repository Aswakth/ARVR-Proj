using UnityEngine;

// Simple UI manager to start/stop routines from UI buttons.
public class UIManager : MonoBehaviour
{
    public ARFitnessManager fitnessManager;

    public void StartFirstRoutine()
    {
        if (fitnessManager != null)
            fitnessManager.StartRoutine(0);
    }

    public void StopAll()
    {
        if (fitnessManager != null)
            StopAllCoroutines();
    }
}
