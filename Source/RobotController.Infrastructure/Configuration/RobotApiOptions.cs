﻿namespace RobotController.Infrastructure.Configuration;

public class RobotApiOptions
{
    public string? BaseUrl { get; set; }

    public string? ApiKey { get; set; }

    public int ConnectionTimeoutInSeconds { get; set; } = 2;
}
