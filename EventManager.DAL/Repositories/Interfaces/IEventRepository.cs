﻿using EventManager.DAL.Entities;
using EventManager.Shared.RequestFeatures;

namespace EventManager.DAL.Repositories.Interfaces
{
    public interface IEventRepository : IBaseRepository<Event>
    {
        Task<Event> GetByIdAsync(int eventId, bool trackChanges);
        Task<Event> GetByUserIdAndEventIdAsync(int userId, int eventId, bool trackChanges);
        Task<IEnumerable<Event>> GetAllByUserIdAsync(int userId, PagingParameters pagingParameters, bool trackChanges);
        Task<IEnumerable<Event>> GetAllAsync(PagingParameters pagingParameters, bool trackChanges);
    }
}