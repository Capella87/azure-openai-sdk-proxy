namespace AzureOpenAIProxy.PlaygroundApp.Models;

public class PlaygroundConfig
{
    /// <summary>
    /// Gets or sets API key.
    /// </summary>
    public string? ApiKey { get; set; }

    /// <summary>
    /// Gets or sets the deployment model that user selected.
    /// </summary>
    public string DeploymentModel { get; set; }

    /// <summary>
    /// Gets or sets the system message that user set.
    /// </summary>
    public string? SystemMessage { get; set; }
}