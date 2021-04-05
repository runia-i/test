using Shop.Date.Models;
using Shop.Date.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Date.interfaces.mocks
{
    public class MockCategory : iCarsCategory
    {
        public IEnumerable<Category> AllCategories {
            get
            {
                return new List<Category>
                {
                    new Category {nameCategory = "Электромобили", desk = "Современный вид транспорта"},
                    new Category {nameCategory = "Классические автомобили", desk = "Машины с двигателем внутреннего сгорания"}
                };
            }
        }
    }
}
