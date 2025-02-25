﻿


using Auth.Core.Interfaces;
using Microsoft.IdentityModel.JsonWebTokens;

namespace Auth.Application.Implementations;



public class BlackListService : IBlackListService
{
    private HashSet<string> blackList = new();
    private ITokenService _tokenService;
    private static CancellationTokenSource _cancellationTokenSource = new();
    

    public BlackListService(ITokenService tokenService)
    {
        StartPeriodicClearing();
        _tokenService = tokenService;
    }

    private async void StartPeriodicClearing()
    {
        while (!_cancellationTokenSource.Token.IsCancellationRequested)
        {
            await Task.Delay(TimeSpan.FromMinutes(10), _cancellationTokenSource.Token); // Delay for 30 minutes
            ClearBlacklist();
        }
    }

    private void ClearBlacklist()
    {
        lock (blackList)
        {
            foreach (var token in blackList)
            {
                var principal = _tokenService.GetPrincipalFromToken(token);
                var expiryDateUnix = long.Parse(principal.Claims.Single(c => c.Type == JwtRegisteredClaimNames.Exp).Value);

                if (DateTime.UtcNow > new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(expiryDateUnix))
                {
                    blackList.Remove(token);
                    Console.WriteLine($"{token} removed");
                }
                Console.WriteLine(token);
            }
        }
    }
    public void AddTokenToBlackList(string token)
    {
        lock (blackList)
        {
            blackList.Add(token);
        }
    }

    public bool IsTokenBlackListed(string token)
    {
        lock (blackList)
        {
            return blackList.Contains(token);
        }
    }
}