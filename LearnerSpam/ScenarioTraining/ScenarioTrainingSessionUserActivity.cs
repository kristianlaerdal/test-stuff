namespace LearnerSpam.ScenarioTraining;

/// <summary>
/// Session user activity tracking
/// </summary>
public class ScenarioTrainingSessionUserActivityAppDto : ScenarioTrainingBaseAppDto
{
    /// <summary>
    /// Gets or sets the app version
    /// </summary>
    public string AppVersion { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the activity happened during session creation
    /// </summary>
    public bool HappenedDuringSessionCreation { get; set; }

    /// <summary>
    /// Gets or sets the start datetime
    /// </summary>
    public DateTimeOffset Start { get; set; }

    /// <summary>
    /// Gets or sets the end datetime
    /// </summary>
    public DateTimeOffset? End { get; set; }

    /// <summary>
    /// Gets or sets Type of action performed by the user
    /// </summary>
    public string Action { get; set; }

    /// <summary>
    /// Gets or sets Id for Scenario training session
    /// </summary>
    public Guid ScenarioTrainingSessionId { get; set; }

    /// <summary>
    /// Gets or sets the device information
    /// </summary>
    public string DeviceInformation { get; set; }
}