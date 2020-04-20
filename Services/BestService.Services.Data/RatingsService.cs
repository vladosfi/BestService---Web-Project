﻿namespace BestService.Services.Data
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BestService.Data.Common.Repositories;
    using BestService.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class RatingsService : IRatingsService
    {
        private const int DefaultCompanyRating = 1;

        private readonly IRepository<Rate> ratingRepository;

        public RatingsService(IRepository<Rate> ratingRepository)
        {
            this.ratingRepository = ratingRepository;
        }

        public int GetRating(int companyId)
        {
            var allStars = this.ratingRepository.All().Where(p => p.CompanyId == companyId).Select(p => p.Stars).FirstOrDefault();
            return allStars;
        }

        public async Task RateAsync(int companyId, string userId, int stars)
        {
            var rating = this.ratingRepository.All().FirstOrDefault(x => x.CompanyId == companyId && x.UserId == userId);

            if (rating == null)
            {
                rating = CreateRate(companyId, userId, stars);
                await this.ratingRepository.AddAsync(rating);
            }
            else
            {
                rating.Stars = stars;
                this.ratingRepository.Update(rating);
            }

            await this.ratingRepository.SaveChangesAsync();
        }

        public int GetAvgCompanyRate(int companyId)
        {
            var rateSum = this.GetCompanyReview(companyId);
            var userCount = this.ratingRepository.All().Where(x => x.CompanyId == companyId).Count();

            return (int)Math.Round((double)rateSum / userCount);
        }

        public int GetCompanyReview(int companyId)
        {
            var rateSum = this.ratingRepository.All().Where(x => x.CompanyId == companyId).Count();
            return rateSum;
        }

        public async Task<int> GetCountAsync()
        {
            return await this.ratingRepository.AllAsNoTracking().CountAsync();
        }

        private static Rate CreateRate(int companyId, string userId, int stars)
        {
            return new Rate
            {
                CompanyId = companyId,
                UserId = userId,
                Stars = stars,
            };
        }
    }
}
