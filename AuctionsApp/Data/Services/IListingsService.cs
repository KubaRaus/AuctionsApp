﻿using AuctionsApp.Models;

namespace AuctionsApp.Data.Services
{
    public interface IListingsService
    {
        IQueryable<Listing> GetAll();
        Task Add(Listing listing);
        Task<Listing> GetById(int? id);
        Task SaveChanges();
        Task Delete(int id);
    }
}
