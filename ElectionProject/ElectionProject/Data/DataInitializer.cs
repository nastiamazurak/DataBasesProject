
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

            if (!context.Circuit.Any())
            {
                context.Circuit.AddRange(
                    new Circuit { Id = 115, Name = "Львівський Округ №115", Center = "м.Львів, Сихівський р-н", Address = "просп.Червоної Калини 66" },
                    new Circuit { Id = 116, Name = "Львівський Округ №116", Center = "м.Львів, Залізничний р-н", Address = "вул.Виговського 34" },
                    new Circuit { Id = 117, Name = "Львівський Округ №117", Center = "м.Львів, Франківський р-н", Address = "вул.Чупринки 85" },
                    new Circuit { Id = 118, Name = "Львівський Округ №118", Center = "м.Львів, Личаківський р-н", Address = "вул.Вахнянина 29" }
                //new Circuit { Number = 119, Name = "Львівський Округ №119", Center = "м.Броди", Address = "пл.Ринок 1" },
                //new Circuit { Number = 120, Name = "Львівський Округ №120", Center = "м.Городок", Address = "вул.майдан Гайдамаків 5" },
                //new Circuit { Number = 121, Name = "Львівський Округ №121", Center = "м.Дрогобич", Address = "вул.Січня 37" },
                //new Circuit { Number = 122, Name = "Львівський Округ №122", Center = "м.Яворів", Address = "вул.Франка 8" },
                //new Circuit { Number = 123, Name = "Львівський Округ №123", Center = "м.Перемишляни", Address = "вул.Привокзальна 3" },
                //new Circuit { Number = 124, Name = "Львівський Округ №124", Center = "м.Сокаль", Address = "вул.Шептицького 26" },
                );
                context.SaveChanges();
            }


            if (!context.District.Any())
            {
                context.District.AddRange(
                    new District { Id = 925, Name = "Гуртожиток ЛНУ", Address = "вул.Басараб 1", CircuitId = 115 },
                    new District { Id = 927, Name = "Центр Творчості", Address = "вул.Вахнянина 29", CircuitId = 115 },
                    new District { Id = 931, Name = "Школа №6", Address = "вул.Зелена 22", CircuitId = 115 },
                    new District { Id = 935, Name = "Ліцей", Address = "вул.Короленка 1", CircuitId = 115 },

                    new District { Id = 877, Name = "Народний Дім", Address = "вул.Білогорща 23", CircuitId = 116 },
                    new District { Id = 878, Name = "Школа №65", Address = "вул.Роксоляни 35", CircuitId = 116 },
                    new District { Id = 880, Name = "Школа №67", Address = "вул.Сяйво 18", CircuitId = 116 },
                    new District { Id = 883, Name = "Коледж Промисловості", Address = "вул.Бортнянського 30", CircuitId = 116 },

                    new District { Id = 848, Name = "Львівська Політехніка", Address = "вул.Карпінського 2", CircuitId = 117 },
                    new District { Id = 850, Name = "Ліцей №52", Address = "вул.Гоголя 17", CircuitId = 117 },
                    new District { Id = 852, Name = "Школа №62", Address = "вул.Театральна 15", CircuitId = 117 },
                    new District { Id = 855, Name = "Школа №53", Address = "просп.Чорновола 6", CircuitId = 117 },

                    new District { Id = 939, Name = "Школа №88", Address = "вул.Лисеницька 3", CircuitId = 118 },
                    new District { Id = 943, Name = "Школа №63", Address = "вул.Личаківська 171", CircuitId = 118 },
                    new District { Id = 944, Name = "Гуртожиток ЛНУ №3", Address = "вул.Медової Печери 39", CircuitId = 118 },
                    new District { Id = 951, Name = "Гуртожиток ЛНУ №8", Address = "вул.Пасічна 62", CircuitId = 118 }
                );
                context.SaveChanges();

            }

            if (!context.Citizen.Any())
            {
                context.Citizen.AddRange(
                    new Citizen { Id = 1, FirstName = "Анастасія", LastName = "Кушнір", MiddleName = "Андріївна", BirthDate = new DateTime(2000, 7, 12), Ipn = "123456542", DistrictId = 925},
                    new Citizen { Id = 2, FirstName = "Анастасія", LastName = "Мазурак", MiddleName = "Романівна", BirthDate = new DateTime(2000, 9, 25), Ipn = "122525345", DistrictId =927},
                    new Citizen { Id = 3, FirstName = "Андрій", LastName = "Шкробут", MiddleName = "Валтерович", BirthDate = new DateTime(2000, 7, 1), Ipn = "132525348", DistrictId =927},
                    new Citizen { Id = 4, FirstName = "Володимир", LastName = "Дишкант", MiddleName = "Зеновійович", BirthDate = new DateTime(2000, 7, 25), Ipn = "232525346", DistrictId =927},
                    new Citizen { Id = 5, FirstName = "Михайло", LastName = "Демчишин", MiddleName = "Володимирович", BirthDate = new DateTime(2000, 1, 24), Ipn = "322625349", DistrictId =931},
                    new Citizen { Id = 6, FirstName = "Василь", LastName = "Кривоніс", MiddleName = "Романович", BirthDate = new DateTime(1966, 10, 25), Ipn = "322525348", DistrictId =931},
                    new Citizen { Id = 7, FirstName = "Cтепан", LastName = "Холоднокровний", MiddleName = "Йосифович", BirthDate = new DateTime(1967, 12, 26), Ipn = "622525646", DistrictId = 931},
                    new Citizen { Id = 8, FirstName = "Іван", LastName = "Кравченко", MiddleName = "Остапович", BirthDate = new DateTime(1977, 6, 20), Ipn = "122524346", DistrictId =935},
                    new Citizen { Id = 9, FirstName = "Тадей", LastName = "Розумний", MiddleName = "Іванович", BirthDate = new DateTime(1956, 9, 24), Ipn = "522525345", DistrictId =935},
                    new Citizen { Id = 10, FirstName = "Марко", LastName = "Сотник", MiddleName = "Степанович", BirthDate = new DateTime(1970, 11, 26), Ipn = "722725378", DistrictId = 935 },
                    new Citizen { Id = 11, FirstName = "Ярослав", LastName = "Недолугий", MiddleName = "Романович", BirthDate = new DateTime(2000, 2, 19), Ipn = "332523343", DistrictId =877},
                    new Citizen { Id = 12, FirstName = "Ілля", LastName = "Малкович", MiddleName = "Абдулович", BirthDate = new DateTime(2000, 9, 12), Ipn = "922527346", DistrictId = 877},
                    new Citizen { Id = 13, FirstName = "Олеся", LastName = "Кушнір", MiddleName = "Олегівна", BirthDate = new DateTime(1978, 2, 19), Ipn = "123466543", DistrictId = 877},
                    new Citizen { Id = 14, FirstName = "Олег", LastName = "Ващишин", MiddleName = "Тарасович", BirthDate = new DateTime(1975, 3, 19), Ipn = "523466543", DistrictId =878},
                    new Citizen { Id = 15, FirstName = "Марія", LastName = "Чабанна", MiddleName = "Ярославівна", BirthDate = new DateTime(1974, 4, 29), Ipn = "723476547", DistrictId = 878},
                    new Citizen { Id = 16, FirstName = "Тетяна", LastName = "Сліпачук", MiddleName = "Володимирівна", BirthDate = new DateTime(1968, 5, 25), Ipn = "623476546", DistrictId = 878},
                    new Citizen { Id = 17, FirstName = "Роман", LastName = "Куновский", MiddleName = "Володимирович", BirthDate = new DateTime(1969, 5, 26), Ipn = "924476646", DistrictId = 880},
                    new Citizen { Id = 18, FirstName = "Марія", LastName = "Лопушанська", MiddleName = "Петрівна", BirthDate = new DateTime(1964, 4, 27), Ipn = "324475646", DistrictId = 880 },
                    new Citizen { Id = 19, FirstName = "Юрій", LastName = "Трухан", MiddleName = "Степанович", BirthDate = new DateTime(1950, 5, 27), Ipn = "524475648", DistrictId = 880},
                    new Citizen { Id = 20, FirstName = "Тамара", LastName = "Дзюмба", MiddleName = "Петрівна", BirthDate = new DateTime(1960, 3, 5), Ipn = "724575649", DistrictId = 883 },
                    new Citizen { Id = 21, FirstName = "Ярина", LastName = "Дзюмбочок", MiddleName = "Євгенівна", BirthDate = new DateTime(1965, 11, 15), Ipn = "624575639", DistrictId = 883},
                    new Citizen { Id = 22, FirstName = "Віталій", LastName = "Воробйов", MiddleName = "Сергійович", BirthDate = new DateTime(1966, 12, 14), Ipn = "824555635", DistrictId = 883},
                    new Citizen { Id = 23, FirstName = "Олег", LastName = "Ващишин", MiddleName = "Тарасович", BirthDate = new DateTime(1976, 9, 15), Ipn = "834657637", DistrictId = 848 },
                    new Citizen { Id = 24, FirstName = "Марія", LastName = "Горбань", MiddleName = "Констянтинівна", BirthDate = new DateTime(1973, 9, 21), Ipn = "322425348", DistrictId =848 },
                    new Citizen { Id = 25, FirstName = "Олександра", LastName = "Присяжник", MiddleName = "Олегівна", BirthDate = new DateTime(1979, 10, 1), Ipn = "342525348", DistrictId = 848 },
                    new Citizen { Id = 26, FirstName = "Андрій", LastName = "Присяжник", MiddleName = "Романович", BirthDate = new DateTime(1989, 11, 25), Ipn = "322525234", DistrictId = 850 },
                    new Citizen { Id = 27, FirstName = "Ігор", LastName = "Присяжник", MiddleName = "Романович", BirthDate = new DateTime(1989, 11, 25), Ipn = "384930272", DistrictId = 850 },
                    new Citizen { Id = 28, FirstName = "Тетяна", LastName = "Присяжник", MiddleName = "Романівна", BirthDate = new DateTime(1993, 3, 7), Ipn = "729202736", DistrictId = 850 },
                    new Citizen { Id = 29, FirstName = "Василь", LastName = "Дмитришин", MiddleName = "Андрійович", BirthDate = new DateTime(1969, 12, 5), Ipn = "326437963", DistrictId = 852 },
                    new Citizen { Id = 30, FirstName = "Іван", LastName = "Винявський", MiddleName = "Михайлович", BirthDate = new DateTime(2000, 2, 12), Ipn = "322455348", DistrictId = 852 },
                    new Citizen { Id = 31, FirstName = "Ольга", LastName = "Кривоніс", MiddleName = "Михайлівна", BirthDate = new DateTime(1955, 2, 24), Ipn = "323345466", DistrictId = 852 },
                    new Citizen { Id = 32, FirstName = "Вікторія", LastName = "Чумакевич", MiddleName = "Вікторівна", BirthDate = new DateTime(1967, 6, 20), Ipn = "354356774", DistrictId = 855 },
                    new Citizen { Id = 33, FirstName = "Володимир", LastName = "Куриляк", MiddleName = "Романович", BirthDate = new DateTime(1998, 6, 6), Ipn = "435463356", DistrictId = 855 },
                    new Citizen { Id = 34, FirstName = "Петро", LastName = "Фурдичко", MiddleName = "Олегович", BirthDate = new DateTime(1976, 10, 8), Ipn = "423675657", DistrictId = 939 },
                    new Citizen { Id = 35, FirstName = "Василь", LastName = "Тимчишин", MiddleName = "Романович", BirthDate = new DateTime(1964, 8, 10), Ipn = "243454653", DistrictId = 951},
                    new Citizen { Id = 36, FirstName = "Роман", LastName = "Кривий", MiddleName = "Романович", BirthDate = new DateTime(1976, 8, 13), Ipn = "243565363", DistrictId = 939 },
                    new Citizen { Id = 37, FirstName = "Настя", LastName = "Мудра", MiddleName = "Романівна", BirthDate = new DateTime(1965, 4, 10), Ipn = "256465374", DistrictId = 943 },
                    new Citizen { Id = 38, FirstName = "Наталя", LastName = "Ліб", MiddleName = "Марківна", BirthDate = new DateTime(1993, 7, 7), Ipn = "354546754", DistrictId = 943 },
                    new Citizen { Id = 39, FirstName = "Марко", LastName = "Бучковський", MiddleName = "Романович", BirthDate = new DateTime(1977, 8, 19), Ipn = "235465325", DistrictId = 944 },
                    new Citizen { Id = 40, FirstName = "Владислав", LastName = "Панчак", MiddleName = "Андрійович", BirthDate = new DateTime(1973, 6, 15), Ipn = "768543674", DistrictId = 944 },
                    new Citizen { Id = 41, FirstName = "Ярослав", LastName = "Бориско", MiddleName = "Романович", BirthDate = new DateTime(1951, 1, 10), Ipn = "543465476", DistrictId = 951 },
                    new Citizen { Id = 42, FirstName = "Роман ", LastName = "Царь", MiddleName = "Романович", BirthDate = new DateTime(1964, 1, 11), Ipn = "435464355", DistrictId = 951 },
                    new Citizen { Id = 43, FirstName = "Петро ", LastName = "Порошенко", MiddleName = "Олексійович", BirthDate = new DateTime(1965, 09, 26), Ipn = "235474357", DistrictId =925 },
                    new Citizen { Id = 44, FirstName = "Володимир ", LastName = "Зеленський", MiddleName = "Олександрович", BirthDate = new DateTime(1978, 01, 25), Ipn = "535575355", DistrictId = 927 }
                );
                context.SaveChanges();
            }

            if (!context.Election.Any())
            {
                context.Election.AddRange(
                    new Election { Id = 1, Name = "Вибори президента", Year = 1991, Tour = 1, StartDate = new DateTime(1991, 12, 1), EndDate = new DateTime(1991, 12, 10), HeadOfCvk = 6 },
                    new Election { Id = 2, Name = "Вибори президента", Year = 1995, Tour = 2, StartDate = new DateTime(1994, 6, 26), EndDate = new DateTime(1994, 7, 10), HeadOfCvk = 9 },
                    new Election { Id = 3, Name = "Вибори президента", Year = 1999, Tour = 2, StartDate = new DateTime(1999, 10, 31), EndDate = new DateTime(1999, 11, 14), HeadOfCvk = 7 },
                    new Election { Id = 4, Name = "Вибори президента", Year = 2004, Tour = 2, StartDate = new DateTime(2004, 10, 31), EndDate = new DateTime(2004, 12, 26), HeadOfCvk = 8 },
                    new Election { Id = 5, Name = "Вибори президента", Year = 2009, Tour = 2, StartDate = new DateTime(2004, 1, 17), EndDate = new DateTime(2004, 2, 7), HeadOfCvk = 14 },
                    new Election { Id = 6, Name = "Позачергові вибори",Year = 2014, Tour = 1, StartDate = new DateTime(2014, 5, 25), EndDate = new DateTime(2014, 5, 30), HeadOfCvk = 15 },
                    new Election { Id = 7, Name = "Вибори президента", Year = 2019, Tour = 2, StartDate = new DateTime(2019, 3, 30), EndDate = new DateTime(2019, 4, 21), HeadOfCvk = 16 }
                );
                context.SaveChanges();
            }





            if (!context.CircuitHead.Any())
            {
                context.CircuitHead.AddRange(
                    new CircuitHead { Id = 1, ElectionId = 1, CircuitId = 115, CitizenId = 9 },
                    new CircuitHead { Id = 2, ElectionId = 1, CircuitId = 116, CitizenId = 18 },
                    new CircuitHead { Id = 3, ElectionId = 1, CircuitId = 117, CitizenId = 19 },
                    new CircuitHead { Id = 4, ElectionId = 1, CircuitId = 118, CitizenId = 20 },

                    new CircuitHead { Id = 5, ElectionId = 2, CircuitId = 115, CitizenId = 17 },
                    new CircuitHead { Id = 6, ElectionId = 2, CircuitId = 116, CitizenId = 18 },
                    new CircuitHead { Id = 7, ElectionId = 2, CircuitId = 117, CitizenId = 7 },
                    new CircuitHead { Id = 8, ElectionId = 2, CircuitId = 118, CitizenId = 21 },

                    new CircuitHead { Id = 9, ElectionId = 3, CircuitId = 115, CitizenId = 18 },
                    new CircuitHead { Id = 10, ElectionId = 3, CircuitId = 116, CitizenId = 17 },
                    new CircuitHead { Id = 11, ElectionId = 3, CircuitId = 117, CitizenId = 8 },
                    new CircuitHead { Id = 12, ElectionId = 3, CircuitId = 118, CitizenId = 22 },

                    new CircuitHead { Id = 13, ElectionId = 4, CircuitId = 115, CitizenId = 14 },
                    new CircuitHead { Id = 14, ElectionId = 4, CircuitId = 116, CitizenId = 22 },
                    new CircuitHead { Id = 15, ElectionId = 4, CircuitId = 117, CitizenId = 19 },
                    new CircuitHead { Id = 16, ElectionId = 4, CircuitId = 118, CitizenId = 21 },

                    new CircuitHead { Id = 17, ElectionId = 5, CircuitId = 115, CitizenId = 15 },
                    new CircuitHead { Id = 18, ElectionId = 5, CircuitId = 116, CitizenId = 20 },
                    new CircuitHead { Id = 19, ElectionId = 5, CircuitId = 117, CitizenId = 18 },
                    new CircuitHead { Id = 20, ElectionId = 5, CircuitId = 118, CitizenId = 21 },

                    new CircuitHead { Id = 21, ElectionId = 6, CircuitId = 115, CitizenId = 20 },
                    new CircuitHead { Id = 22, ElectionId = 6, CircuitId = 116, CitizenId = 16 },
                    new CircuitHead { Id = 23, ElectionId = 6, CircuitId = 117, CitizenId = 18 },
                    new CircuitHead { Id = 24, ElectionId = 6, CircuitId = 118, CitizenId = 23 },


                    new CircuitHead { Id = 25, ElectionId = 7, CircuitId = 115, CitizenId = 19 },
                    new CircuitHead { Id = 26, ElectionId = 7, CircuitId = 116, CitizenId = 21 },
                    new CircuitHead { Id = 27, ElectionId = 7, CircuitId = 117, CitizenId = 6 },
                    new CircuitHead { Id = 28, ElectionId = 7, CircuitId = 118, CitizenId = 17 }
                );
                context.SaveChanges();
            }




            if (!context.DistrictHead.Any())
            {
                context.DistrictHead.AddRange(
                    new DistrictHead { Id = 1, ElectionId = 7, DistrictId = 925, CitizenId = 39 },
                    new DistrictHead { Id = 2, ElectionId = 7, DistrictId = 927, CitizenId = 24 },
                    new DistrictHead { Id = 3, ElectionId = 7, DistrictId = 931, CitizenId = 26 },
                    new DistrictHead { Id = 4, ElectionId = 7, DistrictId = 935, CitizenId = 28 },

                    new DistrictHead { Id = 5, ElectionId = 7, DistrictId = 877, CitizenId = 25 },
                    new DistrictHead { Id = 6, ElectionId = 7, DistrictId = 878, CitizenId = 30 },
                    new DistrictHead { Id = 7, ElectionId = 7, DistrictId = 880, CitizenId = 21 },
                    new DistrictHead { Id = 8, ElectionId = 7, DistrictId = 883, CitizenId = 23 },

                    new DistrictHead { Id = 9, ElectionId = 7, DistrictId = 848, CitizenId = 31 },
                    new DistrictHead { Id = 10, ElectionId = 7, DistrictId = 850, CitizenId = 32 },
                    new DistrictHead { Id = 11, ElectionId = 7, DistrictId = 852, CitizenId = 32 },
                    new DistrictHead { Id = 12, ElectionId = 7, DistrictId = 855, CitizenId = 18 },

                    new DistrictHead { Id = 13, ElectionId = 7, DistrictId = 939, CitizenId = 33 },
                    new DistrictHead { Id = 14, ElectionId = 7, DistrictId = 943, CitizenId = 34 },
                    new DistrictHead { Id = 15, ElectionId = 7, DistrictId = 944, CitizenId = 35 },
                    new DistrictHead { Id = 16, ElectionId = 7, DistrictId = 951, CitizenId = 16 }
                );
                context.SaveChanges();
            }




            if (!context.Candidate.Any())
            {
                context.Candidate.AddRange(
                    new Candidate { Id = 1, Number = 1, ElectionId = 7, CitizenId = 44 },
                    new Candidate { Id = 2, Number = 2, ElectionId = 7, CitizenId = 43 }
                );
                context.SaveChanges();
            }






            if (!context.Observer.Any())
            {
                context.Observer.AddRange(
                    new Observer { Id = 1, ElectionId = 7, DistrictId = 925, CitizenId = 26, CandidateId = 1 },
                    new Observer { Id = 2, ElectionId = 7, DistrictId = 927, CitizenId = 41, CandidateId = 1 },
                    new Observer { Id = 3, ElectionId = 7, DistrictId = 931, CitizenId = 21, CandidateId = 1 },
                    new Observer { Id = 4, ElectionId = 7, DistrictId = 935, CitizenId = 25, CandidateId = 1 },
                    new Observer { Id = 5, ElectionId = 7, DistrictId = 877, CitizenId = 28, CandidateId = 1 },
                    new Observer { Id = 6, ElectionId = 7, DistrictId = 878, CitizenId = 40, CandidateId = 1 },
                    new Observer { Id = 7, ElectionId = 7, DistrictId = 880, CitizenId = 29, CandidateId = 1 },
                    new Observer { Id = 8, ElectionId = 7, DistrictId = 883, CitizenId = 38, CandidateId = 1 },
                    new Observer { Id = 9, ElectionId = 7, DistrictId = 848, CitizenId = 37, CandidateId = 2 },
                    new Observer { Id = 10, ElectionId = 7, DistrictId = 850, CitizenId = 36, CandidateId = 2 },
                    new Observer { Id = 11, ElectionId = 7, DistrictId = 852, CitizenId = 27, CandidateId = 2 },
                    new Observer { Id = 12, ElectionId = 7, DistrictId = 855, CitizenId = 22, CandidateId = 2 },
                    new Observer { Id = 13, ElectionId = 7, DistrictId = 939, CitizenId = 20, CandidateId = 2 },
                    new Observer { Id = 14, ElectionId = 7, DistrictId = 943, CitizenId = 15, CandidateId = 2 },
                    new Observer { Id = 15, ElectionId = 7, DistrictId = 944, CitizenId = 14, CandidateId = 2 },
                    new Observer { Id = 16, ElectionId = 7, DistrictId = 951, CitizenId = 13, CandidateId = 2 }
                );
                context.SaveChanges();
            }





            if (!context.Vote.Any())
            {
                context.Vote.AddRange(
                    new Vote { Id = 1, ElectionId = 7, DistrictId = 925, CitizenId = 1, CandidateId = 1 },
                    new Vote { Id = 2, ElectionId = 7, DistrictId = 927, CitizenId = 2, CandidateId = 1 },
                    new Vote { Id = 3, ElectionId = 7, DistrictId = 927, CitizenId = 3, CandidateId = 2 },
                    new Vote { Id = 4, ElectionId = 7, DistrictId = 927, CitizenId = 4, CandidateId = 1 },
                    new Vote { Id = 5, ElectionId = 7, DistrictId = 931, CitizenId = 5, CandidateId = 2 },
                    new Vote { Id = 6, ElectionId = 7, DistrictId = 931, CitizenId = 6, CandidateId = 1 },
                    new Vote { Id = 7, ElectionId = 7, DistrictId = 931, CitizenId = 7, CandidateId = 2 },
                    new Vote { Id = 8, ElectionId = 7, DistrictId = 935, CitizenId = 8, CandidateId = 2 },
                    new Vote { Id = 9, ElectionId = 7, DistrictId = 935, CitizenId = 9, CandidateId = 1 },
                    new Vote { Id = 10, ElectionId = 7, DistrictId = 935, CitizenId = 10, CandidateId = 1 },
                    new Vote { Id = 11, ElectionId = 7, DistrictId = 877, CitizenId = 11, CandidateId = 1 },
                    new Vote { Id = 12, ElectionId = 7, DistrictId = 877, CitizenId = 12, CandidateId = 2 },
                    new Vote { Id = 13, ElectionId = 7, DistrictId = 877, CitizenId = 13, CandidateId = 1 },
                    new Vote { Id = 14, ElectionId = 7, DistrictId = 878, CitizenId = 14, CandidateId = 1 },
                    new Vote { Id = 15, ElectionId = 7, DistrictId = 878, CitizenId = 15, CandidateId = 2 },
                    new Vote { Id = 16, ElectionId = 7, DistrictId = 878, CitizenId = 16, CandidateId = 2 },
                    new Vote { Id = 17, ElectionId = 7, DistrictId = 880, CitizenId = 17, CandidateId = 2 },
                    new Vote { Id = 18, ElectionId = 7, DistrictId = 880, CitizenId = 18, CandidateId = 2 },
                    new Vote { Id = 19, ElectionId = 7, DistrictId = 880, CitizenId = 19, CandidateId = 2 },
                    new Vote { Id = 20, ElectionId = 7, DistrictId = 883, CitizenId = 20, CandidateId = 1 },
                    new Vote { Id = 21, ElectionId = 7, DistrictId = 883, CitizenId = 21, CandidateId = 2 },
                    new Vote { Id = 22, ElectionId = 7, DistrictId = 883, CitizenId = 22, CandidateId = 1 },
                    new Vote { Id = 23, ElectionId = 7, DistrictId = 848, CitizenId = 23, CandidateId = 1 },
                    new Vote { Id = 24, ElectionId = 7, DistrictId = 848, CitizenId = 24, CandidateId = 1 },
                    new Vote { Id = 25, ElectionId = 7, DistrictId = 848, CitizenId = 25, CandidateId = 1 },
                    new Vote { Id = 26, ElectionId = 7, DistrictId = 850, CitizenId = 26, CandidateId = 2 },
                    new Vote { Id = 27, ElectionId = 7, DistrictId = 850, CitizenId = 27, CandidateId = 1 },
                    new Vote { Id = 28, ElectionId = 7, DistrictId = 850, CitizenId = 28, CandidateId = 2 },
                    new Vote { Id = 29, ElectionId = 7, DistrictId = 852, CitizenId = 29, CandidateId = 1 },
                    new Vote { Id = 30, ElectionId = 7, DistrictId = 852, CitizenId = 30, CandidateId = 1 },
                    new Vote { Id = 31, ElectionId = 7, DistrictId = 852, CitizenId = 31, CandidateId = 1 },
                    new Vote { Id = 32, ElectionId = 7, DistrictId = 855, CitizenId = 32, CandidateId = 2 },
                    new Vote { Id = 33, ElectionId = 7, DistrictId = 855, CitizenId = 33, CandidateId = 2 },
                    new Vote { Id = 34, ElectionId = 7, DistrictId = 939, CitizenId = 34, CandidateId = 1 },
                    new Vote { Id = 35, ElectionId = 7, DistrictId = 951, CitizenId = 35, CandidateId = 1 },
                    new Vote { Id = 36, ElectionId = 7, DistrictId = 939, CitizenId = 36, CandidateId = 1 },
                    new Vote { Id = 37, ElectionId = 7, DistrictId = 943, CitizenId = 37, CandidateId = 2 },
                    new Vote { Id = 38, ElectionId = 7, DistrictId = 943, CitizenId = 38, CandidateId = 1 },
                    new Vote { Id = 39, ElectionId = 7, DistrictId = 944, CitizenId = 39, CandidateId = 1 },
                    new Vote { Id = 40, ElectionId = 7, DistrictId = 944, CitizenId = 40, CandidateId = 2 },
                    new Vote { Id = 41, ElectionId = 7, DistrictId = 951, CitizenId = 41, CandidateId = 2 },
                    new Vote { Id = 42, ElectionId = 7, DistrictId = 951, CitizenId = 42, CandidateId = 2 }
                );
                context.SaveChanges();
            }
        }
    }
}
