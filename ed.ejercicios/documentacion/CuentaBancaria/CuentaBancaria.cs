using System;


namespace MTBCuentaBancaria
{
    /// <summary>
    /// <para>Clase que representa una cuenta corriente.</para>
    /// </summary>
    public class CuentaBancaria
    {
        /// <summary>
        /// Saldo disponible actualmente en euros
        /// </summary>
        private double saldoMTB;

        /// <summary>
        /// Error que se produce cuando la cantidad indicada no es válida.
        /// </summary>
        public const String ERR_CANTIDAD_NO_VALIDA = "La cantidad indicada no es válida.";
        /// <summary>
        /// Error que se produce cuando el saldo de la cuenta es insuficiente.
        /// </summary>
        public const String ERR_SALDO_INSUFICIENTE = "Saldo insuficiente.";

        /// <summary>
        /// Constructor vacío de la clase.
        /// <remarks>Inicializa el saldo a 0</remarks>
        /// </summary>
        CuentaBancaria()
        {
            this.saldoMTB = 0;
        }

        /// <summary>
        /// Constructor con parámetro de entrada para incicializar el saldo con el valor deseado.
        /// </summary>
        /// <param name="saldo">Saldo con el que inicializar la cuenta</param>
        CuentaBancaria(double saldo)
        {

            Ingresar(saldo);
        }

        /// <summary>
        /// Obtiene y devuelve el saldo actual de la cuenta en euros.
        /// </summary>
        /// <value>Saldo de la cuenta (€)</value>
        public double Saldo
        {
            get
            {
                return saldoMTB;
            }
            set
            {
                saldoMTB = value;
            }
        }

        /// <summary>
        /// <para>Ingresar en cuenta la cantidad indicada por el parámetro.</para>
        /// <para>Genera error si la cantidad a ingresar no es válida (menor o igual que cero).</para>
        /// </summary>
        /// <param name="cantidad">Cantidad a ingresar en euros (€)</param>
        /// <exception cref="ArgumentOutOfRangeException">Cantidad no  válida (menor o igual que cero)</exception>
        public void Ingresar(double cantidad)
        {
            if (cantidad <= 0)
                throw new ArgumentOutOfRangeException(ERR_CANTIDAD_NO_VALIDA);
            Saldo += cantidad;
        }

        /// <summary>
        /// <para>Retirar de la cuenta la cantidad indicada por el parámetro.</para>
        /// <para>Puede generar dos errores:</para>
        /// <list type="bullet">
        ///     <item>
        ///         <description>Error por cantidad no válida (menor o igual que cero)</description>
        ///     </item>
        ///     <item>
        ///         <description>Error por saldo insuficiente</description>
        ///     </item>
        /// </list>
        /// </summary>
        /// <param name="cantidad">Cantidad a ingresar en euros (€)</param>
        /// <exception cref="ArgumentOutOfRangeException">Cantidad no  válida (menor o igual que cero) o superior al saldo</exception>
        public void Retirar(double cantidad)
        {
            if (cantidad <= 0)
                throw new ArgumentOutOfRangeException(ERR_CANTIDAD_NO_VALIDA);
            if (cantidad > Saldo)
                throw new ArgumentOutOfRangeException(ERR_SALDO_INSUFICIENTE);
            Saldo -= cantidad;
        }
    }
}


