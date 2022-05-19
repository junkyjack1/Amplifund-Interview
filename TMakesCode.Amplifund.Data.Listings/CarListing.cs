using System;
using System.Collections.Generic;
using System.Linq;
using TMakesCode.Amplifund.Domain;

namespace TMakesCode.Amplifund.Data.Listings
{
    public static class CarListing
    {
        public static Car Canopysaurus { get; }
        public static Car ChevelleWagon { get; }
        public static Car LightningMcQueen { get; }
        public static Car FxAtmos { get; }

        static CarListing()
        {
            Canopysaurus = new Car
            {
                Id = 1,
                Name = "Canopysaurus",
                Path = "freds-car.jpg"
            };

            ChevelleWagon = new Car
            {
                Id = 2,
                Name = "1973 Chevelle Wagon",
                Path = "marges-car.jpg"
            };

            LightningMcQueen = new Car
            {
                Id = 3,
                Name = "Lightning McQueen",
                Path = "Lightning_McQueen.png"
            };

            FxAtmos = new Car
            {
                Id = 4,
                Name = "FX-Atmos",
                Path = "georges-car.jpg"
            };
        }

        public static IQueryable<Car> Query()
        {
            return new List<Car> { Canopysaurus, ChevelleWagon, LightningMcQueen, FxAtmos }.AsQueryable();
        }
    }
}
