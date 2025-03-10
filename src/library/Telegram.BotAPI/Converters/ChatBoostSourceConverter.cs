﻿// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Text.Json;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Converters;

/// <summary>
///     Converts an <see cref="ChatBoostSource" /> to or from JSON.
/// </summary>
public sealed class ChatBoostSourceConverter : JsonConverter<ChatBoostSource>
{
    /// <summary>
    ///     Reads and converts the JSON to type <see cref="ChatBoostSource" />.
    /// </summary>
    /// <param name="reader">The reader.</param>
    /// <param name="typeToConvert">The type to convert.</param>
    /// <param name="options">An object that specifies serialization options to use.</param>
    /// <returns>The converted value.</returns>
    public override ChatBoostSource? Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        JsonDocument? jsonDoc = JsonSerializer.Deserialize<JsonDocument>(ref reader, options)!;
        bool isValid = jsonDoc.RootElement.TryGetProperty(
            PropertyNames.Source,
            out JsonElement prop
        );
        string? rawText = jsonDoc.RootElement.GetRawText();
        if (isValid)
        {
            if (prop.ValueKind != JsonValueKind.String)
            {
                throw new JsonException(
                    $"Property type of {PropertyNames.Source} must be a String."
                );
            }

            string? source = prop.GetString();
            return source switch
            {
                "gift_code" => JsonSerializer.Deserialize<ChatBoostSourceGiftCode>(
                    rawText,
                    options
                ),
                "giveaway" => JsonSerializer.Deserialize<ChatBoostSourceGiveaway>(
                    rawText,
                    options
                ),
                "premium" => JsonSerializer.Deserialize<ChatBoostSourcePremium>(
                    rawText,
                    options
                ),
                _ => throw new JsonException("Json object is not a valid ChatBoostSource."),
            };
        }

        throw new JsonException($"Missing required property: {PropertyNames.Source}");
    }

    /// <summary>
    ///     Writes a <see cref="ChatBoostSource" /> object as JSON.
    /// </summary>
    /// <param name="writer">The writer to write to.</param>
    /// <param name="value">The value to convert to JSON.</param>
    /// <param name="options">An object that specifies serialization options to use.</param>
    public override void Write(
        Utf8JsonWriter writer,
        ChatBoostSource value,
        JsonSerializerOptions options
    )
    {
        if (value == null)
        {
            throw new ArgumentNullException(nameof(value));
        }

        Type? type = value.GetType();
        JsonSerializer.Serialize(writer, value, type, options);
    }
}
