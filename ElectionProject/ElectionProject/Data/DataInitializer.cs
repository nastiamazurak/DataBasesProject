
using ElectionProject.Models;
using OneDayFlat.Models;
using System;
using System.Linq;
using Type = ElectionProject.Models.Type;

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
                    new Citizen { Id = 1, FirstName = "Анастасія", LastName = "Кушнір", MiddleName = "Андріївна", BirthDate = new DateTime(2000, 7, 12), Ipn = "456789101112", DistrictId = 925, Email = "MihaylovBoyan41@gmail.com", Password = "KYt1mZlmJudr", RoleID = 5 },
                    new Citizen { Id = 2, FirstName = "Анастасія", LastName = "Мазурак", MiddleName = "Романівна", BirthDate = new DateTime(2000, 9, 25), Ipn = "456789101211", DistrictId = 927, Email = "PopovFirs236@gmail.com", Password = "nx0K04bnH4hW", RoleID = 4 },
                    new Citizen { Id = 3, FirstName = "Андрій", LastName = "Шкробут", MiddleName = "Валтерович", BirthDate = new DateTime(2000, 7, 1), Ipn = "456789111012", DistrictId = 927, Email = "BelovAnufri266@gmail.com", Password = "1yoUBNFcFlfe", RoleID = 5 },
                    new Citizen { Id = 4, FirstName = "Володимир", LastName = "Дишкант", MiddleName = "Зіновійович", BirthDate = new DateTime(2000, 7, 25), Ipn = "456789111210", DistrictId = 927, Email = "volodiadyshkant2000@gmail.com", Password = "TQDsDVRnXCKJ", RoleID = 2 },
                    new Citizen { Id = 5, FirstName = "Михайло", LastName = "Демчишин", MiddleName = "Володимирович", BirthDate = new DateTime(2000, 1, 24), Ipn = "456789121110", DistrictId = 931, Email = "AfanasevArkadiy375@gmail.com", Password = "TNOzM72jnY9c", RoleID = 2 },
                    new Citizen { Id = 6, FirstName = "Василь", LastName = "Кривоніс", MiddleName = "Романович", BirthDate = new DateTime(1966, 10, 25), Ipn = "456789121011", DistrictId = 931, Email = "SmorchkovAdam188@gmail.com", Password = "pxMJaQaTVVYd", RoleID = 2 },
                    new Citizen { Id = 7, FirstName = "Cтепан", LastName = "Холоднокровний", MiddleName = "Йосифович", BirthDate = new DateTime(1967, 12, 26), Ipn = "456781091112", DistrictId = 931, Email = "IzofatovSerafim331@gmail.com", Password = "iMQbSRl1naV0", RoleID = 2 },
                    new Citizen { Id = 8, FirstName = "Іван", LastName = "Кравченко", MiddleName = "Остапович", BirthDate = new DateTime(1977, 6, 20), Ipn = "456781091211", DistrictId = 935, Email = "MaksimovaEvelina147@gmail.com", Password = "RoJxetzJ6feZ", RoleID = 2 },
                    new Citizen { Id = 9, FirstName = "Тадей", LastName = "Розумний", MiddleName = "Іванович", BirthDate = new DateTime(1956, 9, 24), Ipn = "456781011912", DistrictId = 935, Email = "SolovevBoleslav130@gmail.com", Password = "MF5e5gCEmIJf", RoleID = 2 },
                    new Citizen { Id = 10, FirstName = "Марко", LastName = "Сотник", MiddleName = "Степанович", BirthDate = new DateTime(1970, 11, 26), Ipn = "456781011129", DistrictId = 935, Email = "NikiforovOlimpiy40@gmail.com", Password = "TzoyT3B55T21", RoleID = 5 },
                    new Citizen { Id = 11, FirstName = "Ярослав", LastName = "Недолугий", MiddleName = "Романович", BirthDate = new DateTime(2000, 2, 19), Ipn = "456781012119", DistrictId = 877, Email = "MamedovaKleopatra383@gmail.com", Password = "awNMGE5aqQlS", RoleID = 5 },
                    new Citizen { Id = 12, FirstName = "Ілля", LastName = "Малкович", MiddleName = "Абдулович", BirthDate = new DateTime(2000, 9, 12), Ipn = "456781012911", DistrictId = 877, Email = "OstimchukEmma167@gmail.com", Password = "OstimchukEmma167", RoleID = 4 },
                    new Citizen { Id = 13, FirstName = "Олеся", LastName = "Кушнір", MiddleName = "Олегівна", BirthDate = new DateTime(1978, 2, 19), Ipn = "456781110912", DistrictId = 877, Email = "PetrovaTatyana297@gmail.com", Password = "SpPm0D79kn15", RoleID = 2 },
                    new Citizen { Id = 14, FirstName = "Олег", LastName = "Ващишин", MiddleName = "Тарасович", BirthDate = new DateTime(1975, 3, 19), Ipn = "456781110129", DistrictId = 878, Email = "GulevichBronislava105@gmail.com", Password = "vcRDMiF6nc5S", RoleID = 2 },
                    new Citizen { Id = 15, FirstName = "Марія", LastName = "Чабанна", MiddleName = "Ярославівна", BirthDate = new DateTime(1974, 4, 29), Ipn = "456781191012", DistrictId = 878, Email = "KukolevskayaIraida216@gmail.com", Password = "NHi7H21VFWPB", RoleID = 2 },
                    new Citizen { Id = 16, FirstName = "Тетяна", LastName = "Сліпачук", MiddleName = "Володимирівна", BirthDate = new DateTime(1968, 5, 25), Ipn = "456781191210", DistrictId = 878, Email = "AleksandrovBronislav25@gmail.com", Password = "qTHle9z8QCzG", RoleID = 5 },
                    new Citizen { Id = 17, FirstName = "Роман", LastName = "Куновский", MiddleName = "Володимирович", BirthDate = new DateTime(1969, 5, 26), Ipn = "456781112910", DistrictId = 880, Email = "ZaytsevLeonid314@gmail.com", Password = "uw8hphWBCCGP", RoleID = 5 },
                    new Citizen { Id = 18, FirstName = "Марія", LastName = "Лопушанська", MiddleName = "Петрівна", BirthDate = new DateTime(1964, 4, 27), Ipn = "456781112109", DistrictId = 880, Email = "MuravevaZoya397@gmail.com", Password = "NJrQlopXZmEi", RoleID = 2 },
                    new Citizen { Id = 19, FirstName = "Юрій", LastName = "Трухан", MiddleName = "Степанович", BirthDate = new DateTime(1950, 5, 27), Ipn = "456781210911", DistrictId = 880, Email = "TrifonovaEleonora83@gmail.com", Password = "HcsmZRZ5cS0I", RoleID = 2 },
                    new Citizen { Id = 20, FirstName = "Тамара", LastName = "Дзюмба", MiddleName = "Петрівна", BirthDate = new DateTime(1960, 3, 5), Ipn = "456781211109", DistrictId = 883, Email = "SemenovaDiana42@gmail.com", Password = "jhx9v0ArMCMu", RoleID = 5 },
                    new Citizen { Id = 21, FirstName = "Ярина", LastName = "Дзюмбочок", MiddleName = "Євгенівна", BirthDate = new DateTime(1965, 11, 15), Ipn = "456781211910", DistrictId = 883, Email = "ZaharovaNadejda313@gmail.com", Password = "T4Ix2uYPLGjW", RoleID = 2 },
                    new Citizen { Id = 22, FirstName = "Віталій", LastName = "Воробйов", MiddleName = "Сергійович", BirthDate = new DateTime(1966, 12, 14), Ipn = "456781291110", DistrictId = 883, Email = "LitvinaIzolda267@gmail.com", Password = "3Z93FmynjAgl", RoleID = 2 },
                    new Citizen { Id = 23, FirstName = "Олег", LastName = "Ващишин", MiddleName = "Тарасович", BirthDate = new DateTime(1976, 9, 15), Ipn = "456781291011", DistrictId = 848, Email = "TayskayaLiya367@gmail.com", Password = "H18a8cJ04A7R", RoleID = 2 },
                    new Citizen { Id = 24, FirstName = "Марія", LastName = "Горбань", MiddleName = "Констянтинівна", BirthDate = new DateTime(1973, 9, 21), Ipn = "456798101112", DistrictId = 848, Email = "PetrovSamuil139@gmail.com", Password = "QISxbfMLoDRr", RoleID = 5 },
                    new Citizen { Id = 25, FirstName = "Олександра", LastName = "Присяжник", MiddleName = "Олегівна", BirthDate = new DateTime(1979, 10, 1), Ipn = "456798101211", DistrictId = 848, Email = "ChistyakovaLiliya364@gmail.com", Password = "S9swLSMSaeAJ", RoleID = 2 },
                    new Citizen { Id = 26, FirstName = "Андрій", LastName = "Присяжник", MiddleName = "Романович", BirthDate = new DateTime(1989, 11, 25), Ipn = "456798111012", DistrictId = 850, Email = "GusevAram123@gmail.com", Password = "g6Ib11pOkphQ", RoleID = 5 },
                    new Citizen { Id = 27, FirstName = "Ігор", LastName = "Присяжник", MiddleName = "Романович", BirthDate = new DateTime(1989, 11, 25), Ipn = "456798111210", DistrictId = 850, Email = "TyurinRatmir204@gmail.com", Password = "jr1y2nUIGcAu", RoleID = 2 },
                    new Citizen { Id = 28, FirstName = "Тетяна", LastName = "Присяжник", MiddleName = "Романівна", BirthDate = new DateTime(1993, 3, 7), Ipn = "456798121110", DistrictId = 850, Email = "NikitinaAnna97@gmail.com", Password = "2loxVwoa2iHa", RoleID = 4 },
                    new Citizen { Id = 29, FirstName = "Василь", LastName = "Дмитришин", MiddleName = "Андрійович", BirthDate = new DateTime(1969, 12, 5), Ipn = "456798121011", DistrictId = 852, Email = "ProkofevPlaton368@gmail.com", Password = "Hf2JPuDzRShr", RoleID = 5 },
                    new Citizen { Id = 30, FirstName = "Іван", LastName = "Винявський", MiddleName = "Михайлович", BirthDate = new DateTime(2000, 2, 12), Ipn = "456791081112", DistrictId = 852, Email = "AndronovSemen233@gmail.com", Password = "QVfXP4Zo31MF", RoleID = 2 },
                    new Citizen { Id = 31, FirstName = "Ольга", LastName = "Кривоніс", MiddleName = "Михайлівна", BirthDate = new DateTime(1955, 2, 24), Ipn = "456791081211", DistrictId = 852, Email = "PavlovKazimir22@gmail.com", Password = "mvESlfMESvkD", RoleID = 2 },
                    new Citizen { Id = 32, FirstName = "Вікторія", LastName = "Чумакевич", MiddleName = "Вікторівна", BirthDate = new DateTime(1967, 6, 20), Ipn = "456791011812", DistrictId = 855, Email = "IvanovZosima177@gmail.com", Password = "52ViOzqwfL56", RoleID = 5 },
                    new Citizen { Id = 33, FirstName = "Володимир", LastName = "Куриляк", MiddleName = "Романович", BirthDate = new DateTime(1998, 6, 6), Ipn = "456791011128", DistrictId = 855, Email = "DavyidovPankrat72@gmail.com", Password = "6jlspr1Srom6", RoleID = 2 },
                    new Citizen { Id = 34, FirstName = "Петро", LastName = "Фурдичко", MiddleName = "Олегович", BirthDate = new DateTime(1976, 10, 8), Ipn = "456791012118", DistrictId = 939, Email = "FomovFoka396@gmail.com", Password = "AOZ6k2XrPDIl", RoleID = 5 },
                    new Citizen { Id = 35, FirstName = "Василь", LastName = "Тимчишин", MiddleName = "Романович", BirthDate = new DateTime(1964, 8, 10), Ipn = "456791012811", DistrictId = 951, Email = "OsipovaAmina110@gmail.com", Password = "bqAJ7bbrQUqt", RoleID = 2 },
                    new Citizen { Id = 36, FirstName = "Роман", LastName = "Кривий", MiddleName = "Романович", BirthDate = new DateTime(1976, 8, 13), Ipn = "456791110812", DistrictId = 939, Email = "VorobevaInga232@gmail.com", Password = "7zVFg1wtWdku", RoleID = 2 },
                    new Citizen { Id = 37, FirstName = "Настя", LastName = "Мудра", MiddleName = "Романівна", BirthDate = new DateTime(1965, 4, 10), Ipn = "456791110128", DistrictId = 943, Email = "FedorovaBronislava109@gmail.com", Password = "cZ0YFNjStZmh", RoleID = 5 },
                    new Citizen { Id = 38, FirstName = "Наталя", LastName = "Ліб", MiddleName = "Марківна", BirthDate = new DateTime(1993, 7, 7), Ipn = "456791181012", DistrictId = 943, Email = "RusovaStepanida258@gmail.com", Password = "rHqXTMafheFn", RoleID = 2 },
                    new Citizen { Id = 39, FirstName = "Марко", LastName = "Бучковський", MiddleName = "Романович", BirthDate = new DateTime(1977, 8, 19), Ipn = "456791181210", DistrictId = 944, Email = "AfanasevArno250@gmail.com", Password = "Ym9N9Z5NCdrD", RoleID = 5 },
                    new Citizen { Id = 40, FirstName = "Владислав", LastName = "Панчак", MiddleName = "Андрійович", BirthDate = new DateTime(1973, 6, 15), Ipn = "456791112108", DistrictId = 944, Email = "ProkofevTrifon262@gmail.com", Password = "xivrAI9oOCAv", RoleID = 4 },
                    new Citizen { Id = 41, FirstName = "Ярослав", LastName = "Бориско", MiddleName = "Романович", BirthDate = new DateTime(1951, 1, 10), Ipn = "456791210118", DistrictId = 951, Email = "ArdjevanidzeStanislav398@gmail.com", Password = "3YzqSEGJTD4B", RoleID = 2 },
                    new Citizen { Id = 42, FirstName = "Роман ", LastName = "Царь", MiddleName = "Романович", BirthDate = new DateTime(1964, 1, 11), Ipn = "456791210811", DistrictId = 951, Email = "SekunovUstin395@gmail.com", Password = "E69Iu0Rmjwtj", RoleID = 5 },
                    new Citizen { Id = 43, FirstName = "Олексій", LastName = "Темченко", MiddleName = "Андрійович", BirthDate = new DateTime(2000, 10, 12), Ipn = "456791211108", DistrictId = 925, Email = "FilippovAmayak48@gmail.com", Password = "fGTuWhm2sZK2", RoleID = 6 },
                    new Citizen { Id = 44, FirstName = "Олена", LastName = "Пархоменко", MiddleName = "Романівна", BirthDate = new DateTime(2000, 1, 20), Ipn = "456791211810", DistrictId = 927, Email = "ScherbakovBonifatsiy62@gmail.com", Password = "UIGp3Wy6u1s7", RoleID = 6 },
                    new Citizen { Id = 45, FirstName = "Максим", LastName = "Поліщук", MiddleName = "Ігорович", BirthDate = new DateTime(2000, 8, 3), Ipn = "456791281110", DistrictId = 927, Email = "RoschinaSofya309@gmail.com", Password = "KZ7Fx9D0DNMt", RoleID = 2 },
                    new Citizen { Id = 46, FirstName = "Зеник", LastName = "Яровий", MiddleName = "Романович", BirthDate = new DateTime(2000, 12, 4), Ipn = "456791281011", DistrictId = 927, Email = "BaranovaKseniya270@gmail.com", Password = "MDcBHPaaSG6H", RoleID = 2 },
                    new Citizen { Id = 47, FirstName = "Оксана", LastName = "Лапченко", MiddleName = "Павлівна", BirthDate = new DateTime(2000, 6, 14), Ipn = "456710981112", DistrictId = 931, Email = "SidorovKazimir362@gmail.com", Password = "4ZhY7cDOg7ap", RoleID = 6 },
                    new Citizen { Id = 48, FirstName = "Христина", LastName = "Добровольська", MiddleName = "Миколаївна", BirthDate = new DateTime(1986, 10, 29), Ipn = "456710981211", DistrictId = 931, Email = "ChaurinaAlla384@gmail.com", Password = "S2pqyurwAaOw", RoleID = 2 },
                    new Citizen { Id = 49, FirstName = "Ольга", LastName = "Кушнір", MiddleName = "Богданівна", BirthDate = new DateTime(1977, 2, 16), Ipn = "456710911812", DistrictId = 931, Email = "VolkovTihon238@gmail.com", Password = "XIDTKIIbTxR7", RoleID = 2 },
                    new Citizen { Id = 50, FirstName = "Іван", LastName = "Кравченко", MiddleName = "Максимович", BirthDate = new DateTime(1967, 8, 13), Ipn = "456710911128", DistrictId = 935, Email = "HolodkovHristofor220@gmail.com", Password = "iuQ1LtEj8Wzd", RoleID = 6 },
                    new Citizen { Id = 51, FirstName = "Остап", LastName = "Сухай", MiddleName = "Іванович", BirthDate = new DateTime(1989, 4, 5), Ipn = "456710912118", DistrictId = 935, Email = "FedotovTimofey38@gmail.com", Password = "xlO2AyJzyUZc", RoleID = 2 },
                    new Citizen { Id = 52, FirstName = "Олег", LastName = "Кокоцький", MiddleName = "Юрійович", BirthDate = new DateTime(1978, 3, 7), Ipn = "456710912811", DistrictId = 935, Email = "KirillovBenedikt372@gmail.com", Password = "ZrauLpSv6Q6K", RoleID = 2 },
                    new Citizen { Id = 53, FirstName = "Софія", LastName = "Мокрик", MiddleName = "Олегівна", BirthDate = new DateTime(2000, 7, 19), Ipn = "456710891112", DistrictId = 877, Email = "MamedovAmvrosiy361@gmail.com", Password = "7x0YwzraY3Q0", RoleID = 6 },
                    new Citizen { Id = 54, FirstName = "Діана", LastName = "Місьо", MiddleName = "Олексіївна", BirthDate = new DateTime(2000, 1, 8), Ipn = "456710891211", DistrictId = 877, Email = "VeselkovaIraida137@gmail.com", Password = "MwzEWzD3POu6", RoleID = 2 },
                    new Citizen { Id = 55, FirstName = "Ольга", LastName = "Степаненко", MiddleName = "Олегівна", BirthDate = new DateTime(1999, 1, 19), Ipn = "456710811912", DistrictId = 877, Email = "KryilovaDiana128@gmail.com", Password = "Jkq4AubIZB0y", RoleID = 2 },
                    new Citizen { Id = 56, FirstName = "Олег", LastName = "Михальський", MiddleName = "Євгенович", BirthDate = new DateTime(1995, 5, 12), Ipn = "456710811129", DistrictId = 878, Email = "JuravlevaEkaterina338@gmail.com", Password = "hMAGs2wop9Y2", RoleID = 6 },
                    new Citizen { Id = 57, FirstName = "Остап", LastName = "Врублевський", MiddleName = "Михайлович", BirthDate = new DateTime(1987, 2, 14), Ipn = "456710812119", DistrictId = 878, Email = "ShashkovaRada123@gmail.com", Password = "PzjFKQsPqyVx", RoleID = 2 },
                    new Citizen { Id = 58, FirstName = "Юлія", LastName = "Макарець", MiddleName = "Анатолівна", BirthDate = new DateTime(1993, 2, 7), Ipn = "456710812911", DistrictId = 878, Email = "MaksimovaMalvina171@gmail.com", Password = "YnwiU4Yog4gF", RoleID = 2 },
                    new Citizen { Id = 59, FirstName = "Микола", LastName = "Дичко", MiddleName = "Валерійович", BirthDate = new DateTime(1969, 10, 12), Ipn = "456710118912", DistrictId = 880, Email = "PchelkinRostislav126@gmail.com", Password = "4EvGQoTKbLx7", RoleID = 6 },
                    new Citizen { Id = 60, FirstName = "Максим", LastName = "Дурняк", MiddleName = "Романович", BirthDate = new DateTime(1993, 1, 27), Ipn = "456710118129", DistrictId = 880, Email = "PavlovLeonid84@gmail.com", Password = "K6ZKWv3GxpeH", RoleID = 2 },
                    new Citizen { Id = 61, FirstName = "Володимир", LastName = "Дуткевич", MiddleName = "Антонович", BirthDate = new DateTime(1984, 8, 25), Ipn = "456710119812", DistrictId = 880, Email = "KomarovaEmma333@gmail.com", Password = "vAynyAtDVkgP", RoleID = 2 },
                    new Citizen { Id = 62, FirstName = "Вероніка", LastName = "Баландюх", MiddleName = "Романівна", BirthDate = new DateTime(1986, 4, 15), Ipn = "456710119128", DistrictId = 883, Email = "ByikovOstromir173@gmail.com", Password = "l1jcBQ5PyvyR", RoleID = 2 },
                    new Citizen { Id = 63, FirstName = "Ярина", LastName = "Віхаста", MiddleName = "Євгенівна", BirthDate = new DateTime(1996, 12, 14), Ipn = "456710111298", DistrictId = 883, Email = "JukovaLyubov357@gmail.com", Password = "5YrpynRgQkCe", RoleID = 6 },
                    new Citizen { Id = 64, FirstName = "Віталій", LastName = "Макарець", MiddleName = "Анатолійович", BirthDate = new DateTime(1984, 11, 17), Ipn = "456710111289", DistrictId = 883, Email = "KryilovSeliverst105@gmail.com", Password = "sjlEgKPalgv7", RoleID = 2 },
                    new Citizen { Id = 65, FirstName = "Микола", LastName = "Мартин", MiddleName = "Михайлович", BirthDate = new DateTime(1980, 7, 23), Ipn = "456710128119", DistrictId = 848, Email = "DenisovaLidiya315@gmail.com", Password = "6TM9eGGW1854", RoleID = 2 },
                    new Citizen { Id = 66, FirstName = "Богданна", LastName = "Безп'ята", MiddleName = "Констянтинівна", BirthDate = new DateTime(1976, 2, 21), Ipn = "456710128911", DistrictId = 848, Email = "GorodnovNikolay397@gmail.com", Password = "Eg0xxImfav4f", RoleID = 6 },
                    new Citizen { Id = 67, FirstName = "Юлія", LastName = "Бодак", MiddleName = "Андріївна", BirthDate = new DateTime(1965, 12, 5), Ipn = "456710121189", DistrictId = 848, Email = "ChistyakovaVassa181@gmail.com", Password = "BIljwEbpXSQI", RoleID = 2 },
                    new Citizen { Id = 68, FirstName = "Андрій", LastName = "Михаш", MiddleName = "Ярославович", BirthDate = new DateTime(1989, 2, 22), Ipn = "456710121198", DistrictId = 850, Email = "NovikovaBeatrisa282@gmail.com", Password = "VBGr53PJANy7", RoleID = 6 },
                    new Citizen { Id = 69, FirstName = "Іван", LastName = "Новіков", MiddleName = "Романович", BirthDate = new DateTime(1990, 1, 23), Ipn = "456710129118", DistrictId = 850, Email = "KudryavtsevBoyan259@gmail.com", Password = "QTN6i7rZrBZd", RoleID = 2 },
                    new Citizen { Id = 70, FirstName = "Яна", LastName = "Горбач", MiddleName = "Юліанівна", BirthDate = new DateTime(1997, 6, 9), Ipn = "456710129811", DistrictId = 850, Email = "ShashkovEduard214@gmail.com", Password = "6vhIWmd6GyGw", RoleID = 2 },
                    new Citizen { Id = 71, FirstName = "Сергій", LastName = "Городечний", MiddleName = "Іванович", BirthDate = new DateTime(1994, 4, 25), Ipn = "456711910812", DistrictId = 852, Email = "TyurinaInna254@gmail.com", Password = "PoCz4wGp295p", RoleID = 6 },
                    new Citizen { Id = 72, FirstName = "Андрій", LastName = "Косів", MiddleName = "Іванович", BirthDate = new DateTime(2000, 5, 30), Ipn = "456711910128", DistrictId = 852, Email = "TyurinIgor376@gmail.com", Password = "vJivlcESQC6e", RoleID = 2 },
                    new Citizen { Id = 73, FirstName = "Віктор", LastName = "Сидор", MiddleName = "Ігорович", BirthDate = new DateTime(1976, 5, 24), Ipn = "456711981012", DistrictId = 852, Email = "DemyanovaAgrippina81@gmail.com", Password = "aXqTY69zRPDP", RoleID = 2 },
                    new Citizen { Id = 74, FirstName = "Катерина", LastName = "Студенкова", MiddleName = "Назарівна", BirthDate = new DateTime(1977, 9, 12), Ipn = "456711981210", DistrictId = 855, Email = "LeontevAnton19@gmail.com", Password = "8J4KfSWDkcfR", RoleID = 6 },
                    new Citizen { Id = 75, FirstName = "Христина", LastName = "Голод", MiddleName = "Ігорівна", BirthDate = new DateTime(1991, 5, 16), Ipn = "456711912810", DistrictId = 855, Email = "ByikovVadim229@gmail.com", Password = "xml7MZHrVWPn", RoleID = 2 },
                    new Citizen { Id = 76, FirstName = "Василь", LastName = "Голуб", MiddleName = "Володимирович", BirthDate = new DateTime(1959, 10, 28), Ipn = "456711912108", DistrictId = 939, Email = "BaykovVladimir60@gmail.com", Password = "NEIIOCesQLgA", RoleID = 6 },
                    new Citizen { Id = 77, FirstName = "Сергій", LastName = "Серванський", MiddleName = "Борисович", BirthDate = new DateTime(1994, 12, 10), Ipn = "456711109812", DistrictId = 951, Email = "NikitinVladlen22@gmail.com", Password = "R9qz73aFpqMi", RoleID = 6 },
                    new Citizen { Id = 78, FirstName = "Аліна", LastName = "Шейнов", MiddleName = "Тимурівна", BirthDate = new DateTime(1999, 10, 26), Ipn = "456711109128", DistrictId = 939, Email = "RusovVelimir196@gmail.com", Password = "NDZ8niiyh84T", RoleID = 2 },
                    new Citizen { Id = 79, FirstName = "Владислав", LastName = "Шабан", MiddleName = "Андрійович", BirthDate = new DateTime(1970, 7, 22), Ipn = "456711108912", DistrictId = 943, Email = "ArsenevVseslav398@gmail.com", Password = "ez34UIIRr4ZA", RoleID = 2 },
                    new Citizen { Id = 80, FirstName = "Любомир", LastName = "Саків", MiddleName = "Юліанович", BirthDate = new DateTime(1999, 4, 18), Ipn = "456711108129", DistrictId = 943, Email = "NazarovTimofey387@gmail.com", Password = "jxTRrMuLn3Vv", RoleID = 2 },
                    new Citizen { Id = 81, FirstName = "Мирослав", LastName = "Буковський", MiddleName = "Максимович", BirthDate = new DateTime(1986, 11, 7), Ipn = "456711101289", DistrictId = 944, Email = "SmirnovRadovan26@gmail.com", Password = "l1b4sOhNDxh3", RoleID = 6 },
                    new Citizen { Id = 82, FirstName = "Юлія", LastName = "Павук", MiddleName = "Олегівна", BirthDate = new DateTime(1967, 4, 27), Ipn = "456711101298", DistrictId = 944, Email = "ShashkovFerapont65@gmail.com", Password = "fodrIwPnkkZn", RoleID = 2 },
                    new Citizen { Id = 83, FirstName = "Костянтин", LastName = "Покоцький", MiddleName = "Ярославович", BirthDate = new DateTime(1977, 4, 8), Ipn = "456711810912", DistrictId = 951, Email = "ShershovPavel85@gmail.com", Password = "Ilo9gbk0jBTE", RoleID = 6 },
                    new Citizen { Id = 84, FirstName = "Юрій ", LastName = "Костюк", MiddleName = "Владиславович", BirthDate = new DateTime(1985, 4, 9), Ipn = "456711810129", DistrictId = 951, Email = "JuravlevMokey267@gmail.com", Password = "tXnbsCloZ1N0", RoleID = 2 }

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
                    new Election { Id = 6, Name = "Позачергові вибори", Year = 2014, Tour = 1, StartDate = new DateTime(2014, 5, 25), EndDate = new DateTime(2014, 5, 30), HeadOfCvk = 22 },
                    new Election { Id = 7, Name = "Вибори президента", Year = 2019, Tour = 2, StartDate = new DateTime(2019, 3, 30), EndDate = new DateTime(2019, 4, 21), HeadOfCvk = 17 }
                );
                context.SaveChanges();
            }





            if (!context.CircuitHead.Any())
            {
                context.CircuitHead.AddRange(
                    new CircuitHead { Id = 1, ElectionId = 7, CircuitId = 115, CitizenId = 2 },
                    new CircuitHead { Id = 2, ElectionId = 7, CircuitId = 116, CitizenId = 12 },
                    new CircuitHead { Id = 3, ElectionId = 7, CircuitId = 117, CitizenId = 28 },
                    new CircuitHead { Id = 4, ElectionId = 7, CircuitId = 118, CitizenId = 40 }

                /*new CircuitHead { Id = 1, ElectionId = 1, CircuitId = 115, CitizenId = 2 },
                new CircuitHead { Id = 2, ElectionId = 1, CircuitId = 116, CitizenId = 12 },
                new CircuitHead { Id = 3, ElectionId = 1, CircuitId = 117, CitizenId = 28 },
                new CircuitHead { Id = 4, ElectionId = 1, CircuitId = 118, CitizenId = 40 }

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
             new CircuitHead { Id = 28, ElectionId = 7, CircuitId = 118, CitizenId = 17 }*/
                );
                context.SaveChanges();
            }




            if (!context.DistrictHead.Any())
            {
                context.DistrictHead.AddRange(
                    new DistrictHead { Id = 1, ElectionId = 7, DistrictId = 925, CitizenId = 1 },
                    new DistrictHead { Id = 2, ElectionId = 7, DistrictId = 927, CitizenId = 3 },
                    new DistrictHead { Id = 3, ElectionId = 7, DistrictId = 931, CitizenId = 5 },
                    new DistrictHead { Id = 4, ElectionId = 7, DistrictId = 935, CitizenId = 10 },

                    new DistrictHead { Id = 5, ElectionId = 7, DistrictId = 877, CitizenId = 11 },
                    new DistrictHead { Id = 6, ElectionId = 7, DistrictId = 878, CitizenId = 16 },
                    new DistrictHead { Id = 7, ElectionId = 7, DistrictId = 880, CitizenId = 17 },
                    new DistrictHead { Id = 8, ElectionId = 7, DistrictId = 883, CitizenId = 20 },

                    new DistrictHead { Id = 9, ElectionId = 7, DistrictId = 848, CitizenId = 24 },
                    new DistrictHead { Id = 10, ElectionId = 7, DistrictId = 850, CitizenId = 26 },
                    new DistrictHead { Id = 11, ElectionId = 7, DistrictId = 852, CitizenId = 29 },
                    new DistrictHead { Id = 12, ElectionId = 7, DistrictId = 855, CitizenId = 32 },

                    new DistrictHead { Id = 13, ElectionId = 7, DistrictId = 939, CitizenId = 34 },
                    new DistrictHead { Id = 14, ElectionId = 7, DistrictId = 943, CitizenId = 37 },
                    new DistrictHead { Id = 15, ElectionId = 7, DistrictId = 944, CitizenId = 39 },
                    new DistrictHead { Id = 16, ElectionId = 7, DistrictId = 951, CitizenId = 42 }
                );
                context.SaveChanges();
            }




            if (!context.Candidate.Any())
            {
                context.Candidate.AddRange(
                    new Candidate { Id = 1, Number = 1, ElectionId = 7, CitizenId = 44 },
                    new Candidate { Id = 2, Number = 2, ElectionId = 7, CitizenId = 43 },
                    new Candidate { Id = 3, Number = 3, ElectionId = 7, CitizenId = 84 },
                    new Candidate { Id = 4, Number = 4, ElectionId = 7, CitizenId = 65 }
                );
                context.SaveChanges();
            }






            if (!context.Observer.Any())
            {
                context.Observer.AddRange(
                    new Observer { Id = 1, ElectionId = 7, DistrictId = 925, CitizenId = 43, CandidateId = 1 },
                    new Observer { Id = 2, ElectionId = 7, DistrictId = 927, CitizenId = 44, CandidateId = 1 },
                    new Observer { Id = 3, ElectionId = 7, DistrictId = 931, CitizenId = 47, CandidateId = 1 },
                    new Observer { Id = 4, ElectionId = 7, DistrictId = 935, CitizenId = 50, CandidateId = 1 },
                    new Observer { Id = 5, ElectionId = 7, DistrictId = 877, CitizenId = 53, CandidateId = 1 },
                    new Observer { Id = 6, ElectionId = 7, DistrictId = 878, CitizenId = 56, CandidateId = 1 },
                    new Observer { Id = 7, ElectionId = 7, DistrictId = 880, CitizenId = 59, CandidateId = 1 },
                    new Observer { Id = 8, ElectionId = 7, DistrictId = 883, CitizenId = 63, CandidateId = 1 },
                    new Observer { Id = 9, ElectionId = 7, DistrictId = 848, CitizenId = 66, CandidateId = 2 },
                    new Observer { Id = 10, ElectionId = 7, DistrictId = 850, CitizenId = 68, CandidateId = 2 },
                    new Observer { Id = 11, ElectionId = 7, DistrictId = 852, CitizenId = 71, CandidateId = 2 },
                    new Observer { Id = 12, ElectionId = 7, DistrictId = 855, CitizenId = 74, CandidateId = 2 },
                    new Observer { Id = 13, ElectionId = 7, DistrictId = 939, CitizenId = 76, CandidateId = 2 },
                    new Observer { Id = 14, ElectionId = 7, DistrictId = 943, CitizenId = 77, CandidateId = 2 },
                    new Observer { Id = 15, ElectionId = 7, DistrictId = 944, CitizenId = 81, CandidateId = 2 },
                    new Observer { Id = 16, ElectionId = 7, DistrictId = 951, CitizenId = 83, CandidateId = 2 }
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
                    new Vote { Id = 42, ElectionId = 7, DistrictId = 951, CitizenId = 42, CandidateId = 2 },

                    new Vote { Id = 43, ElectionId = 7, DistrictId = 925, CitizenId = 43, CandidateId = 3 },
                    new Vote { Id = 44, ElectionId = 7, DistrictId = 927, CitizenId = 44, CandidateId = 3 },
                    new Vote { Id = 45, ElectionId = 7, DistrictId = 927, CitizenId = 45, CandidateId = 4 },
                    new Vote { Id = 46, ElectionId = 7, DistrictId = 927, CitizenId = 46, CandidateId = 3 },
                    new Vote { Id = 47, ElectionId = 7, DistrictId = 931, CitizenId = 47, CandidateId = 3 },
                    new Vote { Id = 48, ElectionId = 7, DistrictId = 931, CitizenId = 48, CandidateId = 4 },
                    new Vote { Id = 49, ElectionId = 7, DistrictId = 931, CitizenId = 49, CandidateId = 4 },
                    new Vote { Id = 50, ElectionId = 7, DistrictId = 935, CitizenId = 50, CandidateId = 4 },
                    new Vote { Id = 51, ElectionId = 7, DistrictId = 935, CitizenId = 51, CandidateId = 3 },
                    new Vote { Id = 52, ElectionId = 7, DistrictId = 935, CitizenId = 52, CandidateId = 3 },
                    new Vote { Id = 53, ElectionId = 7, DistrictId = 877, CitizenId = 53, CandidateId = 4 },
                    new Vote { Id = 54, ElectionId = 7, DistrictId = 877, CitizenId = 54, CandidateId = 3 },
                    new Vote { Id = 55, ElectionId = 7, DistrictId = 877, CitizenId = 55, CandidateId = 4 },
                    new Vote { Id = 56, ElectionId = 7, DistrictId = 878, CitizenId = 56, CandidateId = 1 },
                    new Vote { Id = 57, ElectionId = 7, DistrictId = 878, CitizenId = 57, CandidateId = 2 },
                    new Vote { Id = 58, ElectionId = 7, DistrictId = 878, CitizenId = 58, CandidateId = 3 },
                    new Vote { Id = 59, ElectionId = 7, DistrictId = 880, CitizenId = 59, CandidateId = 2 },
                    new Vote { Id = 60, ElectionId = 7, DistrictId = 880, CitizenId = 60, CandidateId = 4 },
                    new Vote { Id = 61, ElectionId = 7, DistrictId = 880, CitizenId = 61, CandidateId = 3 },
                    new Vote { Id = 62, ElectionId = 7, DistrictId = 883, CitizenId = 62, CandidateId = 4 },
                    new Vote { Id = 63, ElectionId = 7, DistrictId = 883, CitizenId = 63, CandidateId = 2 },
                    new Vote { Id = 64, ElectionId = 7, DistrictId = 883, CitizenId = 64, CandidateId = 3 },
                    new Vote { Id = 65, ElectionId = 7, DistrictId = 848, CitizenId = 65, CandidateId = 3 },
                    new Vote { Id = 66, ElectionId = 7, DistrictId = 848, CitizenId = 66, CandidateId = 3 },
                    new Vote { Id = 67, ElectionId = 7, DistrictId = 848, CitizenId = 67, CandidateId = 3 },
                    new Vote { Id = 68, ElectionId = 7, DistrictId = 850, CitizenId = 68, CandidateId = 4 },
                    new Vote { Id = 69, ElectionId = 7, DistrictId = 850, CitizenId = 69, CandidateId = 4 },
                    new Vote { Id = 70, ElectionId = 7, DistrictId = 850, CitizenId = 70, CandidateId = 4 },
                    new Vote { Id = 71, ElectionId = 7, DistrictId = 852, CitizenId = 71, CandidateId = 3 },
                    new Vote { Id = 72, ElectionId = 7, DistrictId = 852, CitizenId = 72, CandidateId = 4 },
                    new Vote { Id = 73, ElectionId = 7, DistrictId = 852, CitizenId = 73, CandidateId = 3 },
                    new Vote { Id = 74, ElectionId = 7, DistrictId = 855, CitizenId = 74, CandidateId = 4 },
                    new Vote { Id = 75, ElectionId = 7, DistrictId = 855, CitizenId = 75, CandidateId = 4 },
                    new Vote { Id = 76, ElectionId = 7, DistrictId = 939, CitizenId = 76, CandidateId = 3 },
                    new Vote { Id = 77, ElectionId = 7, DistrictId = 951, CitizenId = 77, CandidateId = 1 }

                );
                context.SaveChanges();
            }

            if (!context.Type.Any())
            {
                context.Type.AddRange(
                    new Type { Id = 1, Name = "Пропозиція" },
                    new Type { Id = 2, Name = "Клопотання" },
                    new Type { Id = 3, Name = "Скарга" },
                    new Type { Id = 4, Name = "Електронна петиція" }
                );
                context.SaveChanges();
            }

            if (!context.Appeal.Any())
            {
                context.Appeal.AddRange(
                    new Appeal { Id = 1, ElectionId = 7, DistrictId = 925, CitizenId = 1, TypeId = 1, Text = "Нова дільниця" },
                    new Appeal { Id = 2, ElectionId = 7, DistrictId = 927, CitizenId = 4, TypeId = 1, Text = "Нова дільниця" },
                    new Appeal { Id = 3, ElectionId = 7, DistrictId = 931, CitizenId = 8, TypeId = 1, Text = "Нова дільниця" },
                    new Appeal { Id = 4, ElectionId = 7, DistrictId = 848, CitizenId = 24, TypeId = 1, Text = "Нова дільниця" },
                    new Appeal { Id = 5, ElectionId = 7, DistrictId = 927, CitizenId = 39, TypeId = 2, Text = "Поставити наглядача" },
                    new Appeal { Id = 6, ElectionId = 7, DistrictId = 925, CitizenId = 35, TypeId = 2, Text = "Поставити наглядача" },
                    new Appeal { Id = 7, ElectionId = 7, DistrictId = 951, CitizenId = 42, TypeId = 2, Text = "Поставити наглядача" },
                    new Appeal { Id = 8, ElectionId = 7, DistrictId = 951, CitizenId = 41, TypeId = 2, Text = "Поставити наглядача" }
                );
                context.SaveChanges();
            }


            if (!context.Complaint.Any())
            {
                context.Complaint.AddRange(
                    new Complaint { Id = 1, ElectionId = 7, DistrictId = 925, ObserverId = 1, TypeId = 3, Text = "Неправильні результати" },
                    new Complaint { Id = 2, ElectionId = 7, DistrictId = 927, ObserverId = 4, TypeId = 3, Text = "Фальсифікація" },
                    new Complaint { Id = 3, ElectionId = 7, DistrictId = 935, ObserverId = 5, TypeId = 3, Text = "Фальсифікація" },
                    new Complaint { Id = 4, ElectionId = 7, DistrictId = 880, ObserverId = 7, TypeId = 3, Text = "Зайві голоси" }
                );
                context.SaveChanges();
            }
        }
    }
}
