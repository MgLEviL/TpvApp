using System;

public class Menu : Producto
{
    public Menu(String nombre, float precio, int stock, String alergenos, int tamano = 2) : base(nombre, precio, stock, alergenos, tamano) { }

}
