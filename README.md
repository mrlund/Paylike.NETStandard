# Paylike.NETStandard

NETStandard 2.0 client for the Paylike API

This plugin is *not* developed or maintained by Paylike but kindly made
available by the community.

Released under the MIT license: https://opensource.org/licenses/MIT

**PaylikeClient**
```c#
var client = new PaylikeClient(HttpClient httpClient, string privateKey = null, ILogger<PaylikeClient> logger = null)
```

Methods:
* void SetPrivateKeyForRequests(string privateKey)

Examples:
```c#
var transaction = await client.Transactions.Get("transaction-id"); 
```
```c#
var transaction = await client.Cards.Save("transaction-id","merchant-id"); 
```


# Available services

**Transactions**

Methods:
* Task<PaylikeApiResponse<Transaction>> Get(string transactionId)
* Task<PaylikeApiResponse<Transaction>> Create(string merchantId, string cardId, string descriptor, string currency, int amountAsMinor)
* Task<PaylikeApiResponse<Transaction>> Create(string merchantId, string cardId, string descriptor, string currency, decimal amountAsMajor)
* Task<PaylikeApiResponse<Transaction>> Capture(string transactionId, int amount, string currency, string descriptor)
* Task<PaylikeApiResponse<Transaction>> Capture(string transactionId, decimal amount, string currency, string descriptor)
* Task<PaylikeApiResponse<List<Transaction>>> GetRecent(string merchantId, int limit)
* Task<PaylikeApiResponse<Transaction>> Refund(string transactionId, string descriptor, int amountAsMinor)
* Task<PaylikeApiResponse<Transaction>> Refund(string transactionId, string descriptor, string currency, decimal amountAsMajor)

**Payouts**

Methods:
* Task<PaylikeApiResponse<Payout>> Get(string merchantId, string payoutId)
* Task<PaylikeApiResponse<Payout>> Create(string merchantId, decimal amount, string currencyId, string descriptor, string bic, string iban)

**Transfers**

* Task<PaylikeApiResponse<Transfer>> Get(string transferId)
* Task<PaylikeApiResponse<Transfer>> Create(string merchantId, decimal amount, string currencyId, string token)
* Task<PaylikeApiResponse<Transfer>> Approve(string transferId)

**Cards**

* Task<PaylikeApiResponse<Card>> Get(string cardId)
* Task<PaylikeApiResponse<Card>> Save(string transactionId, string merchantId)
