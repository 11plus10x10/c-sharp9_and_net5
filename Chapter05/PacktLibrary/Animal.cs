using System;

namespace PacktLibrary
{
    // Bare minimum
    
    // public class Animal
    // {
    //     public Animal()
    //     {
    //         // Allocate any unmanaged resources.
    //     }
    //
    //     // Finalizer aka destructor.
    //     ~Animal()
    //     {
    //         // deallocate any unmanaged resources.
    //     }
    // }
    
    
    // Good boi way

    public class Animal : IDisposable
    {
        public Animal()
        {
            // Allocating unmanaged resources
        }

        // Finalizer.
        ~Animal()
        {
            if (disposed) return;
            Dispose(false);
        }

        // Have resources been released?
        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;
             // Deallocate the *unmanaged* resource.
             // ...

             if (disposing) {
                 // deallocate any other *managed* resource
                 // ...
            }

            disposed = true;
        }
    }
}


// using (Animal a = new Animal())
// {
// // code that uses the Animal instance
// }