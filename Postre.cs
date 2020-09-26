using System;

public class Postre : Producto
{
    public Postre(String nombre, float precio, int stock, String alergenos, int cantidad = 0) : base(nombre, precio, stock, alergenos, cantidad) { }
}
