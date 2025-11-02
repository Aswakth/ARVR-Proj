[System.Serializable]
public class ExerciseRoutine
{
    public string name;
    public float duration; // seconds
    public float difficulty; // 1-5

    public ExerciseRoutine(string name, float duration, float difficulty)
    {
        this.name = name;
        this.duration = duration;
        this.difficulty = difficulty;
    }
}
