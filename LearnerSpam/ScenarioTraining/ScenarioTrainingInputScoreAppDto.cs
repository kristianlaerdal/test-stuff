using LearnerSpam.Enums.ScenarioTraining;

namespace LearnerSpam.ScenarioTraining;

/// <summary>
/// An observation input from a logged Scenario Training Session
/// </summary>
public class ScenarioTrainingInputScoreAppDto : ScenarioTrainingBaseAppDto
{
    /// <summary>
    /// Gets or sets the type of observation
    /// </summary>
    public ScenarioTrainingSessionInputType InputType { get; set; }

    /// <summary>
    /// Gets or sets the score value
    /// </summary>
    public int Score { get; set; }

    /// <summary>
    /// Gets or sets the Training Session Id
    /// </summary>
    public Guid ScenarioTrainingSessionId { get; set; }
}