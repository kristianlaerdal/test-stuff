using LearnerSpam.Enums.ScenarioTraining;

namespace LearnerSpam.ScenarioTraining;

/// <summary>
/// An observation input from a logged Scenario Training Session
/// </summary>
public class ScenarioTrainingInputAppDto : ScenarioTrainingBaseAppDto
{
    /// <summary>
    /// Gets or sets the observation order
    /// </summary>
    public int Order { get; set; }

    /// <summary>
    /// Gets or sets the observation text
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// Gets or sets the type of observation
    /// </summary>
    public ScenarioTrainingSessionInputType InputType { get; set; }

    /// <summary>
    /// Gets or sets the Training Session Id
    /// </summary>
    public Guid ScenarioTrainingSessionId { get; set; }
}