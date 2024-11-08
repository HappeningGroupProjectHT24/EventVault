﻿using EventVault.Models.ViewModels;

namespace EventVault.Services.IServices
{
    public interface ITicketMasterServices
    {
        Task<List<EventViewModel>> GetEventsInCityAsync(string city);
    }
}