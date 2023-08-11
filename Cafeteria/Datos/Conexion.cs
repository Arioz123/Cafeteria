
namespace Cafeteria.Datos
{
    public class Conexion
    {
        private string cadenaSql = String.Empty;
        
            public Conexion()
            {
                var Builder = new ConfigurationBuilder().SetBasePath
                    (Directory.GetCurrentDirectory()).AddJsonFile
                    ("appsettings.json").Build();
                cadenaSql = Builder.GetSection("ConnectionStrings:cadenaSql").Value;
            }

            public string getCadenaSql()
            {
                return cadenaSql;
            }
    }
        
}

