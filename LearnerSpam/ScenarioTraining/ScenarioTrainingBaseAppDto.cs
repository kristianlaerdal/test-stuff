namespace LearnerSpam.ScenarioTraining;

/// <summary>
///  Common properties for Scenario Training App dtos
/// </summary>
public abstract class ScenarioTrainingBaseAppDto
{
    /// <summary>
    /// Gets or sets the Id
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the created date
    /// </summary>
    public DateTimeOffset Created { get; set; }

    /// <summary>
    /// Gets or sets the updated date
    /// </summary>
    public DateTimeOffset? Updated { get; set; }
}