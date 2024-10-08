namespace LearnerSpam.ScenarioTraining;

/// <summary>
/// Scenario learning objective used in the Scenario Training App
/// </summary>
public class ScenarioTrainingSessionLearningObjectiveAppDto : ScenarioTrainingBaseAppDto
{
    /// <summary>
    /// Gets or sets the ScenarioTrainingSession Id
    /// </summary>
    public Guid ScenarioTrainingSessionId { get; set; }

    /// <summary>
    /// Gets or sets the learning objective title
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Gets or sets Order of the Learning objective in the session (descending)
    /// </summary>
    public int Order { get; set; }

    /// <summary>
    /// Gets or sets the learning objective id
    /// </summary>
    public Guid? LearningObjectiveId { get; set; }
}