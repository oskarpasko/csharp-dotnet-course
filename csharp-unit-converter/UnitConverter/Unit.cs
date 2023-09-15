 namespace UnitConverter
 {

    public abstract class Unit
    {
        public abstract void get_number();
        public abstract int get_unit();
        public abstract void write_result(double v, double[] results, string[] resultsUnit, int start_unit);
        public abstract void mechanism();
    }
 }
        