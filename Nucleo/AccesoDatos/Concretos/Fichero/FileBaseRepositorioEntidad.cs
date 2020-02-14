using Nucleo.AccesoDatos.Abstractas;
using Nucleo.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Linq.Dynamic;

namespace Nucleo.AccesoDatos.Concretos.Fichero
{
    public abstract class FileBaseRepositorioEntidad<TEntidad, TContexto> : IRepositorioEntidad<TEntidad>
         where TEntidad : class, IEntidad, new()
         where TContexto : class, IContexto, new()
    {
        //columnas de la entidad
        private string columnas;
        //nombre del fichero
        private string nombre_fichero;
        //vector de nombres de las columnas de la entidad
        private string[] vector_columnas;
        //separador para guardar en el fichero
        char separador;
        //coleccion de datos de la aplicacion. 
        //Nota: No debería realizarse de esta forma, pero se realiza por simplicidad
        private List<TEntidad> datos;
        //cadena que nos muestra el origen de datos. La ruta donde se guarda los datos
        private TContexto contexto;
        //información sobres los tipos de datos. 
        //al ser una entidad genérica no conocemos las propiedades. Estas se pasan en la variable columnas.
        //para poder acceder de forma dinámica debemos utilizar este tipo.
        //para mas información visitar https://johnlnelson.com/tag/propertyinfo-setvalue/
        Type entidadType;
        
        public FileBaseRepositorioEntidad(string nombre_fichero, char separador, string columnas)
        {
            
            //Nombre del fichero
            this.nombre_fichero = nombre_fichero;
            //separador de datos
            this.separador = separador;
            //columnas de los datos (coinciden con los nombres de propiedades)
            this.columnas = columnas;
            vector_columnas = columnas.Split(separador);
            //ruta del fichero
            contexto = new TContexto();
            //tipos de la entidad
            entidadType = new TEntidad().GetType();
            //cargamos los datos.
            LeerFichero();
        }
        //Mirar la posibilidad de implementar la interfaz IDisposed
        ~FileBaseRepositorioEntidad()  // finalizer
        {
            //guardamos los datos en el fichero
            EscribirFichero();

        }
        //lectura de los datos
        private void LeerFichero()
        {
            //creamos la lista que contrendrá los datos
            datos = new List<TEntidad>();
            
            //comprobamos que existe la ruta y sino la creamos
            if (!Directory.Exists(Path.GetFullPath(contexto.CadenaConexion)))
                Directory.CreateDirectory(Path.GetFullPath(contexto.CadenaConexion));
            if (!System.IO.File.Exists(Path.Combine(contexto.CadenaConexion, nombre_fichero)))
                File.Create(Path.Combine(contexto.CadenaConexion, nombre_fichero)).Close();
            try
            {
                //creamos el reader para leer los datos, nos ayudamos de la clase Path para generar la ruta.
                //para mas información visitar la página https://www.dotnetperls.com/path
                StreamReader file = new StreamReader(Path.Combine(contexto.CadenaConexion, nombre_fichero));
                //variable usada para leer las lineas del fichero
                string line;
                //leemos hasta fin de fichero
                while ((line = file.ReadLine()) != null)
                {
                    //nos creamos una nueva entidad
                    TEntidad nuevo = new TEntidad();
                    //troceamos los datos de la línea leida del fichero. Deben estar en el mismo orden que el proporcionado por la variable columnas.
                    string[] valores = line.Split(separador);
                    //para cada campo de datos contenido
                    for (int i = 0; i < vector_columnas.Length; i++)
                    {
                        //obtenemos la propiedad de la entidad genérica. ¡¡Cuidado!!. Debe coincidir con los nombres proporcionados por columnas.
                        PropertyInfo property = entidadType.GetProperty(vector_columnas[i]);

                        //establecemos su valor. Para ello, debemos convertir el tipo de datos al valor adecuado. 
                        //Nosotros lo tenemos leido como String y deberemos cambiarlo como int, long, float, etc.
                        //para realizar esto, nos apollamos en la función Convertir datos, de la clase FileConnectionExtensions.
                        //debereís incomporar los tipos usados como tipos .NET
                        //Para conocer los tipos integrados vivitar https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/keywords/built-in-types-table

                        property.SetValue(nuevo, FileConnectionExtensions.ConvertirDato(property, valores[i]), null);

                    }
                    //una vez establecido todos los campos, añadimos la entidad a la colección.
                    datos.Add(nuevo);
                }
                //cerramos el fichero
                file.Close();
            }
            catch (FileNotFoundException e)
            {
                //aquí, debereis crear una excepción personalizada para dar un mensaje personalido. Acordaros de la Usabilidad.
                throw new Exception(e.FileName);
            }
             
            
        }
        private void EscribirFichero()
        {
            //TODO: debemos contemplar posibles fallos y enviar un mensaje personalizado.
            //creamos el reader
            StreamWriter file = new StreamWriter(Path.Combine(contexto.CadenaConexion, nombre_fichero));
            //variable para generar la cadena que se escribira en el fichero
            string line;
            //para todas las entidades
            foreach (TEntidad nuevo in datos)
            {
                //guardamos en pirmer lugar el campo Id. Todas las entidades deben tenerlo.
                line = entidadType.GetProperty(vector_columnas[0]).GetValue(nuevo).ToString();
                //para el resto de campos.
                for (int i = 1; i < vector_columnas.Length; i++)
                {
                    //incorporamos el separador y el valor del campo
                    line += separador.ToString() + entidadType.GetProperty(vector_columnas[i]).GetValue(nuevo).ToString();
                }
                //escribimos la línea de datos en el fichero
                file.WriteLine(line);
            }
            //cerramos el fichero
            file.Close();
        }

        public TEntidad Add(TEntidad entity)
        {
            //gardamos la entidad a la coleccion de datos.
            datos.Add(entity);
            return entity;
        }

        
        public TEntidad Update(TEntidad entity)
        {
            //buscamos la entidad en la coleccion de datos. Para ello podemos emplear un foreach,
            //pero en este caso, por comodidad, se ha decidido realizarlo con LINQ.
            //Para mas información sobre LINQ (Language Integrated Query) 
            //puede visitar la siguiente página https://www.tutorialsteacher.com/linq/what-is-linq
            TEntidad old = datos.FirstOrDefault(x => x.Id == entity.Id);
            
            //preguntamos si tenemos la entidad en la coleccion
            if (old != null)
            {
                //si existe borramos la anterior y añadimos la nueva
                //¿Es correcto realizarlo así? ¿Que problemas puede dar?
                datos.Remove(old);
                datos.Add(entity);
            }
            else
            {
                //si no existe lanzamos una excepción. 
                //deberiamos crear una excepción propia para indicar que no se puede actualizar un objeto que no existente. Acordaros de la Usabilidad.
                throw new Exception();
            }
            return entity;
        }
        //TODO: ¿deberiamos crear un delete con condición?. public int Delete(string) / public int Delete(System.Linq.Expressions.Expression<Func<TEntidad, bool>> filter )
        public int Delete(TEntidad entity)
        {
            int num=0;
            //buscamos la entidad en la coleccion de datos. Para ello podemos emplear un foreach,
            //pero en este caso, por comodidad, se ha decidido realizarlo con LINQ.
            //Para mas información sobre LINQ (Language Integrated Query) 
            //puede visitar la siguiente página https://www.tutorialsteacher.com/linq/what-is-linq
            TEntidad old = datos.FirstOrDefault(x => x.Id == entity.Id);

            //si la entidad existe la eliminamos
            if (old != null)
            {
                datos.Remove(old);
                num= 1;
            }
            return num;
             
           
        }

        public List<TEntidad> GetAll(string filter)
        {
            //Para poder buscar a través de una condición WHERE tipo SQL, ej Id=5, no existe implementación en LINQ.
            //Realizar un analisis y procesado del filtro sería un trabajo arduo, por ello, se ha decidido utilizar 
            //una extensión denominada Dynamic LINQ descargado de esta página https://docs.microsoft.com/en-us/previous-versions/bb894665(v=msdn.10)?redirectedfrom=MSDN
            //esiste también un paquete nuget, pero se ha decido incluir el fichero dierectamente en la Carpeta DynamicLinq
            //Para mas información sobre LINQ (Language Integrated Query) 
            //puede visitar la siguiente página https://www.tutorialsteacher.com/linq/what-is-linq
            //Para obtener mas información sobre Dynamic Linq, puede ir a la siguiente página  https://weblogs.asp.net/scottgu/dynamic-linq-part-1-using-the-linq-dynamic-query-library
            //el problema es que solo esta implementado para tipos IQueryable, pero podemos transformar la entidad de forma sencilla.
           
            return datos.AsQueryable().Where(filter).ToList();
        }

        public TEntidad GetById(int entityId)
        {
            //Para mas información sobre LINQ (Language Integrated Query) 
            //puede visitar la siguiente página https://www.tutorialsteacher.com/linq/what-is-linq
            return datos.FirstOrDefault(x => x.Id == entityId);
             
        }

        public TEntidad Get(string filter)
        {
            //Para poder buscar a través de una condición WHERE tipo SQL, ej Id=5, no existe implementación en LINQ.
            //Realizar un analisis y procesado del filtro sería un trabajo arduo, por ello, se ha decidido utilizar 
            //una extensión denominada Dynamic LINQ descargado de esta página https://docs.microsoft.com/en-us/previous-versions/bb894665(v=msdn.10)?redirectedfrom=MSDN
            //esiste también un paquete nuget, pero se ha decido incluir el fichero dierectamente en la Carpeta DynamicLinq
            //Para mas información sobre LINQ (Language Integrated Query) 
            //puede visitar la siguiente página https://www.tutorialsteacher.com/linq/what-is-linq
            //Para obtener mas información sobre Dynamic Linq, puede ir a la siguiente página  https://weblogs.asp.net/scottgu/dynamic-linq-part-1-using-the-linq-dynamic-query-library
            //el problema es que solo esta implementado para tipos IQueryable, pero podemos transformar la entidad de forma sencilla.
            return datos.AsQueryable().Where(filter).FirstOrDefault();
        }

        public int Count()
        {
            return datos.Count;
        }

        //para poder utilizar la expresion de filtrado como una expresión lambda para Linq debemos llamar al método compile
        //como se describe en la siguiente documentación https://docs.microsoft.com/es-es/dotnet/api/system.linq.expressions.lambdaexpression.compile?view=netframework-4.8

        public List<TEntidad> GetAll(System.Linq.Expressions.Expression<Func<TEntidad, bool>> filter = null)
        {
            if (filter != null)
            {
                return datos.Where(filter.Compile()).ToList();
            }
            else
            {
                return datos.ToList();
            }
           
        }

        public TEntidad Get(System.Linq.Expressions.Expression<Func<TEntidad, bool>> filter)
        {
            if (filter != null)
            {
                return datos.Where(filter.Compile()).FirstOrDefault();
            }
            else
            {
                return datos.FirstOrDefault();
            }
        }


        public void SaveData()
        {
            EscribirFichero();
        }

        public List<TEntidad> GetPaginate(string filter, int OFFSET, int FETCH)
        {
            throw new NotImplementedException();
        }

        public List<TEntidad> GetPaginate(string filter, int OFFSET, int FETCH, string order)
        {
            throw new NotImplementedException();
        }

        public List<TEntidad> GetPaginate(int OFFSET, int FETCH, string order)
        {
            throw new NotImplementedException();
        }

        public List<TEntidad> GetPaginate(int OFFSET, int FETCH)
        {
            throw new NotImplementedException();
        }

        public List<TEntidad> GetAll(string filter, string order)
        {
            throw new NotImplementedException();
        }

        public List<TEntidad> GetAllOrderBy(string order)
        {
            throw new NotImplementedException();
        }
    }
}