using System;
namespace PruebaNet2
{
    enum TipoMezclador
    {
        CARBURADOR, INYECTOR
    }

    internal class Mezclador : VehiculoComponentes
    {
       private TipoMezclador _tipoM;

        public Mezclador(TipoMezclador tipoM)
        {
            _tipoM = tipoM;
        }


        internal TipoMezclador TipoM { get => _tipoM; set => _tipoM = value; }
    }
}
