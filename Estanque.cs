using System;
namespace PruebaNet2
{
     class Estanque : VehiculoComponentes
    {
        private readonly int _capacidad;
        private double _litros;

        public int Capacidad => _capacidad;

        public double Litros { get => _litros; set => _litros = value; }

        public Estanque( int capacidad)
        {
            _capacidad = capacidad;

        }

        public bool MitadCombustible()
        {
            return _litros >= (_capacidad * 0.105) && _litros<=(_capacidad*0.5);
        }

        public bool BajoCombustible()
        {
            return _litros <=(_capacidad* 0.105);
        }
    }
}
