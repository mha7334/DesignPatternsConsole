using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Channels;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;

namespace DesignPatternsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) click 'Show All Files in VisualStudio'
            //2) Then include Pattern/Principle's Folder (One at a time) in the project e.g.
            //AbstractFactory
            //Factory
            //FactoryMethod
            //Builder
            //Decorator
            //ChainOfResp
            //DI
            //FluentInterface
            //Prototype
            //Singleton
            //SingletonThreadSafe
            //Strategy
            //IoC
            //Facade
            //Adapter
            //Tester.Run();

            var dt = DateTime.Now;

            Console.WriteLine("Started at : " + dt );


            //var vscTurbineDistributionOfAmbientI15List = JsonConvert.DeserializeObject<List<VscTurbineDistributionOfAmbientI15>>(File.ReadAllText(@"c:\temp\vsu\VscTurbineDistributionOfAmbientI15List.json"));
            //var vscTurbineAmbientTurbulenceLargeParkList = JsonConvert.DeserializeObject<List<VscTurbineAmbientTurbulenceLargePark>>(File.ReadAllText(@"c:\temp\vsu\VscTurbineAmbientTurbulenceLargeParkList.json"));
            var vscTurbineAmbientTurbulenceList = JsonConvert.DeserializeObject<List<VscTurbineAmbientTurbulence>>(File.ReadAllText(@"c:\temp\vsu\VscTurbineAmbientTurbulenceList.json"));
            //var vscTurbineLoadList = JsonConvert.DeserializeObject<List<VscTurbineLoad>>(File.ReadAllText(@"c:\temp\vsu\VscTurbineLoadList.json"));
            ;




            SqlConnection cnn;
            //var connetionString =
            //    @"Database=VSU;Data Source=vsu-db,1433;User Id=VSUAdmin;Password=Bl98hsz9bxxx; Connect Timeout=900;Max Pool Size=500";

            var connetionString =
                @"Server=tcp:sqlserver-d-vps-plantdesign.database.windows.net,1433;Initial Catalog=VSC;Persist Security Info=False;User ID=vsclogin;Password=pa$$word321xxxx;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            cnn = new SqlConnection(connetionString);
            cnn.Open();

            string VscTurbineAmbientTurbulenceInsert = "INSERT INTO dbo.VscTurbineAmbientTurbulence(VscTurbineId, VscProjectId, DirectionalTurbulenceAverage, DirectionalTurbulenceStdDev, DirectionNumber, WindSpeed) VALUES(@VscTurbineId, @VscProjectId, @DirectionalTurbulenceAverage, @DirectionalTurbulenceStdDev, @DirectionNumber, @WindSpeed)";

            //string smt = "INSERT INTO dbo.Test(id, json1, json2, json) VALUES(@ID, @json1)";


            var vscProjectId = Guid.Parse("FD6FE796-AC76-453A-A6D8-00000BCA1F96");
            var vscTurbineId = Guid.Parse("37AC4430-4574-476E-BE3F-F11ACC9DF623");

            float count = 0;

            int percent = 0;
            foreach (var vscTurbineAmbientTurbulence in vscTurbineAmbientTurbulenceList)
            {
                count++;
                SqlCommand cmd = new SqlCommand(VscTurbineAmbientTurbulenceInsert, cnn);
                cmd.Parameters.Add("@VscTurbineId", SqlDbType.UniqueIdentifier);
                cmd.Parameters.Add("@VscProjectId", SqlDbType.UniqueIdentifier);
                cmd.Parameters.Add("@DirectionalTurbulenceAverage", SqlDbType.Float);
                cmd.Parameters.Add("@DirectionalTurbulenceStdDev", SqlDbType.Float);
                cmd.Parameters.Add("@WindSpeed", SqlDbType.Float);
                cmd.Parameters.Add("@DirectionNumber", SqlDbType.Int);

                cmd.Parameters["@VscTurbineId"].Value = vscTurbineId;
                cmd.Parameters["@VscProjectId"].Value = vscProjectId;
                cmd.Parameters["@DirectionalTurbulenceAverage"].Value = vscTurbineAmbientTurbulence.DirectionalTurbulenceAverage;
                cmd.Parameters["@DirectionalTurbulenceStdDev"].Value = vscTurbineAmbientTurbulence.DirectionalTurbulenceStdDev;
                cmd.Parameters["@WindSpeed"].Value = vscTurbineAmbientTurbulence.WindSpeed;
                cmd.Parameters["@DirectionNumber"].Value = vscTurbineAmbientTurbulence.DirectionNumber;
                cmd.ExecuteNonQuery();

                int percentage = (int)((count / vscTurbineAmbientTurbulenceList.Count) * 100);
                if (count % 100 == 0  && !percent.Equals(percentage) )
                {
                    percent = percentage;
                    Console.Write("\r{0}% completed", percentage);

                }
                
            }
            Console.WriteLine();
            dt = DateTime.Now;
            Console.WriteLine("Insert Completed at : " + dt);


          
           
            cnn.Close();

           

        }
        private static void ReadSingleRow(IDataRecord record)
        {
            Console.WriteLine(String.Format("{0}, {1}", record[0], record[1]));
        }
    }
}

