namespace C_OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Theoretical Questions

            #region (Q1) Overloading, Overriding & Binding

            // (a)
            /*
             * Method Overloading:
             * Defining multiple methods with the same name but different parameter lists.
             * 
             * Method coverriding:
             * Providing a new implementation for an inherited Method.
             */

            //---------------------------------------------------

            // (b)
            /*
             *  Static Binding:
             *  1) compilation time
             *  2) occurs with method hiding using [new]
             *  3) call method based on reference [parent]
             *  
             *  
             *   Dynamic Binding:
             *   1) Run time
             *   2) Occurs with [override] and virtual methods
             *   3) call method based on object [child]
             */


            #endregion

            #region (Q2) Sealed Classes and Methods

            // (a)
            /*
             *  its means that it Prevents other classes from inheriting
             */

            // (b)
            /*
             * Sealed class:
             * Prevents a class from being inherited.
             *
             * Sealed method:
             * Prevents a method from being overridden in a derived class.
             */

            // (c)
            /*
             * No,a sealed method cannot be overridden again because
             * the sealed keyword prevents further overriding
             */
            #endregion


            #endregion



        }
    }
}
