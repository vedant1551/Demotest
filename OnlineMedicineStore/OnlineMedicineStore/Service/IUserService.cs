﻿namespace OnlineMedicineStore.Service
{
    public interface IUserService
    {
        string GetUserId();
        bool IsAuthenticated();
    }
}