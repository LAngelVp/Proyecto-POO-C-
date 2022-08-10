using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Client{
    class Consecionario{
        private Coche[] _coche;
        private int _limite;
        private int _numCoches;
        public Consecionario(int limite){
            this._coche=new Coche[limite];
            _limite=limite;
            _numCoches=0;
        }
        public void ingresarCoche(Coche c){
            if (c != null && _numCoches<_coche.Length){
                _coche[_numCoches] = c;
                _numCoches++;
            }
        }
        public void mostrarCoches(){
            for (int i=0;i<_numCoches;i++){
                Console.WriteLine(_coche[i].ToString());
            }
        }
        public void vaciarLista(){
            this._coche = new Coche[_limite];
            _numCoches = 0;
        }
        public void eliCoche(Coche c){
            if (c !=null && _numCoches !=0){
                int posicion = 1;
                for (int i=0; i<_numCoches;i++){
                    if (c.Id == _coche[i].Id){
                        posicion=i;
                    }
                }
                if (posicion == -1){
                    Console.WriteLine("No se encuentran autos en la base.");
                }
                else{
                    _coche[posicion] = null;
                    for (int i=0;i<_numCoches;i++){
                        _coche[i] = _coche[i+1];
                    }
                    _numCoches--;
                }
            }
        }
    }
}