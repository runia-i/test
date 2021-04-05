using Shop.Date.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Date.interfaces.mocks
{
    public class MockCars : iAllCars
    {
        private readonly iCarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars 
        {
            get
            {
                return new List<Car>
                {
                    new Car {
                        name = "Tesla Model S",
                        shortDesk="Быстрый автомобиль",
                        longDesk="Красивый, быстрый и очень тихий автомобиль компании Tesla",
                        img="/img/tesla.jpg",
                        price=45000,
                        isFavourite=true,
                        available=true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                       name = "Ford Fiesta",
                       shortDesk = "Тихий и спокойный",
                       longDesk = "Удобный автомобиль для городской жизни",
                       img ="/img/fiesta.jpg",
                       price = 11000,
                       isFavourite = false,
                       available = true,
                       Category = _categoryCars.AllCategories.Last()

                    },
                    new Car
                    {
                        name = "BMW M3",
                        shortDesk = "Дерзкий и стильный",
                        longDesk = "Брутальный автомобиль для ярких эмоций",
                        img = "/img/m3.jpg",
                        price = 47000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Mercedes C class",
                        shortDesk = "Уютный и большой",
                        longDesk = "Практичный автомобиль на каждый день",
                        img = "/img/mersedes.jpg",
                        price = 30000,
                        isFavourite =true,
                        available = false,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Nissan Leafe",
                        shortDesk = "Бесшумный и экономичный",
                        longDesk = "Для ценящих тишину и спокойствие",
                        img ="/img/nissan.jpg",
                        price = 15000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()

                    }
                };
            }
        
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
