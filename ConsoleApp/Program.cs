// See https://aka.ms/new-console-template for more information
//Luis Guillermo Lacera Mejia
//https://github.com/PC-tech1912/Luis_Lacera_Vehiculos.git

Vehiculos vehiculo = new Vehiculos();
vehiculo.color = "rojo";
vehiculo.placa = "1234";
vehiculo.color = "azul";
vehiculo.modelo = "Audi";
vehiculo.estado = true;
vehiculo.fechaLan = new DateTime(2023, 1, 1);
vehiculo.Precio = 1000000;
Concesionarios concesio = new Concesionarios();
concesio.vendedor.Add(new Vendedores() { id_vendedor = 1, nombre = "Juan", Dinero_ve = 3000.89m });
public class Vehiculos
{
    public int id_vehiculo;
    public string? placa;
    public string? color;
    public string? modelo;
    public bool estado;
    public DateTime fechaLan;
    public decimal Precio;
    public Vendedores? vendedor;
    public Concesionarios? conce;
    public TecnicoMe? tecni;


}

public class TecnicoMe
{
    public int id_tecni;
    public bool estado;
    public DateTime fecha_ini;
}

public class Concesionarios
{
    public int id_Conce;
    public string? lugar;
    public int Cntidad_Car;
    public decimal ventas_Me;
    public List<Vendedores>? vendedor;
}

public class Vendedores
{
    public int id_vendedor;
    public decimal Dinero_ve;
    public string? nombre;
    
}