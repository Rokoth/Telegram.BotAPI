// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Payments;

/// <summary>
/// This object contains information about an incoming pre-checkout query.
/// </summary>
public class PreCheckoutQuery
{
    /// <summary>
    /// Unique query identifier
    /// </summary>
    [JsonPropertyName(PropertyNames.Id)]
    public string Id { get; set; } = null!;

    /// <summary>
    /// User who sent the query
    /// </summary>
    [JsonPropertyName(PropertyNames.From)]
    public User From { get; set; } = null!;

    /// <summary>
    /// Three-letter ISO 4217 <a href="https://core.telegram.org/bots/payments#supported-currencies">currency</a> code, or “XTR” for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.Currency)]
    public string Currency { get; set; } = null!;

    /// <summary>
    /// Total price in the <em>smallest units</em> of the currency (integer, <strong>not</strong> float/double). For example, for a price of <em>US$ 1.45</em> pass <em>amount = 145</em>. See the <em>exp</em> parameter in <a href="https://core.telegram.org/bots/payments/currencies.json">currencies.json</a>, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies).
    /// </summary>
    [JsonPropertyName(PropertyNames.TotalAmount)]
    public int TotalAmount { get; set; }

    /// <summary>
    /// Bot-specified invoice payload
    /// </summary>
    [JsonPropertyName(PropertyNames.InvoicePayload)]
    public string InvoicePayload { get; set; } = null!;

    /// <summary>
    /// Optional. Identifier of the shipping option chosen by the user
    /// </summary>
    [JsonPropertyName(PropertyNames.ShippingOptionId)]
    public string? ShippingOptionId { get; set; }

    /// <summary>
    /// Optional. Order information provided by the user
    /// </summary>
    [JsonPropertyName(PropertyNames.OrderInfo)]
    public OrderInfo? OrderInfo { get; set; }
}
