using AutoMapper;
using ConsoleEFCoreApp.NewContext;
using ConsoleEFCoreApp.OldContext;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleEFCoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PM_Models.Advertise, PHR_Models.Advertise>();
                cfg.CreateMap<PM_Models.Type, PHR_Models.Category>();
                cfg.CreateMap<PM_Models.Direction, PHR_Models.Direction>();
                cfg.CreateMap<PM_Models.District, PHR_Models.District>();
                cfg.CreateMap<PM_Models.Product, PHR_Models.Product>();
                cfg.CreateMap<PM_Models.Status, PHR_Models.Status>();
                cfg.CreateMap<PM_Models.Street, PHR_Models.Street>();
                cfg.CreateMap<PM_Models.Structure, PHR_Models.Structure>();
                cfg.CreateMap<PM_Models.Task, PHR_Models.Task>();
                cfg.CreateMap<PM_Models.Ward, PHR_Models.Ward>();
            });
            IMapper mapper = config.CreateMapper();


            List<PM_Models.Advertise> PM_advertise = null;
            List<PM_Models.Type> PM_type = null;
            List<PM_Models.Direction> PM_direction = null;
            List<PM_Models.District> PM_district = null;           
            List<PM_Models.Status> PM_status = null;
            List<PM_Models.Street> PM_street = null;
            List<PM_Models.Structure> PM_structure = null;
            List<PM_Models.Task> PM_task = null;
            List<PM_Models.Ward> PM_ward = null;
            using (var context = new PMContext())
            {
                PM_advertise = context.Advertises.ToList();
                PM_type = context.Types.ToList();
                PM_direction = context.Directions.ToList();
                PM_district = context.Districts.ToList();            
                PM_status = context.Statuses.ToList();
                PM_street = context.Streets.ToList();
                PM_structure = context.Structures.ToList();
                PM_task = context.Tasks.ToList();
                PM_ward = context.Wards.ToList();
            }

            using (var context = new PHRContext())
            {
                var PHR_advertise = mapper.Map<List<PHR_Models.Advertise>>(PM_advertise);
                if (context.Advertises.Count() == 0)
                    using (var dbContextTransaction = context.Database.BeginTransaction())
                    {
                        context.Advertises.AddRange(PHR_advertise);
                        context.SaveChanges();
                        dbContextTransaction.Commit();
                    }

                var PHR_category = mapper.Map<List<PHR_Models.Category>>(PM_type);
                if (context.Categories.Count() == 0)
                    using (var dbContextTransaction = context.Database.BeginTransaction())
                    {
                        context.Categories.AddRange(PHR_category);
                        context.SaveChanges();
                        dbContextTransaction.Commit();
                    }

                var PHR_direction = mapper.Map<List<PHR_Models.Direction>>(PM_direction);
                if (context.Directions.Count() == 0)
                    using (var dbContextTransaction = context.Database.BeginTransaction())
                    {
                        context.Directions.AddRange(PHR_direction);
                        context.SaveChanges();
                        dbContextTransaction.Commit();
                    }

                var PHR_district = mapper.Map<List<PHR_Models.District>>(PM_district);
                if (context.Districts.Count() == 0)
                    using (var dbContextTransaction = context.Database.BeginTransaction())
                    {
                        context.Districts.AddRange(PHR_district);
                        context.SaveChanges();
                        dbContextTransaction.Commit();
                    }

                var PHR_status = mapper.Map<List<PHR_Models.Status>>(PM_status);
                if (context.Statuses.Count() == 0)
                    using (var dbContextTransaction = context.Database.BeginTransaction())
                    {
                        context.Statuses.AddRange(PHR_status);
                        context.SaveChanges();
                        dbContextTransaction.Commit();
                    }

                var PHR_street = mapper.Map<List<PHR_Models.Street>>(PM_street);
                if (context.Streets.Count() == 0)
                    using (var dbContextTransaction = context.Database.BeginTransaction())
                    {
                        context.Streets.AddRange(PHR_street);
                        context.SaveChanges();
                        dbContextTransaction.Commit();
                    }

                var PHR_structure = mapper.Map<List<PHR_Models.Structure>>(PM_structure);
                if (context.Structures.Count() == 0)
                    using (var dbContextTransaction = context.Database.BeginTransaction())
                    {
                        context.Structures.AddRange(PHR_structure);
                        context.SaveChanges();
                        dbContextTransaction.Commit();
                    }

                var PHR_task = mapper.Map<List<PHR_Models.Task>>(PM_task);
                if (context.Tasks.Count() == 0)
                    using (var dbContextTransaction = context.Database.BeginTransaction())
                    {
                        context.Tasks.AddRange(PHR_task);
                        context.SaveChanges();
                        dbContextTransaction.Commit();
                    }

                var PHR_ward = mapper.Map<List<PHR_Models.Ward>>(PM_ward);
                if (context.Wards.Count() == 0)
                    using (var dbContextTransaction = context.Database.BeginTransaction())
                    {
                        context.Wards.AddRange(PHR_ward);
                        context.SaveChanges();
                        dbContextTransaction.Commit();
                    }
            }

            using (var context = new PMContext())
            {
                List<PM_Models.Product> PM_product = context.Products.ToList();

                var PHR_product = mapper.Map<List<PHR_Models.Product>>(PM_product);

            }
        }



    }
}
