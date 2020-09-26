using System;

public class Hamburgesa : Producto
{
	public Hamburgesa(String nombre, float precio, int stock, String alergenos, int cantidad = 0) : base( nombre,  precio,  stock,  alergenos, cantidad) {}
}
