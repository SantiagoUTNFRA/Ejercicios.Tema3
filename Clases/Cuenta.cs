namespace ClassLibrary1
{
    public class Cuenta
    {
        private string titular;
        private decimal monto;

        public Cuenta(string titular, decimal monto)
        {
            this.titular = titular;
            this.monto = monto;
        }

        private string GetTitular()
        {
            return this.titular;
        }

        private decimal GetMonto()
        {
            return this.monto;
        }

        public string GetData()
        {
            return $"El titular se llama: {GetTitular()} y tiene de monto: {GetMonto()}";
        }

        public void Ingresar(decimal monto)
        {
            if (monto > 0)
            {
                this.monto += monto;
            }
            else
            {
                Console.WriteLine("Por favor ingrese un valor mayor a 0");
            }
        }

        public void Retirar(decimal monto)
        {
            if (monto > 0)
            {
                this.monto = this.monto - monto;
            }
            else
            {
                Console.WriteLine("Por favor ingrese un valor mayor a 0");
            }
        }
    }

}