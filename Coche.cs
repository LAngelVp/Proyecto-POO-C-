using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Client
{
    class Coche{
        private int id;
        private string marca;
        private string modelo;
        private string color;
        private int nPuertas;
        private double precio;
        private int kilometraje;

        public int NPuertas { get => nPuertas; set => nPuertas = value; }
        public string Color { get => color; set => color = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Marca { get => marca; set => marca = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Kilometraje { get => kilometraje; set => kilometraje = value; }
        public int Id { get => id; set => id = value; }

        public Coche(int _id, string _marca, string _modelo, string _color, int _nPuertas, double _precio, int _kilometraje)
        {
            this.Id = _id;
            this.Marca = _marca;
            this.Modelo = _modelo;
            this.Color = _color;
            this.NPuertas = _nPuertas;
            this.Precio = _precio;
            this.Kilometraje = _kilometraje;
        }
        public override string ToString()
        {
            return "Datos del Auto: \n"+"Id: "+Id+"\n"+"Marca: "+Marca+"\n"+"Modelo: "+Modelo+"\n"+
            "COlor: "+Color+"\n"+"Número de Puertas: "+NPuertas+"\n"+"Precio: "+Precio+"\n"+"Kilometraje: "+Kilometraje+"\n"+
            "-------------------";
        }
    }
}
