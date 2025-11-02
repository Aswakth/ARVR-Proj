using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Manages exercise routines and progression. This is a high-level manager with stubs
// for pose estimation and adaptive difficulty. Implement AR Foundation tracking and
// ML pose-estimation integration in later steps.
public class ARFitnessManager : MonoBehaviour
{
    public List<ExerciseRoutine> routines = new List<ExerciseRoutine>();
    public int currentRoutineIndex = 0;

    void Start()
    {
        // create a sample micro-routine
        routines.Add(new ExerciseRoutine("Jumping Jacks", 30, 1));
        routines.Add(new ExerciseRoutine("Squats", 30, 1));
    }

    public void StartRoutine(int index)
    {
        if (index < 0 || index >= routines.Count) return;
        currentRoutineIndex = index;
        StartCoroutine(RunRoutine(routines[index]));
    }

    IEnumerator RunRoutine(ExerciseRoutine routine)
    {
        float timer = routine.duration;
        while (timer > 0)
        {
            // TODO: integrate live pose scoring and adaptive difficulty
            yield return null;
            timer -= Time.deltaTime;
        }
        OnRoutineComplete(routine);
    }

    void OnRoutineComplete(ExerciseRoutine routine)
    {
        Debug.Log($"Completed: {routine.name}");
        // adapt difficulty stub: increase difficulty slightly
        routine.difficulty = Mathf.Min(routine.difficulty + 0.1f, 5f);
    }
}
