namespace LearnerSpam.ScenarioTraining;

/// <summary>
/// A dto for neonatalie learners in the Scenario Training App
/// </summary>
public class ScenarioTrainingLearnerAppDto : ScenarioTrainingBaseAppDto
{
    /// <summary>
    /// Gets or sets the learner name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the neonatalie learner Id
    /// </summary>
    public Guid LearnerId { get; set; }
}