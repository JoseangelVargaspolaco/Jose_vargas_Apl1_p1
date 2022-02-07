using System;
using Jose_vargas_Apl1_p1.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Jose_vargas_Apl1_p1.DAL;

namespace Jose_vargas_Apl1_p1.BLL
{
    public class ProductosBLL
    {
        public static bool Existe(int productoid)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                paso = contexto.productos.Any(l => l.Productoid == productoid);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            
            return paso;
        }

        public static bool Insertar(Productos productos)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.productos.Add(productos);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            
            return paso;
        }

        public static bool Editar(Productos productos)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Entry(productos).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            
            return paso;
        }
        public static bool Guardar(Productos productos)
        {
            if(!Existe(productos.Productoid))
                return Insertar(productos);
            else
                return Editar(productos);
        }

        
        public static bool Eliminar(int productosid)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                var productoid = contexto.productos.Find(productosid);
                if(productoid != null)
                {
                    contexto.productos.Remove(productoid);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            
            return paso;
        }
    }
}
