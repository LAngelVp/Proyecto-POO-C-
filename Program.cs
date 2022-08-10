using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            Consecionario consencionario = new Consecionario(10);
            Coche c1 = new Coche(1,"Nissan","Versa","Rojo", 5,200000,15000);
            Coche c2 = new Coche(2,"Nissan","X-Trail","Verde", 5,190000,10000);
            Coche c3 = new Coche(3,"Nissan","Altima","Azul", 5,250000,9000);
            Coche c4 = new Coche(4,"Nissan","March","Negro", 5,180000,8000);
            Coche c5 = new Coche(5,"Nissan","Kicks","Amarillo", 5,160000,7000);
            Coche c6 = new Coche(6,"Nissan","Leaf","Blanco", 5,150000,12000);
            Coche c7 = new Coche(7,"Nissan","Sentra","Plata", 5,210000,17000);
            Coche c8 = new Coche(8,"Nissan","Pathfinder","Arena", 5,220000,19000);
            consencionario.ingresarCoche(c1);
            consencionario.ingresarCoche(c2);
            consencionario.ingresarCoche(c3);
            consencionario.ingresarCoche(c4);
            consencionario.ingresarCoche(c5);
            consencionario.ingresarCoche(c6);
            consencionario.ingresarCoche(c7);
            consencionario.ingresarCoche(c8);
            int opcion;
            do{
                Console.WriteLine("Menu de opciones\n"+
                "Puedes seleccionar alguna de las siguientes opciones"+
                "[1] Mostrar todos los autos.\n"+
                "[2] Ingresar algún auto.\n"+
                "[3] ELiminar Algun auto.\n"+
                "[4] Vaciar toda la lista.\n"+
                "[5] Salir.");
                Console.WriteLine("Ingresa la opcion: ");
                opcion = int.Parse(Console.ReadLine());
        
                    if(opcion == 1){
                        Console.WriteLine("Lista de todos los Autos.");
                        consencionario.mostrarCoches();
                    }
                    if (opcion == 2){
                        Console.WriteLine("Ingresa los siguientes datos.");
                        Console.WriteLine("Id: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Marca: ");
                        string mar = Console.ReadLine();
                        Console.WriteLine("Modelo: ");
                        string mod = Console.ReadLine();
                        Console.WriteLine("Color: ");
                        string col = Console.ReadLine();
                        Console.WriteLine("Puertas: ");
                        int pue = int.Parse(Console.ReadLine());
                        Console.WriteLine("Precio: ");
                        double pre = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Kilometraje: ");
                        int ki = int.Parse(Console.ReadLine());
                        Coche nuevoC = new Coche(id,mar,mod,col,pue,pre,ki);
                        consencionario.ingresarCoche(nuevoC);
                    }
                    if(opcion == 3){
                        Console.WriteLine("Debes de ingresar el ID del auto a ELIMINAR.");
                        Console.WriteLine("Ingresa el ID del auto: ");
                        int id = int.Parse(Console.ReadLine());
                        Coche elimCoche=new Coche(id, "", "","",0, 0, 0);
                        consencionario.eliCoche(elimCoche);
                    }
                    if(opcion == 4){
                        consencionario.vaciarLista();
                    }
            }while(opcion!=5);
        Console.ReadKey();
        }
    }
}