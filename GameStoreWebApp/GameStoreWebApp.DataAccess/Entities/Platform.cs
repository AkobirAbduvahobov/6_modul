﻿namespace GameStoreWebApp.DataAccess.Entities;

public class Platform
{
    public Guid Id { get; set; }
    public string Type { get; set; }

    public ICollection<GamePlatform> GamePlatforms { get; set; }
}
