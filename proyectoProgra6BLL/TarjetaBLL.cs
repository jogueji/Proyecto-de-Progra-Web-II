﻿using proyectoProga6DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyectoProgra6Entidades;

namespace proyectoProgra6BLL
{
    public class TarjetaBLL
    {
        private TarjetaDAL tarjetaDAL;
        public TarjetaBLL()
        {
            tarjetaDAL = new TarjetaDAL();
        }

        public bool ValidarTarjeta(Tarjeta tarj)
        {
            try
            {
                long i = long.Parse(tarj.IdTarjeta);
                i =long.Parse(tarj.Codigo);
                if (tarj.IdTarjeta.Length == 16 && tarj.Codigo.Length == 3)
                {
                    if (Existe(tarj.IdTarjeta))
                    {
                        Tarjeta tarj1 = BuscarTarjeta(tarj.IdTarjeta);
                        if (tarj1.Codigo == tarj.Codigo && tarj1.MesCaduca == tarj.MesCaduca && tarj1.AnnoCaduca == tarj.AnnoCaduca)
                            return true;
                        else
                            return false;
                    }
                    else
                        return true;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
            
        }

        private Tarjeta BuscarTarjeta(string idTarjeta)
        {
            return tarjetaDAL.BuscarTarjeta(idTarjeta);
        }

        public bool Existe(string idTarjeta)
        {
            return BuscarTarjeta(idTarjeta) != null;
        }

        public void InsertarTarjeta(Tarjeta tarj)
        {
            tarjetaDAL.InsertarTarjeta(tarj);
        }
    }
}
