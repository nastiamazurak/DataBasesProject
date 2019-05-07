using ElectionProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionProject.Data
{
    public class DataInitializer
    {
        public static void Initialize(ElectionContext context)
        {
            context.Database.EnsureCreated();

            if (context.Circuit.Any())
            {
                return;
            }

            var circuits = new Circuit[]
            {
                new Circuit { Id = 115, Name = "Львівський Округ №115", Center = "м.Львів, Сихівський р-н", Address = "просп.Червоної Калини 66" },
                new Circuit { Id = 116, Name = "Львівський Округ №116", Center = "м.Львів, Залізничний р-н", Address = "вул.Виговського 34" },
                new Circuit { Id = 117, Name = "Львівський Округ №117", Center = "м.Львів, Франківський р-н", Address = "вул.Чупринки 85" },
                new Circuit { Id = 118, Name = "Львівський Округ №118", Center = "м.Львів, Личаківський р-н", Address = "вул.Вахнянина 29" },
                //new Circuit { Number = 119, Name = "Львівський Округ №119", Center = "м.Броди", Address = "пл.Ринок 1" },
                //new Circuit { Number = 120, Name = "Львівський Округ №120", Center = "м.Городок", Address = "вул.майдан Гайдамаків 5" },
                //new Circuit { Number = 121, Name = "Львівський Округ №121", Center = "м.Дрогобич", Address = "вул.Січня 37" },
                //new Circuit { Number = 122, Name = "Львівський Округ №122", Center = "м.Яворів", Address = "вул.Франка 8" },
                //new Circuit { Number = 123, Name = "Львівський Округ №123", Center = "м.Перемишляни", Address = "вул.Привокзальна 3" },
                //new Circuit { Number = 124, Name = "Львівський Округ №124", Center = "м.Сокаль", Address = "вул.Шептицького 26" },
            };
            context.Circuit.AddRange(circuits);


            if (context.District.Any())
            {
                return;
            }

            var districts = new District[]
            {
                new District { Id = 925, Name="Гуртожиток ЛНУ", Address="вул.Басараб 1", CircuitId = 115 },
                new District { Id = 927, Name="Центр Творчості", Address="вул.Вахнянина 29", CircuitId = 115 },
                new District { Id = 931, Name="Школа №6", Address="вул.Зелена 22", CircuitId = 115 },
                new District { Id = 935, Name="Ліцей", Address="вул.Короленка 1", CircuitId = 115 },

                new District { Id = 877, Name="Народний Дім", Address="вул.Білогорща 23", CircuitId = 116 },
                new District { Id = 878, Name="Школа №65", Address="вул.Роксоляни 35", CircuitId = 116 },
                new District { Id = 880, Name="Школа №67", Address="вул.Сяйво 18", CircuitId = 116 },
                new District { Id = 883, Name="Коледж Промисловості", Address="вул.Бортнянського 30", CircuitId = 116 },

                new District { Id = 848, Name="Львівська Політехніка", Address="вул.Карпінського 2", CircuitId = 117 },
                new District { Id = 850, Name="Ліцей №52", Address="вул.Гоголя 17", CircuitId = 117 },
                new District { Id = 852, Name="Школа №62", Address="вул.Театральна 15", CircuitId = 117 },
                new District { Id = 855, Name="Школа №53", Address="просп.Чорновола 6", CircuitId = 117 },

                new District { Id = 939, Name="Школа №88", Address="вул.Лисеницька 3", CircuitId = 118 },
                new District { Id = 943, Name="Школа №63", Address="вул.Личаківська 171", CircuitId = 118 },
                new District { Id = 944, Name="Гуртожиток ЛНУ №3", Address="вул.Медової Печери 39", CircuitId = 118 },
                new District { Id = 951, Name="Гуртожиток ЛНУ №8", Address="вул.Пасічна 62", CircuitId = 118 }
            };
            context.District.AddRange(districts);

            //if (context.Citizen.Any())
            //{
            //    return;
            //}

            //var citizens = new Citizen[]
            //{
            //    new Citizen {  }
            //}

            context.SaveChanges();
        }
    }
}
