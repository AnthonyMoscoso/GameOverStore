using AccesoDatos.Abstractas.Compuestas;
using Dapper;
using Entitidades.Concretas;
using Entitidades.Simples;
using Nucleo.AccesoDatos.Concretos.Dapper;
using Nucleo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AccesoDatos.Concretas.Dapper.Compuestas
{
    public class DapProductosDal : DapBaseRepositorioEntitidad<Productos, DapperContexto>, IProductosDal
    {
        
        public DapProductosDal() : base(
            tableName: "Productos",
            colums: "Nombre,Descripcion,Introduccion,Clasificacion_id,Fecha,Desarrolladora_Id,Precio_Compra,Precio_Venta,Imagen_Vertical,Imagen_Horizontal,Imagen_Logo,Descuento,Url,Multijugador",
            parameters: "@Nombre,@Descripcion,@Introduccion,@Clasificacion_id,@Fecha,@Desarrolladora_Id,@Precio_Compra,@Precio_Venta,@Imagen_Vertical,@Imagen_Horizontal,@Imagen_Logo,@Descuento,@Url,@Multijugador")
        {

        }
        public new Productos Add(Productos entity)
        {
            Productos addedEntity;
            List<Idiomas> idiomas = entity.Idiomas;
            List<Plataformas> plataformas = entity.Plataformas;
            List<Generos> generos = entity.Generos;
            using (var transaction = new TransactionScope())
            {
                
                addedEntity = base.Add(entity);
             
                string sql = "INSERT INTO ProductoIdiomas (id_Productos,id_Idiomas) Values (@id_Productos,@id_Idiomas);";
                //debes introducir los idiomas
                foreach (Idiomas i in idiomas)
                {
                    connection.Execute(sql, new { id_Productos = addedEntity.Id, id_Idiomas = i.Id }  );
                }
                string sql2 = "INSERT INTO ProductoGeneros (id_Productos,id_Generos) Values (@id_Productos,@id_Generos);";
                //debes introducir los idiomas
                foreach (Generos i in generos)
                {
                    connection.Execute(sql2, new { Id_Productos = addedEntity.Id, Id_Generos = i.Id });
                }
                string sql3 = "INSERT INTO ProductoPlataformas (id_Producto,id_Plataformas) Values (@id_Producto,@id_Plataformas);";
                //debes introducir los idiomas
                foreach (Plataformas i in plataformas)
                {
                    connection.Execute(sql3, new { id_Producto = addedEntity.Id, id_Plataformas = i.Id });
                }

                transaction.Complete();
            }
            
            return addedEntity;
        }
    
    
    
       


    }
    }
