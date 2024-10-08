using LearnerSpam.Enums.ScenarioTraining;

namespace LearnerSpam.ScenarioTraining;

/// <summary>
/// A logged scenario training session from the Scenario Training App
/// </summary>
public class ScenarioTrainingSessionAppDto : ScenarioTrainingBaseAppDto
{
    /// <summary>
    /// Gets or sets the feature type for the session
    /// </summary>
    public FeatureType FeatureType { get; set; }

    /// <summary>
    /// Gets or sets the scenario id. If null, this is a custom scenario
    /// </summary>
    public Guid? ScenarioId { get; set; }

    /// <summary>
    /// Gets or sets the scenario title
    /// </summary>
    public string ScenarioTitle { get; set; }

    /// <summary>
    /// Gets or sets the logged user activities
    /// </summary>
    public List<ScenarioTrainingSessionUserActivityAppDto> UserActivities { get; set; }

    /// <summary>
    /// Gets or sets the session input scores
    /// </summary>
    public List<ScenarioTrainingInputScoreAppDto> InputScores { get; set; }

    /// <summary>
    /// Gets or sets session observation inputs
    /// </summary>
    public List<ScenarioTrainingInputAppDto> Inputs { get; set; }

    /// <summary>
    /// Gets or sets session facilitators
    /// </summary>
    public List<ScenarioTrainingLearnerAppDto> Facilitators { get; set; }

    /// <summary>
    /// Gets or sets session learners
    /// </summary>
    public List<ScenarioTrainingLearnerAppDto> Learners { get; set; }

    /// <summary>
    /// Gets or sets session learning objectives
    /// </summary>
    public List<ScenarioTrainingSessionLearningObjectiveAppDto> LearningObjectives { get; set; }
}