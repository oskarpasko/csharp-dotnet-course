namespace UnitConverter
{

    // abstract class to create new classes with unit converters
    public abstract class Unit
    {
        // method to getting a value which we will convert
        public abstract void get_value();

        // method to getting a unit of value which we are converting
        public abstract int get_unit();

        // method to writing a result
        // parameters:
        // v = our start value
        // results = an array with all results
        // resultUnit = an array with all units
        // startUnit = a value returned from methof get_unit()
        public abstract void write_result(double v, double[] results, string[] resultsUnit, int startUnit);

        // method with convert mechanism 
        public abstract void mechanism();
    }
}