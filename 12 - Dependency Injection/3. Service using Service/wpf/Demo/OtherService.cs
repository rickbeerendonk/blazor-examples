// European Union Public License version 1.2
// Copyright © 2022 Rick Beerendonk

namespace Demo;

public interface IOther
{
    void Info(string message);
}

public class OtherService : IOther
{
    private ILogger logger;

    // Inject through constructor (non-Blazor components classes)
    public OtherService(ILogger logger)
    {
        this.logger = logger;
    }

    public void Info(string message)
    {
        logger.Info($"VIA OTHER: {message}");
    }
}
