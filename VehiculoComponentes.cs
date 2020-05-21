using System;
namespace PruebaNet2
{
    abstract class VehiculoComponentes
    {
        private double _estado;

        protected VehiculoComponentes()
        {
            _estado = 100.0;
        }

        public double Estado { get => _estado; set => _estado = value; }
    }
}
