using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.DAL
{
    public static class DbInitializer
    {
        public static void Initialize(MyPortfolioContext context)
        {
            context.Database.EnsureCreated();

            if (context.Portfolios.Any())
            {
                var portfolios = context.Portfolios.ToList();
                var images = new[]
                {
                    "/images/portfolio/portfolio_code_1.png",
                    "/images/portfolio/portfolio_server_2.png",
                    "/images/portfolio/portfolio_mobile_3.png"
                };

                for (int i = 0; i < portfolios.Count; i++)
                {
                    portfolios[i].ImageUrl = images[i % images.Length];
                }

                context.SaveChanges();
            }
        }
    }
}
