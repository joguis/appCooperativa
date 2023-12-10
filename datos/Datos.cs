using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace appCooperativa.datos
{
    class Datos
    {
        /*paso 1:crear la cadena de conexion*/
        string cadenaConexion =@"Data Source=localhost;User ID = cooperativa; Password=oracle";

        public int ejecutarDML(string consulta)
        {
            int filasAfectadas = 0;
            OracleConnection miConexion = new OracleConnection(cadenaConexion);

            /*2. creo un objeto de tipo comando el cual 
             establece la instruccion sql que se ejecutara en la BD*/
            OracleCommand miComando = new OracleCommand(consulta, miConexion);
            miConexion.Open();

            /*4.ejecuto el comando. devuelve un valor entero que simboliza
             las filas afectadas en la operacion DML*/
            filasAfectadas = miComando.ExecuteNonQuery();
            miConexion.Close();

            return filasAfectadas;

        }
        //metodo para ejecutar sentencias select
        public DataSet ejecutarSELECT(string consulta)
        {
            //1.Creo un obj vacio de tipo dataSet
            DataSet ds = new DataSet();
            //2.creo un adaptador( recupera los datos de la tabla)
            OracleDataAdapter miAdaptador = new OracleDataAdapter(consulta, cadenaConexion);
            //3. llena el data set
            miAdaptador.Fill(ds, "Resultado"); //llene el dataSet y a la consulta dele el nombre de ResultadoDatos
            return ds;


        }
    }
}
