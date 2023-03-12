using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Practica6
{
    internal class Fecha
    {
        private int _dia;
        private int _mes;
        private int _anyo;

        private int MAX_ANYO = 2500;

        public string ANYO_ERROR = "Año no válido, fuera de rango.";
        public string MES_ERROR = "Mes no válido, fuera de rango.";
        public string DIA_ERROR = "Día no válido, fuera de rango.";

        private const int ENERO = 1,
            FEBRERO = 2,
            MARZO = 3,
            ABRIL = 4,
            MAYO = 5,
            JUNIO = 6,
            JULIO = 7,
            AGOSTO = 8,
            SEPTIEMBRE = 9,
            OCTUBRE = 10,
            NOVIEMBRE = 11,
            DICIEMBRE = 12;

        public int Anyo
        {
            get => _anyo;
            set
            {
                if (value >= 1 && value <= MAX_ANYO)
                {
                    this._anyo = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(ANYO_ERROR);
                }
            }
        }
        public int Mes
        {
            get => _mes;
            set
            {
                if (value >= 1 && value <= 12)
                {
                    this._mes = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(MES_ERROR);
                }
            }
        }
        public int Dia
        {
            get => _dia;
            set
            {
                int diasMes = maxDiasMes(this._mes);

                if (value >= 1 && value <= diasMes)
                {
                    this._dia = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(DIA_ERROR);
                }
            }
        }

        /// <summary>
        /// Constructor de Fecha con 3 parámetros
        /// Si algún parámetro no es correcto se establece a 1
        /// Por defecto su valor es 1
        /// </summary>
        /// <param name="dia">Dia</param>
        /// <param name="mes">Mes</param>
        /// <param name="anyo">Anyo (entre 1 y MAX_ANYO)</param>
        public Fecha(int dia = 1, int mes = 1, int anyo = 1)
        {
            this.Anyo = anyo;

            this.Mes = mes;

            this.Dia = dia;
        }

        public int maxDiasMes(int mes)
        {
            int diasMes = 0;

            switch (mes)
            {
                case ENERO:
                case MARZO:
                case MAYO:
                case JULIO:
                case AGOSTO:
                case OCTUBRE:
                case DICIEMBRE:
                    diasMes = 31;
                    break;
                case ABRIL:
                case JUNIO:
                case SEPTIEMBRE:
                case NOVIEMBRE:
                    diasMes = 30;
                    break;
                case FEBRERO: // verificación de año bisiesto
                    if (esBisiesto())
                        diasMes = 29;
                    else
                        diasMes = 28;
                    break;
            }

            return diasMes;
        }

        public bool esBisiesto()
        {
            bool bisiesto = false;
            if ((_anyo % 400 == 0) || ((_anyo % 4 == 0) && (_anyo % 100 != 0)))
                bisiesto = true;
            else
                bisiesto = false;
            return bisiesto;
        }

        /// <summary>
        /// Devuelve un string con la fecha en formato dia/mes/anyo
        /// </summary>
        /// <remarks> la palabra clave override indica que se sobreescribe el metodo ToString</remarks>
        /// <returns>un string con la fecha en formatodia/mes/anyo</returns>
        public override string ToString()
        {
            return _dia + "/" + _mes + "/" + _anyo;
        }
    }
}
