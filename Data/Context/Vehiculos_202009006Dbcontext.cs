using vehiculo_20200906.Data.Models;
using Microsoft.EntiyFrameworkCore;

namespace vehiculo_20200906.Data.Contex;

public class vehiculo_20200906DbContext:Dbvehiculo_20200906DbContext,Ivehiculo_20200906DbContext
{
    public vehiculo_20200906DbContext(dbContextOptions options):base (options)
    {

    }
    public virtual Dbset <vehiculo> vehiculo{get; set;}=null!;


   
   
    public override int saveCanges()
    {
        return base.saveChanges();
    }
    public override task<int> saveChangesAsync(cancellationToken cancellationToken = default)
    {
        return base.saveChangesAsync(cancellationToken);    
    }
    
    public interface Ivehiculo_20200906DbContext
    {
        public Dbset <vehiculo> vehiculo {get; set;}

        public int saveCanges();
        public task<int> saveChangesAsync( CancellationToken CancellationToken = default);
    }

}

