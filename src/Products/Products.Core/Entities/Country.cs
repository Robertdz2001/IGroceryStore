﻿using IGroceryStore.Products.Core.ValueObjects;

namespace IGroceryStore.Products.Core.Entities;

public class Country
{
    public CountryId Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
}