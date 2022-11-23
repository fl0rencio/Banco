using System.Globalization;

namespace Banco
{
    public class Cliente
    {

        public int Conta { get; private set; }

        public double Saldo { get; private set; }

        public string Titular { get; set; }

        public Cliente(int conta, string titular)
        {
            Conta = conta;
            Titular = titular;
        }

        

        public Cliente(double saldoInicial, int conta, string titular) : this(conta, titular)
        {
            Depositar (saldoInicial);
        }


        public void Depositar(double quantia)
        {
            Saldo += quantia;
        }

        public void Sacar(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return

                "CONTA: " + Conta +
               " , " + " TITULAR: " + Titular +
               " , " + "SALDO: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
