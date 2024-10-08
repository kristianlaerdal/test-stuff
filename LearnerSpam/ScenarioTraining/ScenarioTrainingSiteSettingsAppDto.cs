using LearnerSpam.Enums.ScenarioTraining;

namespace LearnerSpam.ScenarioTraining;

/// <summary>
/// Scenario Training Site settings dto
/// </summary>
public class ScenarioTrainingSiteSettingsAppDto : ScenarioTrainingBaseAppDto
{
    /// <summary>
    /// Gets or sets the feature type used by the site
    /// </summary>
    public FeatureType FeatureType { get; set; }

    /// <summary>
    /// Gets or sets Id for Site
    /// </summary>
    public int SiteId { get; set; }

    /// <summary>
    /// Gets or sets Name for Site
    /// </summary>
    public string SiteName { get; set; }
}