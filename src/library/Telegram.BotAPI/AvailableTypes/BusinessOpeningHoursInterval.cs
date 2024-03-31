// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// No description available
/// </summary>
public class BusinessOpeningHoursInterval
{
    /// <summary>
    /// The minute's sequence number in a week, starting on Monday, marking the start of the time interval during which the business is open; 0 - 7 <em> 24 </em> 60
    /// </summary>
    [JsonPropertyName(PropertyNames.OpeningMinute)]
    public int OpeningMinute { get; set; }

    /// <summary>
    /// The minute's sequence number in a week, starting on Monday, marking the end of the time interval during which the business is open; 0 - 8 <em> 24 </em> 60
    /// </summary>
    [JsonPropertyName(PropertyNames.ClosingMinute)]
    public int ClosingMinute { get; set; }
}
