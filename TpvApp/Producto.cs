using System;

public abstract class Producto
{

    public string nombre { get; set; }
    public float precio { get; set; }
    public int stock { get; set; }
    public string alergenos { get; set; }
    public int cantidad { get; set; }


    public Producto(String nombre, float precio, int stock, String alergenos, int cantidad = 0)
	{
        this.nombre = nombre;
        this.precio = precio;
        this.stock = stock;
        this.alergenos = alergenos;
        this.cantidad = cantidad;
    }
}
