using System;
namespace PruebaNet2
{
    enum TipoMotor
    {
        DOS_TIEMPOS, CUATRO_TIEMPOS
    }

    class Motor : VehiculoComponentes
    {
        private readonly string _id;
        private int _cilindrada;
        private TipoMotor _tipoMotor;

        public Motor(string id,TipoMotor tipoMotor, int cilindrada) : base()
        {
            _id = id;
            _tipoMotor = tipoMotor;
            _cilindrada = cilindrada;
        }

        public string Id => _id;

        public int Cilindrada { get => _cilindrada; set => _cilindrada = value; }
        internal TipoMotor TipoMotor { get => _tipoMotor; set => _tipoMotor = value; }
    }
}
