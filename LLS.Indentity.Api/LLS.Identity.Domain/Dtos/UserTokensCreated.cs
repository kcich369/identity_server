﻿namespace LLS.Identity.Domain.Dtos;

public class UserTokensCreated
{
    public string EmailToken { get; set; }
    public string PhoneToken { get; set; }
}