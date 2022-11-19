using System.ComponentModel.DataAnnotations;
namespace Vehiculo_20200906.Data.Models;


public class vehiculo
{
    [key]
    public int vehiculoID{get; set;}
    public string Marca{get; set;}=null!;
    public string Modelo {get; set;}=null!;
    public int año {get; set;}
    public string Color {get; set;}=null!;
}
