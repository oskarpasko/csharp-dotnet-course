 namespace UnitConverter
 {

    public abstract class Unit
    {
        public abstract void get_number();
        public abstract int get_unit();
        public abstract void write_result(double nr, double[] results, string[] resultsUnit);
        public abstract void mechanism();
    }
 }
        