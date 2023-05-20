using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroes.clases
{
    internal class SuperHeroesDB
    {
        public readonly string cadenaConexion = "Data Source=c:\\tmp\\SuperHeroesDb.db";
        private readonly SQLiteConnection conexion;

        public SuperHeroesDB()
        {
            conexion = new SQLiteConnection(cadenaConexion);
        }

        public void CrearTablaHeroe()
        {
            String mensaje = "";

            try
            {
                conexion.Open();
                string sql = @"CREATE TABLE IF NOT EXISTS SuperHeroe (id INTEGER PRIMARY KEY AUTOINCREMENT, nombre VARCHAR(20), 
            fuerza INTEGER, agilidad INTEGER)";
                SQLiteCommand command = new SQLiteCommand(sql, conexion);
                command.ExecuteNonQuery();
                Console.WriteLine("Tabla de SuperHeroe creada correctamente");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errpr al crear la tabla SuperHeroe: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void insertarHeroe(ISuperHeroes heroe)
        {
            try
            {
                conexion.Open();
                string sql = "INSERT INTO SuperHeroe (nombre, fuerza, agilidad) VALUES ('" + heroe.Nombre + "', " + heroe.Fuerza + ", " + heroe.agilidad + ")";
                SQLiteCommand command = new SQLiteCommand(sql, conexion);
                command.ExecuteNonQuery();
                Console.WriteLine("SuperHeroe insertado correctamente");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el SuperHeroe: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
    }

}
