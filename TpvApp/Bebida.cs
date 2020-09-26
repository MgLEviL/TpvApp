using System;

public class Bebida : Producto
{
    public Bebida(String nombre, float precio, int stock, String alergenos, int cantidad = 0) : base(nombre, precio, stock, alergenos, cantidad) { }

}
