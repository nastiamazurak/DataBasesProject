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
                new District { Id = 925, Name="Гуртожиток ЛНУ",  Address="вул.Басараб 1",    CircuitId = 115 },
                new District { Id = 927, Name="Центр Творчості", Address="вул.Вахнянина 29", CircuitId = 115 },
                new District { Id = 931, Name="Школа №6",        Address="вул.Зелена 22",    CircuitId = 115 },
                new District { Id = 935, Name="Ліцей",           Address="вул.Короленка 1",  CircuitId = 115 },

                new District { Id = 877, Name="Народний Дім",          Address="вул.Білогорща 23",     CircuitId = 116 },
                new District { Id = 878, Name="Школа №65",             Address="вул.Роксоляни 35",     CircuitId = 116 },
                new District { Id = 880, Name="Школа №67",             Address="вул.Сяйво 18",         CircuitId = 116 },
                new District { Id = 883, Name="Коледж Промисловості",  Address="вул.Бортнянського 30", CircuitId = 116 },

                new District { Id = 848, Name="Львівська Політехніка", Address="вул.Карпінського 2",CircuitId = 117 },
                new District { Id = 850, Name="Ліцей №52",             Address="вул.Гоголя 17",     CircuitId = 117 },
                new District { Id = 852, Name="Школа №62",             Address="вул.Театральна 15", CircuitId = 117 },
                new District { Id = 855, Name="Школа №53",             Address="просп.Чорновола 6", CircuitId = 117 },

                new District { Id = 939, Name="Школа №88",         Address="вул.Лисеницька 3",      CircuitId = 118 },
                new District { Id = 943, Name="Школа №63",         Address="вул.Личаківська 171",   CircuitId = 118 },
                new District { Id = 944, Name="Гуртожиток ЛНУ №3", Address="вул.Медової Печери 39", CircuitId = 118 },
                new District { Id = 951, Name="Гуртожиток ЛНУ №8", Address="вул.Пасічна 62",        CircuitId = 118 }
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

            if (context.Circuit.Any())
            {
                return;
            }

            var citizens = new Citizen[]
            {
                new Citizen { Id = 01, FirstName = "Анастасія",  LastName = "Кушнір",         MiddleName = "Андріївна",          BirthDate = new DateTime(2000, 07, 12), Ipn = "123456542" },
                new Citizen { Id = 02, FirstName = "Анастасія",  LastName = "Мазурак",        MiddleName = "Романівна",          BirthDate = new DateTime(2000, 09, 25), Ipn = "122525345" },
                new Citizen { Id = 03, FirstName = "Андрій",     LastName = "Шкробут",        MiddleName = "Валтерович",         BirthDate = new DateTime(2000, 07, 01), Ipn = "132525348" },
                new Citizen { Id = 04, FirstName = "Володимир",  LastName = "Дишкант",        MiddleName = "Зеновійович",        BirthDate = new DateTime(2000, 07, 25), Ipn = "232525346" },
                new Citizen { Id = 05, FirstName = "Михайло",    LastName = "Демчишин",       MiddleName = "Володимирович",      BirthDate = new DateTime(2000, 01, 24), Ipn = "322625349" },
                new Citizen { Id = 06, FirstName = "Василь",     LastName = "Кривоніс",       MiddleName = "Романович",          BirthDate = new DateTime(1966, 10, 25), Ipn = "322525348" },
                new Citizen { Id = 07, FirstName = "Cтепан",     LastName = "Холоднокровний", MiddleName = "Йосифович",          BirthDate = new DateTime(1967, 12, 26), Ipn = "622525646" },
                new Citizen { Id = 08, FirstName = "Іван",       LastName = "Кравченко",      MiddleName = "Остапович",          BirthDate = new DateTime(1977, 06, 20), Ipn = "122524346" },
                new Citizen { Id = 09, FirstName = "Тадей",      LastName = "Розумний",       MiddleName = "Іванович",           BirthDate = new DateTime(1956, 09, 24), Ipn = "522525345" },
                new Citizen { Id = 10, FirstName = "Марко",      LastName = "Сотник",         MiddleName = "Степанович",         BirthDate = new DateTime(1970, 11, 26), Ipn = "722725378" },
                new Citizen { Id = 11, FirstName = "Ярослав",    LastName = "Недолугий",      MiddleName = "Романович",          BirthDate = new DateTime(2000, 02, 19), Ipn = "332523343" },
                new Citizen { Id = 12, FirstName = "Ілля",       LastName = "Малкович",       MiddleName = "Абдулович",          BirthDate = new DateTime(2000, 09, 12), Ipn = "922527346" },
                new Citizen { Id = 13, FirstName = "Олеся",      LastName = "Кушнір",         MiddleName = "Олегівна",           BirthDate = new DateTime(1978, 02, 19), Ipn = "123466543" },
                new Citizen { Id = 14, FirstName = "Олег",       LastName = "Ващишин",        MiddleName = "Тарасович",          BirthDate = new DateTime(1975, 03, 19), Ipn = "523466543" },
                new Citizen { Id = 15, FirstName = "Марія",      LastName = "Чабанна",        MiddleName = "Ярославівна",        BirthDate = new DateTime(1974, 04, 29), Ipn = "723476547" },
                new Citizen { Id = 16, FirstName = "Тетяна",     LastName = "Сліпачук",       MiddleName = "Володимирівна",      BirthDate = new DateTime(1968, 05, 25), Ipn = "623476546" },
                new Citizen { Id = 17, FirstName = "Роман",      LastName = "Куновский",      MiddleName = "Володимирович",      BirthDate = new DateTime(1969, 05, 26), Ipn = "924476646" },
                new Citizen { Id = 18, FirstName = "Марія",      LastName = "Лопушанська",    MiddleName = "Петрівна",           BirthDate = new DateTime(1964, 04, 27), Ipn = "324475646" },
                new Citizen { Id = 19, FirstName = "Юрій",       LastName = "Трухан",         MiddleName = "Степанович",         BirthDate = new DateTime(1950, 05, 27), Ipn = "524475648" },
                new Citizen { Id = 20, FirstName = "Тамара",     LastName = "Дзюмба",         MiddleName = "Петрівна",           BirthDate = new DateTime(1960, 03, 05), Ipn = "724575649" },
                new Citizen { Id = 21, FirstName = "Ярина",      LastName = "Дзюмбочок",      MiddleName = "Євгенівна",          BirthDate = new DateTime(1965, 11, 15), Ipn = "624575639" },
                new Citizen { Id = 22, FirstName = "Віталій",    LastName = "Воробйов",       MiddleName = "Сергійович",         BirthDate = new DateTime(1966, 12, 14), Ipn = "824555635" },
                new Citizen { Id = 23, FirstName = "Олег",       LastName = "Ващишин",        MiddleName = "Тарасович",          BirthDate = new DateTime(1976, 09, 15), Ipn = "834657637" },
                new Citizen { Id = 24, FirstName = "Марія",      LastName = "Горбань",        MiddleName = "Констянтинівна",     BirthDate = new DateTime(1973, 09, 21), Ipn = "322425348" },
                new Citizen { Id = 25, FirstName = "Олександра", LastName = "Присяжник",      MiddleName = "Олегівна",           BirthDate = new DateTime(1979, 10, 01), Ipn = "342525348" },
                new Citizen { Id = 26, FirstName = "Андрій",     LastName = "Присяжник",      MiddleName = "Романович",          BirthDate = new DateTime(1989, 11, 25), Ipn = "322525234" },
                new Citizen { Id = 27, FirstName = "Ігор",       LastName = "Присяжник",      MiddleName = "Романович",          BirthDate = new DateTime(1989, 11, 25), Ipn = "384930272" },
                new Citizen { Id = 28, FirstName = "Тетяна",     LastName = "Присяжник",      MiddleName = "Романівна",          BirthDate = new DateTime(1993, 03, 07), Ipn = "729202736" },
                new Citizen { Id = 29, FirstName = "Василь",     LastName = "Дмитришин",      MiddleName = "Андрійович",         BirthDate = new DateTime(1969, 12, 05), Ipn = "326437963" },
                new Citizen { Id = 30, FirstName = "Іван",       LastName = "Винявський",     MiddleName = "Михайлович",         BirthDate = new DateTime(2000, 02, 12), Ipn = "322455348" },
                new Citizen { Id = 31, FirstName = "Ольга",      LastName = "Кривоніс",       MiddleName = "Михайлівна",         BirthDate = new DateTime(1955, 02, 24), Ipn = "323345466" },
                new Citizen { Id = 32, FirstName = "Вікторія",   LastName = "Чумакевич",      MiddleName = "Вікторівна",         BirthDate = new DateTime(1967, 06, 20), Ipn = "354356774" },
                new Citizen { Id = 33, FirstName = "Володимир",  LastName = "Куриляк",        MiddleName = "Романович",          BirthDate = new DateTime(1998, 06, 06), Ipn = "435463356" },
                new Citizen { Id = 34, FirstName = "Петро",      LastName = "Фурдичко",       MiddleName = "Олегович",           BirthDate = new DateTime(1976, 10, 08), Ipn = "423675657" },
                new Citizen { Id = 35, FirstName = "Василь",     LastName = "Тимчишин",       MiddleName = "Романович",          BirthDate = new DateTime(1964, 08, 10), Ipn = "243454653" },
                new Citizen { Id = 36, FirstName = "Роман",      LastName = "Кривий",         MiddleName = "Романович",          BirthDate = new DateTime(1976, 08, 13), Ipn = "243565363" },
                new Citizen { Id = 37, FirstName = "Настя",      LastName = "Мудра",          MiddleName = "Романівна",          BirthDate = new DateTime(1965, 04, 10), Ipn = "256465374" },
                new Citizen { Id = 38, FirstName = "Наталя",     LastName = "Ліб",            MiddleName = "Марківна",           BirthDate = new DateTime(1993, 07, 07), Ipn = "354546754" },
                new Citizen { Id = 39, FirstName = "Марко",      LastName = "Бучковський",    MiddleName = "Романович",          BirthDate = new DateTime(1977, 08, 19), Ipn = "235465325" },
                new Citizen { Id = 40, FirstName = "Владислав",  LastName = "Панчак",         MiddleName = "Андрійович",         BirthDate = new DateTime(1973, 06, 15), Ipn = "768543674" },
                new Citizen { Id = 41, FirstName = "Ярослав",    LastName = "Бориско",        MiddleName = "Романович",          BirthDate = new DateTime(1951, 01, 10), Ipn = "543465476" },
                new Citizen { Id = 42, FirstName = "Роман ",     LastName = "Царь",           MiddleName = "Романович",          BirthDate = new DateTime(1964, 01, 11), Ipn = "435464355" },
                new Citizen { Id = 46, FirstName = "Максим",     LastName = "Чехович",        MiddleName = "Романович",          BirthDate = new DateTime(1974, 03, 10), Ipn = "453554563" },
                new Citizen { Id = 47, FirstName = "Віталій",    LastName = "Горбачевський",  MiddleName = "Сергійович",         BirthDate = new DateTime(1976, 12, 04), Ipn = "834443535" },
                new Citizen { Id = 48, FirstName = "Марія",      LastName = "Ошийко",         MiddleName = "Сергійович",         BirthDate = new DateTime(1966, 02, 14), Ipn = "234353335" },
                new Citizen { Id = 49, FirstName = "Віталій",    LastName = "Таргаріан",      MiddleName = "Сергійович",         BirthDate = new DateTime(1988, 03, 14), Ipn = "842443532" },

           };


            context.Citizen.AddRange(citizens);


            if (context.Election.Any())
            {
                return;
            }

            var elections = new Election[]
            {
                new Election{Id = 01, Name = "Перші вибори президента України",       Year = 1991, Tour = 1, StartDate = new DateTime(1991, 12, 01), EndDate = new DateTime(1991, 12, 10), HeadOfCvk = 06 },
                new Election{Id = 02, Name = "Вибори президента України -1994",       Year = 1994, Tour = 2, StartDate = new DateTime(1994, 06, 26), EndDate = new DateTime(1994, 07, 10), HeadOfCvk = 09 },
                new Election{Id = 03, Name = "Вибори президента України -1999",       Year = 1999, Tour = 2, StartDate = new DateTime(1999, 10, 31), EndDate = new DateTime(1999, 11, 14), HeadOfCvk = 07 },
                new Election{Id = 04, Name = "Вибори президента України -2004",       Year = 2004, Tour = 2, StartDate = new DateTime(2004, 10, 31), EndDate = new DateTime(2004, 12, 26), HeadOfCvk = 08 },
                new Election{Id = 05, Name = "Вибори президента України -2010",       Year = 2010, Tour = 2, StartDate = new DateTime(2004, 01, 17), EndDate = new DateTime(2004, 02, 07), HeadOfCvk = 14 },
                new Election{Id = 06, Name = "Позачергові вибори президента України", Year = 2014, Tour = 1, StartDate = new DateTime(2014, 05, 25), EndDate = new DateTime(2014, 05, 30), HeadOfCvk = 15 },
                new Election{Id = 07, Name = "Вибори президента України - 2019",      Year = 2019, Tour = 2, StartDate = new DateTime(2019, 03, 30), EndDate = new DateTime(2019, 04, 21), HeadOfCvk = 16 },

             };

            context.Election.AddRange(elections);

            if (context.CircuitHead.Any())
            {
                return;
            }
            var circuit_heads = new CircuitHead[]
            {
                new CircuitHead{Id = 01, ElectionId = 01, CircuitId = 115, CitizenId = 09},
                new CircuitHead{Id = 02, ElectionId = 01, CircuitId = 116, CitizenId = 18},
                new CircuitHead{Id = 03, ElectionId = 01, CircuitId = 117, CitizenId = 19},
                new CircuitHead{Id = 04, ElectionId = 01, CircuitId = 118, CitizenId = 20},

                new CircuitHead{Id = 05, ElectionId = 02, CircuitId = 115, CitizenId = 17},
                new CircuitHead{Id = 06, ElectionId = 02, CircuitId = 116, CitizenId = 18},
                new CircuitHead{Id = 07, ElectionId = 02, CircuitId = 117, CitizenId = 07},
                new CircuitHead{Id = 08, ElectionId = 02, CircuitId = 118, CitizenId = 21},

                new CircuitHead{Id = 09, ElectionId = 03, CircuitId = 115, CitizenId = 18},
                new CircuitHead{Id = 10, ElectionId = 03, CircuitId = 116, CitizenId = 17},
                new CircuitHead{Id = 11, ElectionId = 03, CircuitId = 117, CitizenId = 08},
                new CircuitHead{Id = 12, ElectionId = 03, CircuitId = 118, CitizenId = 22},

                new CircuitHead{Id = 13, ElectionId = 04, CircuitId = 115, CitizenId = 14},
                new CircuitHead{Id = 14, ElectionId = 04, CircuitId = 116, CitizenId = 22},
                new CircuitHead{Id = 15, ElectionId = 04, CircuitId = 117, CitizenId = 19},
                new CircuitHead{Id = 16, ElectionId = 04, CircuitId = 118, CitizenId = 21},

                new CircuitHead{Id = 17, ElectionId = 05, CircuitId = 115, CitizenId = 15},
                new CircuitHead{Id = 18, ElectionId = 05, CircuitId = 116, CitizenId = 20},
                new CircuitHead{Id = 19, ElectionId = 05, CircuitId = 117, CitizenId = 18},
                new CircuitHead{Id = 20, ElectionId = 05, CircuitId = 118, CitizenId = 21},

                new CircuitHead{Id = 21, ElectionId = 06, CircuitId = 115, CitizenId = 20},
                new CircuitHead{Id = 22, ElectionId = 06, CircuitId = 116, CitizenId = 16},
                new CircuitHead{Id = 23, ElectionId = 06, CircuitId = 117, CitizenId = 18},
                new CircuitHead{Id = 24, ElectionId = 06, CircuitId = 118, CitizenId = 23},


                new CircuitHead{Id = 25, ElectionId = 07, CircuitId = 115, CitizenId = 19},
                new CircuitHead{Id = 26, ElectionId = 07, CircuitId = 116, CitizenId = 21},
                new CircuitHead{Id = 27, ElectionId = 07, CircuitId = 117, CitizenId = 06},
                new CircuitHead{Id = 28, ElectionId = 07, CircuitId = 118, CitizenId = 17},

            };

            context.CircuitHead.AddRange(circuit_heads);

            if (context.DistrictHead.Any())
            {
                return;
            }
            var district_heads = new DistrictHead[]
            {
                new DistrictHead{Id = 01, ElectionId = 07, DistrictId = 925,  CitizenId = 39 },
                new DistrictHead{Id = 02, ElectionId = 07, DistrictId = 927,  CitizenId = 24},
                new DistrictHead{Id = 03, ElectionId = 07, DistrictId = 931,  CitizenId = 26 },
                new DistrictHead{Id = 04, ElectionId = 07, DistrictId = 935,  CitizenId = 28 },

                new DistrictHead{Id = 05, ElectionId = 07, DistrictId = 877,  CitizenId = 25 },
                new DistrictHead{Id = 06, ElectionId = 07, DistrictId = 878,  CitizenId = 30 },
                new DistrictHead{Id = 07, ElectionId = 07, DistrictId = 880,  CitizenId = 21 },
                new DistrictHead{Id = 08, ElectionId = 07, DistrictId = 883,  CitizenId = 23 },

                new DistrictHead{Id = 09, ElectionId = 07, DistrictId = 848,  CitizenId = 31},
                new DistrictHead{Id = 10, ElectionId = 07, DistrictId = 850,  CitizenId = 32},
                new DistrictHead{Id = 11, ElectionId = 07, DistrictId = 852,  CitizenId = 32},
                new DistrictHead{Id = 12, ElectionId = 07, DistrictId = 855,  CitizenId = 18},

                new DistrictHead{Id = 13, ElectionId = 07, DistrictId = 939,  CitizenId = 33},
                new DistrictHead{Id = 14, ElectionId = 07, DistrictId = 943,  CitizenId = 34},
                new DistrictHead{Id = 15, ElectionId = 07, DistrictId = 944,  CitizenId = 35},
                new DistrictHead{Id = 16, ElectionId = 07, DistrictId = 951,  CitizenId = 16},



            };

            context.DistrictHead.AddRange(district_heads);

            context.SaveChanges();
        }
    }
}
