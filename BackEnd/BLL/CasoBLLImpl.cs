﻿using BackEnd.DAL;
using BackEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.BLL
{
    public class CasoBLLImpl : BLLGenericoImpl<Caso>, ICasoBLL
    {
        private UnidadDeTrabajo<Caso> unidad;

        public bool Agregar(Caso caso)
        {
            this.Add(caso);
            return true;
        }

        public bool Modificar(Caso caso)
        {
            this.Update(caso);
            return true;
        }
        public bool SaveChanges()
        {
            using (unidad = new UnidadDeTrabajo<Caso>(new SCJ_BDEntities()))
            {
                this.unidad.Complete();
                return true;
            }
        }

        public bool Comprobar(int validar)
        {
            try
            {
                List<Caso> lista;
                using (unidad = new UnidadDeTrabajo<Caso>(new SCJ_BDEntities()))
                {
                    Expression<Func<Caso, bool>> consulta = (d => d.numeroCaso.Equals(validar));
                    lista = unidad.genericDAL.Find(consulta).ToList();
                    if (lista.Count() == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}

