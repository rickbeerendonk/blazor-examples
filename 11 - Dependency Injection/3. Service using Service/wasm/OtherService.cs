// European Union Public License version 1.2
// Copyright © 2022 Rick Beerendonk

namespace DependencyInjection_ServiceUsingService;

public interface IOther
{
    void Info(string message);
}

public class OtherService : IOther
{
    private ILogger _logger;

    // Inject through constructor (non-Blazor components classes)
    public OtherService(ILogger logger)
    {
        _logger = logger;
    }

    public void Info(string message)
    {
        _logger.Info($"Via Other: {message}");
    }
}
